namespace Client_tic_tac_toe
{
    partial class FirstPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtServerAddress;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Font = new System.Drawing.Font("Arial", 10F);
            this.txtServerAddress.Location = new System.Drawing.Point(87, 53);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(126, 30);
            this.txtServerAddress.TabIndex = 0;
            this.txtServerAddress.PlaceholderText = "http://localhost:5000";
            // 
            // btnAuth
            // 
            this.btnAuth.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAuth.Location = new System.Drawing.Point(87, 127);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(126, 38);
            this.btnAuth.TabIndex = 1;
            this.btnAuth.Text = "Авторизация";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Arial", 10F);
            this.btnReg.Location = new System.Drawing.Point(87, 209);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(126, 38);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.txtServerAddress);
            this.Name = "FirstPage";
            this.Text = "Меню авторизации";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
