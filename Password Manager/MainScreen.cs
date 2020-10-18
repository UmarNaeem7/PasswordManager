using System;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.FormClosing += MainScreen_FormClosing;
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            DialogResult dialogResult = MessageBox.Show("Are you sure that" +
                    " you want to quit application?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                e.Cancel = true;
        }

        private void googleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm();
            google.Closed += (s, args) => this.Close();
            google.Show();
        }
    }
}
