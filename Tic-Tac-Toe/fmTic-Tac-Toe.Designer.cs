namespace Tic_Tac_Toe
{
    partial class fmTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTicTacToe));
            this.lblTicTacToe = new System.Windows.Forms.Label();
            this.lblHowTo = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTicTacToe
            // 
            this.lblTicTacToe.AutoSize = true;
            this.lblTicTacToe.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacToe.Location = new System.Drawing.Point(99, 18);
            this.lblTicTacToe.Name = "lblTicTacToe";
            this.lblTicTacToe.Size = new System.Drawing.Size(159, 29);
            this.lblTicTacToe.TabIndex = 0;
            this.lblTicTacToe.Text = "Tic-Tac-Toe";
            // 
            // lblHowTo
            // 
            this.lblHowTo.AutoSize = true;
            this.lblHowTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowTo.Location = new System.Drawing.Point(116, 69);
            this.lblHowTo.Name = "lblHowTo";
            this.lblHowTo.Size = new System.Drawing.Size(123, 25);
            this.lblHowTo.TabIndex = 1;
            this.lblHowTo.Text = "How To Play";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(21, 116);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(338, 183);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(134, 290);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Playing";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // fmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 343);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblHowTo);
            this.Controls.Add(this.lblTicTacToe);
            this.Name = "fmTicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicTacToe;
        private System.Windows.Forms.Label lblHowTo;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnStart;
    }
}

