using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

public static class ApiClient
{

    private static HttpClient? _client;
    private static string? _baseUrl;

    public static string GetBaseUrl() => _baseUrl ?? string.Empty;

    public static void SetBaseUrl(string baseUrl)
    {
        _baseUrl = baseUrl.TrimEnd('/');
        _client?.Dispose();
        _client = new HttpClient { BaseAddress = new Uri(_baseUrl) };
    }

    public static async Task<bool> CheckServerAvailability()
    {
        try
        {
            var response = await _client.GetAsync("/api/health");
            Console.WriteLine($"Статус ответа: {response.StatusCode}");
            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            return false;
        }
    }


    public static async Task<bool> Login(string nickname, string password)
    {
        if (_client == null) return false;

        try
        {
            var response = await _client.PostAsJsonAsync(
                "/api/login",
                new { Nickname = nickname, Password = password });

            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            ShowError($"Ошибка соединения: {ex.Message}");
            return false;
        }
    }

    public static async Task<bool> Register(string nickname, string password)
    {
        try
        {
            var response = await _client.PostAsJsonAsync(
                "/api/register",
                new { Nickname = nickname, Password = password });

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                    ShowError("Никнейм уже занят");
                return false;
            }

            if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                ShowError("Никнейм уже занят");
                return false;
            }

            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            ShowError($"Ошибка соединения: {ex.Message}");
            return false;
        }
    }

    public static async Task<UserData> GetUserData(string nickname)
    {
        try
        {
            var response = await _client.GetAsync($"/api/account?nickname={nickname}");
            if (!response.IsSuccessStatusCode) return null;

            return await response.Content.ReadFromJsonAsync<UserData>();
        }
        catch
        {
            throw new Exception("Не удалось получить данные аккаунта");
        }
    }


    public static void ShowError(string message)
    {
        MessageBox.Show(message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void NavigateTo(Form currentForm, Form newForm)
    {
        newForm.Show();
        currentForm.Hide();
    }
}
