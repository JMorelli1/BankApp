namespace BankApp
{
    partial class CustomerLandingPage
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
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            this.AcctNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAccounts
            // 
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AcctNum,
            this.Type,
            this.Balance,
            this.Deposit});
            this.dgAccounts.Location = new System.Drawing.Point(49, 55);
            this.dgAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.RowHeadersWidth = 51;
            this.dgAccounts.Size = new System.Drawing.Size(729, 454);
            this.dgAccounts.TabIndex = 0;
            // 
            // AcctNum
            // 
            this.AcctNum.HeaderText = "Account Number";
            this.AcctNum.MinimumWidth = 6;
            this.AcctNum.Name = "AcctNum";
            this.AcctNum.ReadOnly = true;
            this.AcctNum.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.MinimumWidth = 6;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 125;
            // 
            // Deposit
            // 
            this.Deposit.HeaderText = "";
            this.Deposit.MinimumWidth = 6;
            this.Deposit.Name = "Deposit";
            this.Deposit.Width = 125;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(809, 56);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(120, 29);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "Welcome";
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(814, 108);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(205, 60);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Create New Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(814, 176);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(205, 61);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // CustomerLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.dgAccounts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerLandingPage";
            this.Text = "CustomerLandingPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAccounts;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcctNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewButtonColumn Deposit;
        private System.Windows.Forms.Button btnLogout;
    }
}