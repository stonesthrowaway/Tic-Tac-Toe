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
        public Form1()
        {
            InitializeComponent();
        }

        Image imageX = Image.FromFile(@"C:\Users\Vorpel\Documents\Visual Studio 2010\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Resources\tictactoex.jpg");
        Image imageO = Image.FromFile(@"C:\Users\Vorpel\Documents\Visual Studio 2010\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Resources\tictactoeO.jpg");
        string turn = "x";
        string[,] board = new string[3, 3] { { null, null, null }, 
                                             { null, null, null }, 
                                             { null, null, null } };
        bool isValid = true;
        int xwins = 0;
        int owins = 0;

        public void validMove(byte x, byte y, string turn)
        {
            if (board[x, y] == null)
            {
                isValid = true;
                board[x, y] = turn;
            }
            else
            {
                isValid = false;
                MessageBox.Show("Invalid Move!");
            }
        }
        
        private void doMove(byte x, byte y)
        {
            if (turn == "x")
            {
                pictureBox1.Image = imageX;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                turn = "o";
            }
            else
            {
                pictureBox4.Image = imageO;
                pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
                turn = "x";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            validMove(0, 0, turn);

            if (isValid)
            {
                if (turn == "x")
                {
                    pictureBox1.Image = imageX;
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "o";
                }

                else
                {
                    pictureBox1.Image = imageO;
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "x";
                }
            }
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            validMove(0, 1, turn);

            if (isValid)
            {
                if (turn == "x")
                {
                    pictureBox2.Image = imageX;
                    pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "o";
                }

                else
                {
                    pictureBox2.Image = imageO;
                    pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "x";
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            validMove(0, 2, turn);

            if (isValid)
            {
                if (turn == "x")
                {
                    pictureBox3.Image = imageX;
                    pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "o";
                }

                else
                {
                    pictureBox3.Image = imageO;
                    pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "x";
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            validMove(1, 0, turn);

            if (isValid)
            {
                if (turn == "x")
                {
                    pictureBox4.Image = imageX;
                    pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "o";
                }

                else
                {
                    pictureBox4.Image = imageO;
                    pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "x";
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            validMove(1, 1, turn);

            if (isValid)
            {
                if (turn == "x")
                {
                    pictureBox5.Image = imageX;
                    pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "o";
                }

                else
                {
                    pictureBox5.Image = imageO;
                    pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "x";
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            validMove(1, 2, turn);

            if (isValid)
            {
                if (turn == "x")
                {
                    pictureBox6.Image = imageX;
                    pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "o";
                }

                else
                {
                    pictureBox6.Image = imageO;
                    pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "x";
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            validMove(2, 0, turn);

            if (isValid)
            {
                if (turn == "x")
                {
                    pictureBox7.Image = imageX;
                    pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "o";
                }

                else
                {
                    pictureBox7.Image = imageO;
                    pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "x";
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            validMove(2, 1, turn);

            if (isValid)
            {
                if (turn == "x")
                {
                    pictureBox8.Image = imageX;
                    pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "o";
                }

                else
                {
                    pictureBox8.Image = imageO;
                    pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "x";
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            validMove(2, 2, turn);

            if (isValid)
            {
                if (turn == "x")
                {
                    pictureBox9.Image = imageX;
                    pictureBox9.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "o";
                }

                else
                {
                    pictureBox9.Image = imageO;
                    pictureBox9.SizeMode = PictureBoxSizeMode.CenterImage;
                    turn = "x";
                }
            }
        }

        private void buttonClearGame_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            turn = "x";
            isValid = true;
            Array.Clear(board, 0, board.Length);
            //xwins += 1;
            //labelGamesWonODisplay.Text = xwins.ToString();
        }
    }
}
