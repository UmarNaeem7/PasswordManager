using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class EditMiscForm : Form
    {
        private SqlConnection conn;
        private String accountID;


        public EditMiscForm(string id, string email, string pass, string comment, string info, SqlConnection connection)
        {
            InitializeComponent();
            this.emailTextBox.Text = email;
            this.passwordTextBox.Text = pass;
            this.commentsTextBox.Text = comment;
            this.infoTextBox.Text = info;
            this.conn = connection;
            this.accountID = id;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that" +
                    " you want to save these changes?", "Save Account Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string cmdText = @"update miscellaneous set information=@info, email=@email, password=@password, comments=@comments where id=@id";
                using (SqlCommand cmd = new SqlCommand(cmdText, this.conn))
                {
                    //add parameters to query
                    cmd.Parameters.Add("@email", SqlDbType.VarChar);
                    cmd.Parameters.Add("@info", SqlDbType.VarChar);
                    cmd.Parameters.Add("@password", SqlDbType.VarChar);
                    cmd.Parameters.Add("@comments", SqlDbType.VarChar);
                    cmd.Parameters.Add("@id", SqlDbType.Int);

                    //add values to parameters
                    cmd.Parameters["@email"].Value = this.emailTextBox.Text;
                    cmd.Parameters["@info"].Value = this.infoTextBox.Text;
                    cmd.Parameters["@password"].Value = this.passwordTextBox.Text;
                    cmd.Parameters["@comments"].Value = this.commentsTextBox.Text;
                    cmd.Parameters["@id"].Value = this.accountID;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occured while saving changes. Please adhere to editing rules.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
