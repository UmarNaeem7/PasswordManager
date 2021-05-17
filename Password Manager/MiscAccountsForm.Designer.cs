namespace Password_Manager
{
    partial class MiscAccountsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiscAccountsForm));
            this.backButton = new System.Windows.Forms.Button();
            this.newAccountLabel = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.accountsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = global::Password_Manager.Properties.Resources.back;
            this.backButton.Location = new System.Drawing.Point(32, 36);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 33);
            this.backButton.TabIndex = 9;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newAccountLabel
            // 
            this.newAccountLabel.AutoSize = true;
            this.newAccountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountLabel.Location = new System.Drawing.Point(273, 478);
            this.newAccountLabel.Name = "newAccountLabel";
            this.newAccountLabel.Size = new System.Drawing.Size(157, 19);
            this.newAccountLabel.TabIndex = 8;
            this.newAccountLabel.Text = "Add a new account ...";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newAccountButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountButton.Location = new System.Drawing.Point(243, 474);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(26, 27);
            this.newAccountButton.TabIndex = 7;
            this.newAccountButton.Text = "+";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(205, 45);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(328, 24);
            this.headingLabel.TabIndex = 6;
            this.headingLabel.Text = "Available Miscellaneous Accounts";
            // 
            // accountsTable
            // 
            this.accountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsTable.Location = new System.Drawing.Point(32, 95);
            this.accountsTable.Name = "accountsTable";
            this.accountsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.accountsTable.Size = new System.Drawing.Size(643, 336);
            this.accountsTable.TabIndex = 5;
            // 
            // MiscAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 536);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.newAccountLabel);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.accountsTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiscAccountsForm";
            this.Text = "MiscAccountsForm";
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label newAccountLabel;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.DataGridView accountsTable;
    }
}