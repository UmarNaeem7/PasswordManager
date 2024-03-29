﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class AddNewGoogleAccount : Form
    {
        private SqlConnection conn;
        private String website;
        public AddNewGoogleAccount(SqlConnection connection, String web)
        {
            InitializeComponent();
            this.conn = connection;
            this.website = web;
            this.headingLabel.Text = String.Format("Add new {0} account", web);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.emailTextBox.Text.Equals(""))
            {
                MessageBox.Show("Email is required and cannot be left empty. Failed to add new account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmdText = String.Format(@"insert into {0} values (@email, @password, @comments)", this.website);
            using (SqlCommand cmd = new SqlCommand(cmdText, this.conn))
            {
                //add parameters to query
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters.Add("@comments", SqlDbType.VarChar);

                //add values to parameters
                cmd.Parameters["@email"].Value = this.emailTextBox.Text;
                cmd.Parameters["@password"].Value = this.passwordTextBox.Text;
                cmd.Parameters["@comments"].Value = this.commentsTextBox.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Account already exists, failed to add new account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
