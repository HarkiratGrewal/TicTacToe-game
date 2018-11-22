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
    public partial class Form1 : Form
    {
        bool turn = true; //True for X and false for O
        int turnCount = 0;
        bool winner = false;

        public Form1()
        {
            InitializeComponent();
        }

        #region AboutMe
        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Written by Reza", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region ButtonClick
        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
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
        }
        #endregion

        #region CheckingForWinners
        private void checkForWinner()
        {
            if (btnA1.Text == btnA2.Text && btnA1.Text == btnA3.Text && btnA1.Enabled == false)
            {
                MessageBox.Show(btnA1.Text + " won the game!");
                disableButtons();
            }

            if (btnB1.Text == btnB2.Text && btnB1.Text == btnB3.Text && btnB1.Enabled == false)
            {
                MessageBox.Show(btnB1.Text + " won the game!");
                disableButtons();
            }

            if (btnC1.Text == btnC2.Text && btnC1.Text == btnC3.Text && btnC1.Enabled == false)
            {
                MessageBox.Show(btnC1.Text + " won the game!");
                disableButtons();
            }

            if (btnA1.Text == btnB1.Text && btnA1.Text == btnC1.Text && btnA1.Enabled == false)
            {
                MessageBox.Show(btnA1.Text + " won the game!");
                disableButtons();
            }

            if (btnA2.Text == btnB2.Text && btnA2.Text == btnC2.Text && btnA2.Enabled == false)
            {
                MessageBox.Show(btnA2.Text + " won the game!");
                disableButtons();
            }

            if (btnA3.Text == btnB3.Text && btnA3.Text == btnC3.Text && btnA3.Enabled == false)
            {
                MessageBox.Show(btnA3.Text + " won the game!");
                disableButtons();
            }

            if (btnA1.Text == btnB2.Text && btnA1.Text == btnC3.Text && btnA1.Enabled == false)
            {
                MessageBox.Show(btnA1.Text + " won the game!");
                disableButtons();
            }

            if (btnA3.Text == btnB2.Text && btnA3.Text == btnC1.Text && btnA3.Enabled == false)
            {
                MessageBox.Show(btnA3.Text + " won the game!");
                disableButtons();
            }
            turnCount++;
            if (turnCount == 9 && !winner)
            {
                MessageBox.Show("Draw");
            }
        }
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
            }
            catch { }
            winner = true;
        }
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
                }
            }
            catch { }
            turn = true;
            turnCount = 0;
        }
        #endregion

        #region NewGame
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetButtons();
        }
        #endregion
    }
}
