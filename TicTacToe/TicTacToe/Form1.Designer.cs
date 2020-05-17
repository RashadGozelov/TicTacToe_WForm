namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTurn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblPlayer2Score = new System.Windows.Forms.Label();
            this.LblPlayer1Score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnPlayAgain = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlButtons
            // 
            this.PnlButtons.BackgroundImage = global::TicTacToe.Properties.Resources._512x512bb;
            this.PnlButtons.Location = new System.Drawing.Point(0, 0);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(270, 509);
            this.PnlButtons.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.LblTurn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(313, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 68);
            this.panel1.TabIndex = 1;
            // 
            // LblTurn
            // 
            this.LblTurn.AutoSize = true;
            this.LblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTurn.Location = new System.Drawing.Point(72, 37);
            this.LblTurn.Name = "LblTurn";
            this.LblTurn.Size = new System.Drawing.Size(0, 22);
            this.LblTurn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sıradakı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.LblPlayer2Score);
            this.panel2.Controls.Add(this.LblPlayer1Score);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(313, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 68);
            this.panel2.TabIndex = 2;
            // 
            // LblPlayer2Score
            // 
            this.LblPlayer2Score.AutoSize = true;
            this.LblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer2Score.Location = new System.Drawing.Point(123, 37);
            this.LblPlayer2Score.Name = "LblPlayer2Score";
            this.LblPlayer2Score.Size = new System.Drawing.Size(17, 18);
            this.LblPlayer2Score.TabIndex = 4;
            this.LblPlayer2Score.Text = "0";
            // 
            // LblPlayer1Score
            // 
            this.LblPlayer1Score.AutoSize = true;
            this.LblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer1Score.Location = new System.Drawing.Point(31, 37);
            this.LblPlayer1Score.Name = "LblPlayer1Score";
            this.LblPlayer1Score.Size = new System.Drawing.Size(17, 18);
            this.LblPlayer1Score.TabIndex = 3;
            this.LblPlayer1Score.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Oyunçu 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Oyunçu 1";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.SystemColors.Control;
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(313, 350);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(174, 33);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Sıfırla";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnPlayAgain
            // 
            this.BtnPlayAgain.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayAgain.Location = new System.Drawing.Point(313, 389);
            this.BtnPlayAgain.Name = "BtnPlayAgain";
            this.BtnPlayAgain.Size = new System.Drawing.Size(174, 33);
            this.BtnPlayAgain.TabIndex = 4;
            this.BtnPlayAgain.Text = "Yenidən Oyna";
            this.BtnPlayAgain.UseVisualStyleBackColor = false;
            this.BtnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources._512x512bb;
            this.ClientSize = new System.Drawing.Size(514, 509);
            this.Controls.Add(this.BtnPlayAgain);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlButtons);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPlayer2Score;
        private System.Windows.Forms.Label LblPlayer1Score;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnPlayAgain;
    }
}

