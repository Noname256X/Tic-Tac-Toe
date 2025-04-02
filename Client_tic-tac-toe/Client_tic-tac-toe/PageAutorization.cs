using System.Windows.Forms;
using System;

namespace Client_tic_tac_toe
{
    public partial class PageAutorization : Form
    {
        public PageAutorization()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Логика авторизации
            string nickname = txtNickname.Text;
            string password = txtPassword.Text;

            if (CheckCredentials(nickname, password))
            {
                MessageBox.Show("Успешный вход!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации");
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
