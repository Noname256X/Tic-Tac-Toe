namespace Client_tic_tac_toe
{
    partial class PageRegistration
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(65, 80);
            this.txtNickname.Name = "txtNickname";  
            this.txtNickname.PlaceholderText = "Никнейм";
            this.txtNickname.Size = new System.Drawing.Size(170, 30);
            this.txtNickname.TabIndex = 0;  
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(65, 130);
            this.txtPassword.Name = "txtPassword";  
            this.txtPassword.PlaceholderText = "Пароль";
            this.txtPassword.Size = new System.Drawing.Size(170, 30);
            this.txtPassword.TabIndex = 1;  
            this.txtPassword.UseSystemPasswordChar = true;

            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(87, 180);
            this.btnRegister.Name = "btnRegister";  
            this.btnRegister.Size = new System.Drawing.Size(126, 38);
            this.btnRegister.TabIndex = 2;  
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
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
            // PageRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);  
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNickname);
            this.Name = "PageRegistration";  
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();  
        }

        #endregion
    }
}
