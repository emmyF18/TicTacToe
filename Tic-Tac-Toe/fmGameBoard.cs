using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class fmGameBoard : Form
    {
        int moveCount = 0;
        int[,] tictactoes = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }; // 0 is blank, 1 = x , O = 2
        public fmGameBoard()
        {
            InitializeComponent();
        }
        private void GameBoard_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Players Turn First. Pick a Square to Put an X in");
            moveCount = 0;
        }
        private void placeY()
        {
            Random rand = new Random();
            int randomNumber;
            bool foundEmpty = false;
            moveCount++;
            while (!foundEmpty)
            {
                randomNumber = rand.Next(1, 9);
				if (randomNumber == 1 && lblPiece1.Text != "X" && lblPiece1.Text != "O" )
                {
                    lblPiece1.Text = "O";
                    tictactoes[0, 0] = 2;
                    foundEmpty = true;
                }
				else if (randomNumber == 2 && lblPiece2.Text != "X" && lblPiece1.Text != "O")
                {
                    lblPiece2.Text = "O";
                    tictactoes[0, 1] = 2;
                    foundEmpty = true;
                }
				else if (randomNumber == 3 && lblPiece3.Text != "X" && lblPiece1.Text != "O")
                {
                    lblPiece3.Text = "O";
                    tictactoes[0, 2] = 2;
                    foundEmpty = true;
                }
                else if (randomNumber == 4 && lblPiece4.Text != "X")
                {
                    lblPiece4.Text = "O";
                    tictactoes[1, 0] = 2;
                    foundEmpty = true;
                }
                else if (randomNumber == 5 && lblPiece5.Text != "X")
                {
                    lblPiece5.Text = "O";
                    tictactoes[1, 1] = 2;
                    foundEmpty = true;
                }
                else if (randomNumber == 6 && lblPiece6.Text != "X")
                {
                    lblPiece6.Text = "O";
                    tictactoes[1, 2] = 2;
                    foundEmpty = true;
                }
                else if (randomNumber == 7 && lblPiece7.Text != "X")
                {
                    lblPiece7.Text = "O";
                    tictactoes[2, 0] = 2;
                    foundEmpty = true;
                }
                else if (randomNumber == 8 && lblPiece8.Text != "X")
                {
                    lblPiece8.Text = "O";
                    tictactoes[2, 1] = 2;
                    foundEmpty = true;
                }
                else if (randomNumber == 9 && lblPiece9.Text != "X")
                {
                    lblPiece9.Text = "O";
                    tictactoes[2, 2] = 2;
                    foundEmpty = true;
                }
                else
                {
                    foundEmpty = false;
                }
            }
            setWinner();
        }
        private int checkCols() //0 = no win, 1 = x wins, 2 = O wins 3 = tie
        {
            int win = 0;
            int XCount = 0, OCount = 0;
            bool exitLoop;
             /*if (moveCount == 9)
            {
                moveCount = 0;
                win = 3;
                return win;
            } */
            
                for (int rows = 0; rows <= 2; rows++) // each row
                {
                    for (int cols = 0; cols <= 2; cols++) //each col
                    {
                        if (tictactoes[rows, cols] == 1)
                        {
                            XCount++;
                        }
                        else if (tictactoes[rows, cols] == 2)
                        {
                            OCount++;

                        }
                        exitLoop = false;
                        if (XCount == 3)
                        {
                            win = 1;
                            XCount = 0; OCount = 0;
                            exitLoop = true;
                        }
                        else if (OCount == 3)
                        {
                            win = 2;
                            OCount = 0; XCount = 0;
                            exitLoop = true;
                        }
                        if (exitLoop) break;
                    }// end of cols check
                        exitLoop = false;
                    if (XCount == 3)
                    {
                        win = 1;
                        OCount = 0; XCount = 0;
                        exitLoop = true;
                    }
                    else if (OCount == 3)
                    {
                        win = 2;
                        OCount = 0; XCount = 0;
                        exitLoop = true;
                    }
                    else
                    {
                        XCount = 0;
                        OCount = 0;
                    }
                if (exitLoop) break;
            } //end of rows check
            
            return win;
        }
        private int checkRows() //0 = no win, 1 = x wins, 2 = O wins 3 = tie
        {
            int win = 0;
            int XCount = 0, OCount = 0;
            /*if (moveCount == 9) 
            {
                moveCount = 0;
                win = 3;
                return win;
            } */
            
               
                for (int rows = 0; rows <= 2; rows++) // each row
                {
                    for (int cols = 0; cols <= 2; cols++) //each col
                    {
                        bool exitLoop = false;
                        if (tictactoes[rows, cols] == 1)
                        {
                            XCount++;
                            exitLoop = true;
                        }
                        else if (tictactoes[rows, cols] == 2)
                        {
                            OCount++;
                            exitLoop = true;
                        }
                        if (exitLoop) break;
                    }// end of col check

                    bool exit = false;
                    if (XCount == 3)
                    {
                        win = 1;
                        OCount = 0; XCount = 0;
                        exit = true;
                    }
                    else if (OCount == 3)
                    {
                        win = 2;
                        OCount = 0; XCount = 0;
                        exit = true;
                    }
                    if (exit) break;
                   
                } // end of row check
            
            return win;
        }
        private void lblPiece1_Click(object sender, EventArgs e)
        {
            moveCount++;
            lblPiece1.Text = "X";
            tictactoes[0, 0] = 1;
            if (!setWinner())
            {
                placeY();
            }

        }
        private void lblPiece2_Click(object sender, EventArgs e)
        {
            moveCount++;
            lblPiece2.Text = "X";
            tictactoes[0, 1] = 1;
            if (!setWinner())
            {
                placeY();
            }
        }
        private void lblPiece3_Click(object sender, EventArgs e)
        {
            moveCount++;
            lblPiece3.Text = "X";
            tictactoes[0, 2] = 1;
            if (!setWinner())
            {
                placeY();
            }
        }
        private void lblPiece4_Click(object sender, EventArgs e)
        {
            moveCount++;
            lblPiece4.Text = "X";
            tictactoes[1, 0] = 1;
            if (!setWinner())
            {
                placeY();
            }
        }
        private void lblPiece5_Click(object sender, EventArgs e)
        {
            moveCount++;
            lblPiece5.Text = "X";
            tictactoes[1, 1] = 1;
            if (!setWinner())
            {
                placeY();
            }
        }
        private void lblPiece6_Click(object sender, EventArgs e)
        {
            moveCount++;
            lblPiece6.Text = "X";
            tictactoes[1, 2] = 1;
            if (!setWinner())
            {
                placeY();
            }
        }
        private void lblPiece7_Click(object sender, EventArgs e)
        {
            moveCount++;
            lblPiece7.Text = "X";
            tictactoes[2, 0] = 1;
            if (!setWinner())
            {
                placeY();
            }
        }
        private void lblPiece8_Click(object sender, EventArgs e)
        {
            moveCount++;
            lblPiece8.Text = "X";
            tictactoes[2, 1] = 1;
            if (!setWinner())
            {
                placeY();
            }
        }
        private void lblPiece9_Click(object sender, EventArgs e)
        {
            moveCount++;
            lblPiece9.Text = "X";
            tictactoes[2, 2] = 1;
            if (!setWinner())
            {
                placeY();
            }
        }
        private bool setWinner()
        {
            int colWin = checkCols();
            int rowWin = checkRows();
            bool findWin = false;
            if (colWin != 0 || rowWin != 0)
            {

                findWin = true;
                string winner = " None";
                if (colWin == 1 || rowWin == 1)
                {
                    winner = "Person";
                }
                else if (colWin == 2 || rowWin == 2)
                {
                    winner = "Computer";
                }
                else
                {
                    winner = "Tie";
                }
                fmWinner fw = new fmWinner();
                //Thread.Sleep(200);
                fw.displayWinner(winner);
                Hide();

            }
            else
            {
                findWin = false;
            }
            return findWin;
        }
    }
}
