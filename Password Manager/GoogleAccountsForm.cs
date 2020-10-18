using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class GoogleAccountsForm : Form
    {
        private SqlConnection connection;
        public GoogleAccountsForm()
        {
            InitializeComponent();
            openConnection();
            fillTable();
            accountsTable.CellClick += accountsTable_CellClick;
        }

        private void openConnection()
        {
            this.connection = 
            new SqlConnection(Password_Manager.Properties.Resources.connectionString);
            try
            {
                this.connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed");
            }
        }

        private void closeConnection()
        {
            this.connection.Close();
        }

        private void accountsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == accountsTable.Columns["Edit"].Index)
            {
                String id = accountsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                String emailQuery = "select email from Google where id=" + id;
                String email;
                using (SqlCommand cmd = new SqlCommand(emailQuery, connection))
                {
                    email = cmd.ExecuteScalar().ToString();
                }
                String passQuery = "select password from Google where id=" + id;
                String pass;
                using (SqlCommand cmd = new SqlCommand(passQuery, connection))
                {
                    pass = cmd.ExecuteScalar().ToString();
                }
                String commentQuery = "select comments from Google where id=" + id;
                String comment;
                using (SqlCommand cmd = new SqlCommand(commentQuery, connection))
                {
                    comment = cmd.ExecuteScalar().ToString();
                }

                var editForm = new EditGoogleAccount(id, email, pass, comment, connection);
                editForm.FormClosed += editForm_FormClosed;
                editForm.Show();
            }
            //delete account
            if (e.ColumnIndex == accountsTable.Columns["Delete"].Index)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that " +
                    "you want to delete this account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    String id = accountsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                    String query = "delete from Google where id=" + id;
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    fillTable();
                }
            }
        }

        private void editForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fillTable();
        }

        private void fillTable()
        {
            using (SqlCommand cmd = new SqlCommand("select * from Google order by id", connection))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                this.accountsTable.DataSource = ds.Tables[0];
                

                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Name = "Edit";
                editButtonColumn.Text = "EDIT";
                int columnIndex = 4;
                if (accountsTable.Columns["Edit"] == null)
                {
                    accountsTable.Columns.Insert(columnIndex, editButtonColumn);
                }
                editButtonColumn.UseColumnTextForButtonValue = true;
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.Text = "DELETE";
                columnIndex = 5;
                if (accountsTable.Columns["Delete"] == null)
                {
                    accountsTable.Columns.Insert(columnIndex, deleteButtonColumn);
                }
                deleteButtonColumn.UseColumnTextForButtonValue = true;

                int cols = accountsTable.ColumnCount;
                for (int i = 0; i < cols; i++)
                    accountsTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddNewGoogleAccount(connection);
            newForm.FormClosed += newForm_FormClosed;
            newForm.Show();
        }

        private void newForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fillTable();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new MainScreen();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }
    }
}
