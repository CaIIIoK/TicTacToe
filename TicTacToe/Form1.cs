using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool isXTurn = true;

        public Form1()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (isXTurn)
            {
                senderButton.Text = "X";
            } 
            else
            {
                senderButton.Text = "O";
            }
            isXTurn = !isXTurn;
            senderButton.Enabled = false;

            CheckWin(senderButton);
        }

        public void CheckWin(Button pressedButton)
        {
            if(button1.Text == button2.Text && button2.Text ==  button3.Text && button3.Enabled == false)
            {
                MessageBox.Show(pressedButton.Text + "-user wins!", "Congratulations!");
                Application.Restart();
            }

            if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Enabled == false)
            {
                MessageBox.Show(pressedButton.Text + "-user wins!", "Congratulations!");
                Application.Restart();
            }

            if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Enabled == false)
            {
                MessageBox.Show(pressedButton.Text + "-user wins!", "Congratulations!");
                Application.Restart();
            }

            if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Enabled == false)
            {
                MessageBox.Show(pressedButton.Text + "-user wins!", "Congratulations!");
                Application.Restart();
            }

            if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Enabled == false)
            {
                MessageBox.Show(pressedButton.Text + "-user wins!", "Congratulations!");
                Application.Restart();
            }

            if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Enabled == false)
            {
                MessageBox.Show(pressedButton.Text + "-user wins!", "Congratulations!");
                Application.Restart();
            }

            if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Enabled == false)
            {
                MessageBox.Show(pressedButton.Text + "-user wins!", "Congratulations!");
                Application.Restart();
            }

            if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Enabled == false)
            {
                MessageBox.Show(pressedButton.Text + "-user wins!", "Congratulations!");
                Application.Restart();
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isXTurn = true;
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isXTurn = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
