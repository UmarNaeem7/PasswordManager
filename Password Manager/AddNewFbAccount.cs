using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class AddNewFbAccount : Form
    {
        private SqlConnection conn;
        public AddNewFbAccount(SqlConnection connection)
        {
            InitializeComponent();
            this.conn = connection;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.emailTextBox.Text.Equals(""))
            {
                MessageBox.Show("Email is required and cannot be left empty. Failed to add new account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmdText = @"insert into facebook values (@email, @phone, @password, @comments)";
            using (SqlCommand cmd = new SqlCommand(cmdText, this.conn))
            {
                //add parameters to query
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters.Add("@comments", SqlDbType.VarChar);

                //add values to parameters
                cmd.Parameters["@email"].Value = this.emailTextBox.Text;
                cmd.Parameters["@phone"].Value = this.phoneTextBox.Text;
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
    }
}
