using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace Client_tic_tac_toe
{
    public partial class PageAccount : Form
    {
        private string _currentUser;

        public PageAccount()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _currentUser = Properties.Settings.Default.CurrentUser;
        }

        private async void PageAccount_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentUser))
            {
                ApiClient.ShowError("Необходимо авторизоваться!");
                this.Close();
                return;
            }

            try
            {
                var userData = await ApiClient.GetUserData(_currentUser);
                if (userData != null)
                {
                    lblNickname.Text = $"Никнейм: {userData.Username}";
                    lblGamesPlayed.Text = $"Всего игр: {userData.GamesPlayed}";
                    lblWinRate.Text = $"Процент побед: {Math.Round(userData.WinRate, 1)}%";
                }
            }
            catch (Exception ex)
            {
                ApiClient.ShowError($"Ошибка загрузки данных: {ex.Message}");
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentUser = "";
            Properties.Settings.Default.Save();

            var firstPage = new FirstPage();
            firstPage.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var modeSelection = new PageModeSelection();
            modeSelection.Show();
            this.Hide();
        }
    }
}
