using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

public static class ApiClient
{
    private static readonly HttpClient _client = new HttpClient();
    private const string BaseUrl = "http://localhost:5000";

    public static async Task<bool> Login(string nickname, string password)
    {
        try
        {
            var response = await _client.PostAsJsonAsync(
                $"{BaseUrl}/api/login",
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
                $"{BaseUrl}/api/register",
                new { Nickname = nickname, Password = password });

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
            var response = await _client.GetAsync($"{BaseUrl}/api/account?nickname={nickname}");
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
