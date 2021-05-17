using System;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void googleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm("Google");
            google.Closed += (s, args) => this.Close();
            google.Show();
        }

        private void gitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm("Github");
            google.Closed += (s, args) => this.Close();
            google.Show();
        }

        private void icloudButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm("iCloud");
            google.Closed += (s, args) => this.Close();
            google.Show();
        }

        private void outlookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm("Outlook");
            google.Closed += (s, args) => this.Close();
            google.Show();
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm("Line");
            google.Closed += (s, args) => this.Close();
            google.Show();
        }

        private void samsungButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm("Samsung");
            google.Closed += (s, args) => this.Close();
            google.Show();
        }

        private void netflixButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm("Netflix");
            google.Closed += (s, args) => this.Close();
            google.Show();
        }

        private void twitterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm("Twitter");
            google.Closed += (s, args) => this.Close();
            google.Show();
        }

        private void fbButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fb = new FacebookAccountsForm();
            fb.Closed += (s, args) => this.Close();
            fb.Show();
        }

        private void instaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm("Instagram");
            google.Closed += (s, args) => this.Close();
            google.Show();
        }

        private void miscButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var misc = new MiscAccountsForm();
            misc.Closed += (s, args) => this.Close();
            misc.Show();
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var google = new GoogleAccountsForm("Discord");
            google.Closed += (s, args) => this.Close();
            google.Show();
        }
    }
}
