using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Button[,] buttons;
        private int currentPlayer;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Tic-Tac-Toe Oyunu Başladı!");
        }

        private void InitializeGame()
        {
            buttons = new Button[3, 3];
            currentPlayer = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button
                    {
                        Size = new Size(60, 60),
                        Location = new Point(j * 70, i * 70),
                        Font = new Font("Arial", 20),
                        Tag = new Point(i, j),
                        Enabled = true
                    };
                    buttons[i, j].Click += Button_Click;
                    Controls.Add(buttons[i, j]);
                }
            }
          
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point location = (Point)clickedButton.Tag;

            if (buttons[location.X, location.Y].Enabled)
            {
                buttons[location.X, location.Y].Text = currentPlayer == 1 ? "X" : "O";
                buttons[location.X, location.Y].Enabled = false;

                string winner = CheckForWin();
                if (!string.IsNullOrEmpty(winner))
                {
                    MessageBox.Show($"Oyuncu {winner} Kazandı!");
                    ResetGame();
                }
                else if (CheckForDraw())
                {
                    MessageBox.Show("Beraberlik!");
                    ResetGame();
                }
                else
                {
                    currentPlayer = (currentPlayer == 1) ? 2 : 1;
                }
            }
        }

        private string CheckForWin()
        {
            
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i, 0].Text == buttons[i, 1].Text && buttons[i, 1].Text == buttons[i, 2].Text && buttons[i, 0].Text != "")
                    return buttons[i, 0].Text;
            }

            
            for (int j = 0; j < 3; j++)
            {
                if (buttons[0, j].Text == buttons[1, j].Text && buttons[1, j].Text == buttons[2, j].Text && buttons[0, j].Text != "")
                    return buttons[0, j].Text;
            }

            
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text && buttons[0, 0].Text != "")
                return buttons[0, 0].Text;

            if (buttons[0, 2].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 0].Text && buttons[0, 2].Text != "")
                return buttons[0, 2].Text;

            return "";
        }

        private bool CheckForDraw()
        {
            
            

            return false;
        }

        private void ResetGame()
        {
            
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }

            currentPlayer = 1;
        }

    }
}
