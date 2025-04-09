namespace Client_tic_tac_toe
{
    partial class PageGame
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Panel gameBoard;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();
            //
            // lblPlayer1
            //
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer1.AutoSize = false;
            this.lblPlayer1.Location = new System.Drawing.Point(50, 12);
            this.lblPlayer1.Size = new System.Drawing.Size(200, 20);
            this.lblPlayer1.Text = "Player1";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblVS
            //
            this.lblVS = new System.Windows.Forms.Label();
            this.lblVS.AutoSize = false;
            this.lblVS.Location = new System.Drawing.Point(125, 26);
            this.lblVS.Size = new System.Drawing.Size(50, 20);
            this.lblVS.Text = "VS";
            this.lblVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblPlayer2
            //
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer2.AutoSize = false;
            this.lblPlayer2.Location = new System.Drawing.Point(50, 40);
            this.lblPlayer2.Size = new System.Drawing.Size(200, 20);
            this.lblPlayer2.Text = "Player2";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // gameBoard
            //
            this.gameBoard = new System.Windows.Forms.Panel();
            this.gameBoard.Location = new System.Drawing.Point(60, 75);
            this.gameBoard.Size = new System.Drawing.Size(180, 180);
            //
            //button1
            //
            this.button1 = new System.Windows.Forms.Button();
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Size = new System.Drawing.Size(60, 60); 
            this.button1.Tag = 0;
            //this.button1.UseVisualStyleBackColor = true;
            //this.gameBoard.Controls.Add(this.button1);
            //
            //button2
            //
            this.button2 = new System.Windows.Forms.Button();
            this.button2.Location = new System.Drawing.Point(60, 0);
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.Tag = 1;
            //this.button2.UseVisualStyleBackColor = true;
            //this.gameBoard.Controls.Add(this.button2);
            //
            //button3
            //
            this.button3 = new System.Windows.Forms.Button();
            this.button3.Location = new System.Drawing.Point(120, 0);
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.Tag = 2;
            //this.button3.UseVisualStyleBackColor = true;
            //this.gameBoard.Controls.Add(this.button3);
            //
            //button4
            //
            this.button4 = new System.Windows.Forms.Button();
            this.button4.Location = new System.Drawing.Point(0, 60);
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.Tag = 3;
            //this.button4.UseVisualStyleBackColor = true;
            //this.gameBoard.Controls.Add(this.button4);
            //
            //button5
            //
            this.button5 = new System.Windows.Forms.Button();
            this.button5.Location = new System.Drawing.Point(60, 60);
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.Tag = 4;
            //this.button5.UseVisualStyleBackColor = true;
            //this.gameBoard.Controls.Add(this.button5);
            //
            //button6
            //
            this.button6 = new System.Windows.Forms.Button();
            this.button6.Location = new System.Drawing.Point(120, 60);
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.Tag = 5;
            //this.button6.UseVisualStyleBackColor = true;
            //this.gameBoard.Controls.Add(this.button6);
            //
            //button7
            //
            this.button7 = new System.Windows.Forms.Button();
            this.button7.Location = new System.Drawing.Point(0, 120);
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.Tag = 6;
            //this.button7.UseVisualStyleBackColor = true;
            //this.gameBoard.Controls.Add(this.button7);
            //
            //button8
            //
            this.button8 = new System.Windows.Forms.Button();
            this.button8.Location = new System.Drawing.Point(60, 120);
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.Tag = 7;
            //this.button8.UseVisualStyleBackColor = true;
            //this.gameBoard.Controls.Add(this.button8);
            //
            //button9
            //
            this.button9 = new System.Windows.Forms.Button();
            this.button9.Location = new System.Drawing.Point(120, 120);
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.Tag = 8;
            //this.button9.UseVisualStyleBackColor = true;
            //this.gameBoard.Controls.Add(this.button9);
            //
            // gameBoard.Controls
            //
            this.gameBoard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.button1, this.button2, this.button3,
                this.button4, this.button5, this.button6,
                this.button7, this.button8, this.button9
            });
            //
            // btnLeave
            //
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnLeave.Location = new System.Drawing.Point(87, 372);
            this.btnLeave.Size = new System.Drawing.Size(126, 38);
            this.btnLeave.Text = "Покинуть матч";
            //
            // Form settings
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.gameBoard);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblPlayer1);
            this.Name = "PageGame";
            this.Text = "PageGame";

            this.ResumeLayout(false);
        }
        #endregion
    }
}