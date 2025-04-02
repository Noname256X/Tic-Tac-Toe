using System.Drawing;
using System.Windows.Forms;

namespace Client_tic_tac_toe
{
    partial class PageAutorization
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(65, 80);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.PlaceholderText = "Никнейм";
            this.txtNickname.Size = new System.Drawing.Size(170, 23);
            this.txtNickname.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Пароль";
            this.txtPassword.Size = new System.Drawing.Size(170, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(87, 180);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 38);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Авторизоваться";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(87, 238);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 38);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PageAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNickname);
            this.Name = "PageAutorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.PageAutorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
