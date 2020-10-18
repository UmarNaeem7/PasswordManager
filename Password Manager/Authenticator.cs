using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Authenticator : Form
    {
        public Authenticator()
        {
            InitializeComponent();
            pinTextBox.KeyPress += new KeyPressEventHandler(keyPressed);

        }

        //disallow non-numeric and other unrelated keyboard keys in pin code textbox using regex
        private void keyPressed(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                enterButton_Click(o, e);
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^\b]"))
                e.Handled = true;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (pinTextBox.Text.Equals(Password_Manager.Properties.Resources.pinCode))
            {
                this.Hide();
                var main = new MainScreen();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Incorrect PIN entered! Try again.", 
                    "Wrong PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pinTextBox.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
