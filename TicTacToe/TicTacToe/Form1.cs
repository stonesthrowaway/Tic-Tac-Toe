using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        PictureBox[,] picGrid = new PictureBox[3, 3];
        int[] wins = new int[2] { 0, 0 };
        string[,] board = new string[3, 3] { { null, null, null }, 
                                             { null, null, null }, 
                                             { null, null, null } };
        bool isValid = true;
        int xwins = 0;
        int owins = 0;
        byte movesMade = 0;
        string turn = "X";
        bool gameOver = false;
        
        public Form1()
        {
            InitializeComponent();
            
            picGrid[0, 0] = pictureBox1;
            picGrid[0, 1] = pictureBox2;
            picGrid[0, 2] = pictureBox3;
            picGrid[1, 0] = pictureBox4;
            picGrid[1, 1] = pictureBox5;
            picGrid[1, 2] = pictureBox6;
            picGrid[2, 0] = pictureBox7;
            picGrid[2, 1] = pictureBox8;
            picGrid[2, 2] = pictureBox9;
            
        }

        private void move(byte x, byte y) 
        {
            if (gameOver != true)
                validMove(x, y);

            if (isValid && gameOver != true)
            {
                doMove(x, y, turn);
                movesMade += 1;
                checkWin(turn);
                changeTurn();
            }
        }
        
        private void validMove(byte x, byte y)
        {
            if (board[x, y] == null)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
                MessageBox.Show("Invalid Move!");
            }
        }
        
        private void doMove(byte x, byte y, string turn)
        {
            switch (turn)
            {
                case "X":
                    board[x, y] = turn;
                    picGrid[x, y].Image = Properties.Resources.tictactoeX;
                    picGrid[x, y].SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "O":
                    board[x, y] = turn;
                    picGrid[x, y].Image = Properties.Resources.tictactoeO;
                    picGrid[x, y].SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
            }
            
        }

        private void checkWin(string turn) 
        {
            //Win down left side
            if (board[0, 0] == turn && board[1, 0] == turn && board[2, 0] == turn)
            {
                winPicChange(0, 0, 1, 0, 2, 0, turn);
                MessageBox.Show(turn + " Wins!");
                gameOver = true;
                results(turn);
            }

            //Win down the middle
            else if (board[0, 1] == turn && board[1, 1] == turn && board[2, 1] == turn)
            {
                winPicChange(0, 1, 1, 1, 2, 1, turn);
                MessageBox.Show(turn + " Wins!");
                gameOver = true;
                results(turn);
            }

            //Win down right side
            else if (board[0, 2] == turn && board[1, 2] == turn && board[2, 2] == turn)
            {
                winPicChange(0, 2, 1, 2, 2, 2, turn);
                MessageBox.Show(turn + " Wins!");
                gameOver = true;
                results(turn);
            }

            //Win across top
            else if (board[0, 0] == turn && board[0, 1] == turn && board[0, 2] == turn)
            {
                winPicChange(0, 0, 0, 1, 0, 2, turn);
                MessageBox.Show(turn + " Wins!");
                gameOver = true;
                results(turn);
            }

            //Win across middle
            else if (board[1, 0] == turn && board[1, 1] == turn && board[1, 2] == turn)
            {
                winPicChange(1, 0, 1, 1, 1, 2, turn);
                MessageBox.Show(turn + " Wins!");
                gameOver = true;
                results(turn);
            }

            //Win across bottom
            else if (board[2, 0] == turn && board[2, 1] == turn && board[2, 2] == turn)
            {
                winPicChange(2, 0, 2, 1, 2, 2, turn);
                MessageBox.Show(turn + " Wins!");
                gameOver = true;
                results(turn);
            }

            //Win from top left to bottom right
            else if (board[0, 0] == turn && board[1, 1] == turn && board[2, 2] == turn)
            {
                winPicChange(0, 0, 1, 1, 2, 2, turn);
                MessageBox.Show(turn + " Wins!");
                gameOver = true;
                results(turn);
            }

            //Win from top right to bottom left
            else if (board[0, 2] == turn && board[1, 1] == turn && board[2, 0] == turn)
            {
                winPicChange(0, 2, 1, 1, 2, 0, turn);
                MessageBox.Show(turn + " Wins!");
                gameOver = true;
                results(turn);
            }

            //Draw
            else if(movesMade == 9 && gameOver != true)
            {
                MessageBox.Show("It's a Draw!");
            }
        }

        private void changeTurn()
        {
            if (turn == "X")
                turn = "O";
            else
                turn = "X";
        }

        private void clearGame() 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    picGrid[i, j].Image = null;
                }
            }

            turn = "x";
            movesMade = 0;
            isValid = true;
            gameOver = false;
            Array.Clear(board, 0, board.Length);
        }

        private void results(string turn)
        {
            //Display who won
            switch (turn)
            {
                case "X":
                    xwins += 1;
                    labelGamesWonXDisplay.Text = xwins.ToString();
                    break;
                case "O":
                    owins += 1;
                    labelGamesWonODisplay.Text = owins.ToString();
                    break;
            }
        }

        private void winPicChange(byte x1, byte y1, byte x2, byte y2, byte x3, byte y3, string turn)
        {
            //Change the winning tiles red
            switch (turn) 
            { 
                case "X":
                    picGrid[x1, y1].Image = Properties.Resources.tictactoeXWins;
                    picGrid[x2, y2].Image = Properties.Resources.tictactoeXWins;
                    picGrid[x3, y3].Image = Properties.Resources.tictactoeXWins;
                    break;
                case "O":
                    picGrid[x1, y1].Image = Properties.Resources.tictactoeOWin;
                    picGrid[x2, y2].Image = Properties.Resources.tictactoeOWin;
                    picGrid[x3, y3].Image = Properties.Resources.tictactoeOWin;
                    break;
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            move(0, 0);
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            move(0, 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            move(0, 2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            move(1, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            move(1, 1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            move(1, 2);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            move(2, 0);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            move(2, 1);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            move(2, 2);
        }

        private void buttonClearGame_Click(object sender, EventArgs e)
        {
            clearGame();
        }

        private void buttonClearScore_Click(object sender, EventArgs e)
        {

        }
    }
}
