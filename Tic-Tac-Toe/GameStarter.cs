using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    class GameStarter
    {

        public GameStarter(string gameName)
        {
            if (gameName == "TicTacToe")
            {
                startTicTacToe();
            }
            else
            {
                MessageBox.Show("Game not found");
            }
        }
        private void startTicTacToe()
        {
            fmGameBoard gb = new fmGameBoard();
            fmTicTacToe t = new fmTicTacToe();
            gb.Show();
            t.Hide();
        }
    }
}
