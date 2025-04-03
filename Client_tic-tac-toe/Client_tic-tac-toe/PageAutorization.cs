using System.Windows.Forms;
using System;

namespace Client_tic_tac_toe
{
    public partial class PageAutorization : Form
    {
        public PageAutorization()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string nickname = txtNickname.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(nickname) || string.IsNullOrWhiteSpace(password))
            {
                ApiClient.ShowError("Заполните все поля!");
                return;
            }

            var success = await ApiClient.Login(nickname, password);
            if (success)
            {
                Properties.Settings.Default.CurrentUser = nickname;
                Properties.Settings.Default.Save();

                ApiClient.NavigateTo(this, new PageModeSelection());
            }
            else
            {
                ApiClient.ShowError("Неверный логин или пароль");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            var authForm = new FirstPage();
            authForm.Show();
            this.Hide();
        }

        private bool CheckCredentials(string nickname, string password)
        {
            // TODO: Реализовать проверку через сервер
            return true;
        }

        private void PageAutorization_Load(object sender, EventArgs e)
        {

        }
    }
}
