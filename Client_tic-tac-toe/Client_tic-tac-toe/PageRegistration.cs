using System.Windows.Forms;

namespace Client_tic_tac_toe
{
    public partial class PageRegistration : Form
    {
        public PageRegistration()
        {
            InitializeComponent();
            //this.btnBack.Click += (s, e) => this.Close();
            this.btnRegister.Click += btnRegister_Click;
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            // Логика регистрации
            if (ValidateInput())
            {
                // Отправка данных на сервер
                MessageBox.Show("Регистрация успешна!");
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var authForm = new FirstPage();
            authForm.Show();
            this.Hide();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNickname.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }
            return true;
        }
    }
}
