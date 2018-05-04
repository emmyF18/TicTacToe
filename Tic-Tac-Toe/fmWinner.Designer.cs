namespace Tic_Tac_Toe
{
    partial class fmWinner
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
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblWinnerMessage = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(68, 68);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(141, 25);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "Winner: Player";
            // 
            // lblWinnerMessage
            // 
            this.lblWinnerMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerMessage.Location = new System.Drawing.Point(0, 128);
            this.lblWinnerMessage.Name = "lblWinnerMessage";
            this.lblWinnerMessage.Size = new System.Drawing.Size(284, 33);
            this.lblWinnerMessage.TabIndex = 1;
            this.lblWinnerMessage.Text = "Good Game!";
            this.lblWinnerMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(113, 164);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(75, 23);
            this.btnAgain.TabIndex = 2;
            this.btnAgain.Text = "Play Again";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // fmWinner
            // 
            this.AcceptButton = this.btnAgain;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 262);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.lblWinnerMessage);
            this.Controls.Add(this.lblWinner);
            this.Name = "fmWinner";
            this.Text = "Winner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWinnerMessage;
        private System.Windows.Forms.Button btnAgain;
        public System.Windows.Forms.Label lblWinner;
    }
}