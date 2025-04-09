using System;
using System.Windows.Forms;
using System.Net.Http;

namespace Client_tic_tac_toe
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private bool ValidateServerAddress()
        {
            var serverAddress = txtServerAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(serverAddress))
            {
                ApiClient.ShowError("Введите адрес сервера!");
                return false;
            }

            if (!Uri.TryCreate(serverAddress, UriKind.Absolute, out _))
            {
                ApiClient.ShowError("Неверный формат адреса сервера!\nПример: http://localhost:5000");
                return false;
            }

            return true;
        }

        private async void btnAuth_Click(object sender, EventArgs e)
        {
            if (!ValidateServerAddress()) return;

            try
            {
                ApiClient.SetBaseUrl(txtServerAddress.Text.Trim());
                var isAvailable = await ApiClient.CheckServerAvailability();
               
                if (!isAvailable)
                {
                    ApiClient.ShowError("Сервер недоступен!");
                    return;
                }

                ApiClient.NavigateTo(this, new PageAutorization());
            }
            catch (Exception ex)
            {
                ApiClient.ShowError($"Ошибка подключения: {ex.Message}");
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (!ValidateServerAddress()) return;

            try
            {
                ApiClient.SetBaseUrl(txtServerAddress.Text.Trim());
                ApiClient.NavigateTo(this, new PageRegistration());
            }
            catch (Exception ex)
            {
                ApiClient.ShowError($"Не удалось подключиться к серверу: {ex.Message}");
            }
        }
    }
}
