using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Npgsql;
using System.Security.Cryptography;
using System.Text;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddCors();

// PostreSQL 
Env.Load();

var connectionString =
    $"Host={Environment.GetEnvironmentVariable("DB_HOST")}; " +
    $"Port={Environment.GetEnvironmentVariable("DB_PORT")}; " +
    $"Username={Environment.GetEnvironmentVariable("DB_USERNAME")}; " +
    $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")}; " +
    $"Database={Environment.GetEnvironmentVariable("DB_NAME")}";

var conn = new NpgsqlConnection(connectionString);
try
{
    conn.Open();
    Console.WriteLine("Successfully connected to PostgreSQL!");
    conn.Close();
}
catch (Exception ex)
{
    Console.WriteLine($"DB connection error: {ex.Message}");
}

var app = builder.Build();

app.UseCors(policy => policy
    .AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins("http://localhost:5000")
    .AllowCredentials());


app.MapPost("/api/login", async (LoginRequest request) =>
{
    using var conn = new NpgsqlConnection(connectionString);
    await conn.OpenAsync();

    var cmd = new NpgsqlCommand(
        @"SELECT password_hash FROM players WHERE username = @nickname",
        conn);
    cmd.Parameters.AddWithValue("nickname", request.Nickname);

    var dbPassword = (await cmd.ExecuteScalarAsync())?.ToString();
    var isValid = dbPassword != null && BCrypt.Net.BCrypt.Verify(request.Password, dbPassword);

    return isValid ? Results.Ok() : Results.Unauthorized();
});


app.MapPost("/api/register", async (RegisterRequest request) =>
{
    using var conn = new NpgsqlConnection(connectionString);
    await conn.OpenAsync();

    try
    {
        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);
        var cmd = new NpgsqlCommand(
            @"INSERT INTO players (username, password_hash) 
            VALUES (@nickname, @password)",
            conn);

        cmd.Parameters.AddWithValue("nickname", request.Nickname);
        cmd.Parameters.AddWithValue("password", hashedPassword);

        await cmd.ExecuteNonQueryAsync();
        Console.WriteLine($"User {request.Nickname} registered");
        return Results.Ok();
    }
    catch (PostgresException ex) when (ex.SqlState == "23505")
    {
        Console.WriteLine($"Nickname conflict: {request.Nickname}");
        return Results.Conflict("Nickname already exists");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Registration error: {ex.Message}");
        return Results.Problem("Internal error");
    }
});

// Добавьте после регистрации и до UseCors
app.MapGet("/api/account", async (string nickname) =>
{
    try
    {
        using var conn = new NpgsqlConnection(connectionString);
        await conn.OpenAsync();

        var cmd = new NpgsqlCommand(
            @"SELECT username, games_played, win_rate 
            FROM players WHERE username = @nickname",
            conn);

        cmd.Parameters.AddWithValue("nickname", nickname);
        var reader = await cmd.ExecuteReaderAsync();

        if (reader.Read())
        {
            return Results.Ok(new
            {
                Username = reader["username"],
                GamesPlayed = reader["games_played"],
                WinRate = reader["win_rate"]
            });
        }
        return Results.NotFound();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Account data error: {ex.Message}");
        return Results.Problem("Internal error");
    }
});


app.UseCors(policy => policy
    .AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins("http://localhost:5000", "https://localhost:5001")
    .AllowCredentials());

app.MapHub<GameHub>("/gamehub");

app.Urls.Add("http://localhost:5000");
app.Urls.Add("https://localhost:5001");
app.Run();

public record LoginRequest(string Nickname, string Password);
public record RegisterRequest(string Nickname, string Password);

public class GameSession
{
    public string Player1 { get; set; }
    public string Player2 { get; set; }
    public string[] Board { get; } = new string[9];
    public bool IsPlayer1Turn { get; set; } = true;
}

public class GameHub : Hub
{
    private static Dictionary<string, GameSession> _sessions = new();

    public async Task CreateGame()
    {
        var sessionId = Guid.NewGuid().ToString();
        _sessions[sessionId] = new GameSession { Player1 = Context.ConnectionId };
        await Clients.Caller.SendAsync("GameCreated", sessionId);
    }

    public async Task JoinGame(string sessionId)
    {
        if (_sessions.TryGetValue(sessionId, out var session))
        {
            session.Player2 = Context.ConnectionId;
            await Clients.Group(sessionId).SendAsync("GameStarted");
        }
    }

    public async Task MakeMove(string sessionId, int cellIndex)
    {
        if (!_sessions.TryGetValue(sessionId, out var session)) return;

        var playerSign = session.IsPlayer1Turn ? "X" : "O";
        session.Board[cellIndex] = playerSign;

        await Clients.Group(sessionId).SendAsync("MoveMade", cellIndex, playerSign);

        if (CheckWin(session.Board, playerSign))
            await Clients.Group(sessionId).SendAsync("GameWon", playerSign);

        session.IsPlayer1Turn = !session.IsPlayer1Turn;
    }

    private bool CheckWin(string[] board, string sign)
    {
        for (var i = 0; i < 9; i += 3)
            if (board[i] == sign && board[i + 1] == sign && board[i + 2] == sign)
                return true;

        for (var i = 0; i < 3; i++)
            if (board[i] == sign && board[i + 3] == sign && board[i + 6] == sign)
                return true;

        return (board[0] == sign && board[4] == sign && board[8] == sign) ||
               (board[2] == sign && board[4] == sign && board[6] == sign);
    }
}
