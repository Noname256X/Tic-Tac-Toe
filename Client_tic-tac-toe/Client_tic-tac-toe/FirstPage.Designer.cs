using System.Drawing;

namespace Client_tic_tac_toe
{
    partial class FirstPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuth
            // 
            this.btnAuth.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAuth.Location = new System.Drawing.Point(87, 90);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(126, 38);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "Авторизация";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Arial", 10F);
            this.btnReg.Location = new System.Drawing.Point(87, 172);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(126, 38);
            this.btnReg.TabIndex = 1;
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
            this.Name = "FirstPage";
            this.Text = "Меню авторизации";
            this.Load += new System.EventHandler(this.FirstPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnReg;
    }
}
