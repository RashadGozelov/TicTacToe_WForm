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
    public enum Turn
    {
        X,
        O
    }

    public enum Player
    {
        Player1,
        Player2
    }
    public partial class Form1 : Form
    {
        private List<Button> _buttons;
        private Turn _currentTurn;
        private Player _currentPlayer;
        private int _player1Score;
        private int _player2Score;
        private bool _isResume;
        public Form1()
        {
            InitializeComponent();
            _buttons = new List<Button>();
            CreateButton();
            this._currentTurn = Turn.X;
            this._currentPlayer = Player.Player1;

            LblTurn.Text = Turn.X.ToString();
            this.DisplayScore();
            this._isResume = true;
        }

        private void CreateButton()
        {
            int x = 30;
            int y = 50;
            for (int i = 0; i < 9; i++)
            {
                Button button = new Button();
                button.Size = new Size(70, 70);
                button.Font = new Font("Microsoft San Serif", 15,FontStyle.Bold);
                button.Location = new Point(x, y);
                button.BackColor = Color.LightGray;
                button.TabStop = false;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Click += new EventHandler(AllButtonClick);

                PnlButtons.Controls.Add(button);
                _buttons.Add(button);
                x += 80;
                if ((i + 1) % 3 == 0) 
                {
                    y += 150;
                    x = 30;
                }
              
            }
            
        }

        private void AllButtonClick(object sender,EventArgs e)
        {
            Button clicked = sender as Button;
            if (clicked.Text==string.Empty && this._isResume)
            {
                clicked.Text = this._currentTurn.ToString();

                if (CheckWinner())
                {
                    this._isResume = false;
                    return;
                }
                this.ChangeTurn();
            }
        }

        private void ChangeTurn()
        {
            if (this._currentTurn == Turn.X)
            {
                this._currentTurn = Turn.O;
            }
            else
            {
                this._currentTurn = Turn.X;
            }

            if (this._currentPlayer==Player.Player1)
            {
                this._currentPlayer = Player.Player2;
            }
            else
            {
                this._currentPlayer = Player.Player1;
            }
            this.LblTurn.Text = this._currentTurn.ToString();
        }

        private bool CheckWinner()
        {
            if (this._buttons[0].Text != string.Empty &&
                this._buttons[0].Text == this._buttons[1].Text &&
                this._buttons[1].Text == this._buttons[2].Text)
            {
                // 1 2 3 Winner
                this.DisplayWinner(new int[] { 0, 1, 2 });
                return true;
                 //MessageBox.Show()
            }else if(this._buttons[3].Text != string.Empty &&
                     this._buttons[3].Text == this._buttons[4].Text &&
                     this._buttons[4].Text == this._buttons[5].Text)
            {
                // 4 5 6 Winner
                this.DisplayWinner(new int[] { 3, 4, 5 });
                return true;
            }
            else if (this._buttons[6].Text != string.Empty &&
                     this._buttons[6].Text == this._buttons[7].Text &&
                     this._buttons[7].Text == this._buttons[8].Text)
            {
                // 7 8 9 Winner
                this.DisplayWinner(new int[] { 6, 7, 8 });
                return true;
            }
            else if (this._buttons[0].Text != string.Empty &&
                     this._buttons[0].Text == this._buttons[3].Text &&
                     this._buttons[3].Text == this._buttons[6].Text)
            {
                // 0 4 7 Winner
                this.DisplayWinner(new int[] { 0, 3, 6 });
                return true;
            }
            else if (this._buttons[1].Text != string.Empty &&
                     this._buttons[1].Text == this._buttons[4].Text &&
                     this._buttons[4].Text == this._buttons[7].Text)
            {
                // 2 5 8 Winner
                this.DisplayWinner(new int[] { 1, 4, 7 });
                return true;
            }
            else if (this._buttons[2].Text != string.Empty &&
                     this._buttons[2].Text == this._buttons[5].Text &&
                     this._buttons[5].Text == this._buttons[8].Text)
            {
                // 3 6 9 Winner
                this.DisplayWinner(new int[] { 2, 5, 8 });
                return true;
            }
            else if (this._buttons[0].Text != string.Empty &&
                     this._buttons[0].Text == this._buttons[4].Text &&
                     this._buttons[4].Text == this._buttons[8].Text)
            {
                // 1 5 9 Winner
                this.DisplayWinner(new int[] { 0, 4, 8 });
                return true;
            }
            else if (this._buttons[2].Text != string.Empty &&
                     this._buttons[2].Text == this._buttons[4].Text &&
                     this._buttons[4].Text == this._buttons[6].Text)
            {
                // 3 5 7 Winner
                this.DisplayWinner(new int[] { 2, 4, 6 });
                return true;
            }
            if (!this._buttons.Exists(b=>b.Text==string.Empty))
            {
                MessageBox.Show("Oyun bərabərə bitdi!","TicTacToe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private void DisplayWinner(int[] a)
        {
            foreach (int item in a)
            {
                this._buttons[item].BackColor = Color.Green;
            }
            if (this._currentPlayer==Player.Player1)
            {
                this._player1Score++;
            }
            else
            {
                this._player2Score++;
            }
            DisplayScore();
        }

        private void DisplayScore()
        {
            LblPlayer1Score.Text = this._player1Score.ToString();
            LblPlayer2Score.Text = this._player2Score.ToString();
        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            this.ResetGame();
        }

        private void ResetGame()
        {
            foreach (Button item in this._buttons)
            {
                item.BackColor = Color.LightGray;
                item.Text = string.Empty;
            }
            this._currentTurn = Turn.X;
            this._currentPlayer = Player.Player1;

            LblTurn.Text = Turn.X.ToString();
            this._isResume = true;

        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.ResetGame();
            this._player1Score = 0;
            this._player2Score = 0;
            this.DisplayScore();
        }
    }
}
