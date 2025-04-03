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
            if (string.IsNullOrWhiteSpace(txtNickname.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ApiClient.ShowError("Заполните все поля!");
                return;
            }

            var success = await ApiClient.Login(txtNickname.Text, txtPassword.Text);
            if (success)
            {
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
