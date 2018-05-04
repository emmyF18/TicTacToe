using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class fmWinner : Form
    {
        public fmWinner()
        {
            InitializeComponent();
        }

        public void displayWinner(string winner)
        {
            lblWinner.Text = "Winner: " + winner;
            if (winner == "Person") lblWinnerMessage.Text = "Congrats! You are the champion";
            else if(winner == "Computer") lblWinnerMessage.Text = "You Lost. Try Again?";
            else lblWinnerMessage.Text = "Good Game!";
            Show();
        }
        private void btnAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmTicTacToe fm = new fmTicTacToe();
            fm.Hide();
            GameStarter game = new GameStarter("TicTacToe");
        }
    }
}
