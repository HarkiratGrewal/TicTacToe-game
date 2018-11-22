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
    public partial class TicTacToe : Form
    {

        #region InitializingVariables
        /// <summary>
        /// Initializing variables, so that they work with whole code throughot.
        /// </summary>
        //InitializingValriables
        bool turn = true; //True for X and false for O
        int turnCount = 0;
        bool winner = false;
        #endregion

        #region FormApp
        public TicTacToe()
        {
            InitializeComponent();
            //Background Color
            BackColor = Color.Black;
        }//TicTacToe Initalizing component
        #endregion

        #region DisableButton
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }//try block
            catch { }//catch block
            winner = true;
        }//DisableButton method
        #endregion

        #region CheckForWinners
        private void checkForWinner()
        {
            #region HorizontalRows
            if (btnA1.Text == btnA2.Text && btnA1.Text == btnA3.Text && btnA1.Enabled == false)
            {
                MessageBox.Show(btnA1.Text + " won the game!");
                disableButtons();
            }//A

            else if (btnB1.Text == btnB2.Text && btnB1.Text == btnB3.Text && btnB1.Enabled == false)
            {
                MessageBox.Show(btnB1.Text + " won the game!");
                disableButtons();
            }//B

            else if (btnC1.Text == btnC2.Text && btnC1.Text == btnC3.Text && btnC1.Enabled == false)
            {
                MessageBox.Show(btnC1.Text + " won the game!");
                disableButtons();
            }//C
            #endregion

            #region VerticalColumns
            else if (btnA1.Text == btnB1.Text && btnA1.Text == btnC1.Text && btnA1.Enabled == false)
            {
                MessageBox.Show(btnA1.Text + " won the game!");
                disableButtons();
            }//1

            else if (btnA2.Text == btnB2.Text && btnA2.Text == btnC2.Text && btnA2.Enabled == false)
            {
                MessageBox.Show(btnA2.Text + " won the game!");
                disableButtons();
            }//2

            else if (btnA3.Text == btnB3.Text && btnA3.Text == btnC3.Text && btnA3.Enabled == false)
            {
                MessageBox.Show(btnA3.Text + " won the game!");
                disableButtons();
            }//3
            #endregion

            #region Diagonal
            else if (btnA1.Text == btnB2.Text && btnA1.Text == btnC3.Text && btnA1.Enabled == false)
            {
                MessageBox.Show(btnA1.Text + " won the game!");
                disableButtons();
            }//LeftUpToRightBottom

            else if (btnA3.Text == btnB2.Text && btnA3.Text == btnC1.Text && btnA3.Enabled == false)
            {
                MessageBox.Show(btnA3.Text + " won the game!");
                disableButtons();
            }//RightUpToLeftBottom
            turnCount++;
            #endregion

            #region Draw
            if (turnCount == 9 && !winner)
            {
                MessageBox.Show("Draw");
            }//Draw
            #endregion

        }//CheckForWinners method
        #endregion

        #region ButtonClick
        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.Gold;

            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !(turn);
            b.Enabled = false;
            checkForWinner();
        }//ButtonClick
        #endregion

        #region ResetButton
        private void resetButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.Black;
                }//ForEach
            }//try block
            catch { }//catch block
            turn = true;
            turnCount = 1;
        }//ResetButton
        #endregion

        #region FormsStrip

        #region NewGame
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetButtons();
        }//NewGame
        #endregion

        #region Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Exit
        #endregion

        #region AboutMe
        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, I am Harkirat", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }//AboutMe
        #endregion

        #endregion

    }//TicTacToe : Forms class
}//TicTacToe namespace
