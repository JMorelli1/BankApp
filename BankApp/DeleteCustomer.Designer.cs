namespace BankApp
{
    partial class DeleteCustomer
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
            this.dgAllCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerIDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbConfirmation = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllCustomers
            // 
            this.dgAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerIDs,
            this.SelectedCustomer});
            this.dgAllCustomers.Location = new System.Drawing.Point(64, 63);
            this.dgAllCustomers.Name = "dgAllCustomers";
            this.dgAllCustomers.RowHeadersWidth = 51;
            this.dgAllCustomers.RowTemplate.Height = 24;
            this.dgAllCustomers.Size = new System.Drawing.Size(402, 248);
            this.dgAllCustomers.TabIndex = 0;
            // 
            // CustomerIDs
            // 
            this.CustomerIDs.HeaderText = "Customer IDs";
            this.CustomerIDs.MinimumWidth = 6;
            this.CustomerIDs.Name = "CustomerIDs";
            this.CustomerIDs.Width = 125;
            // 
            // SelectedCustomer
            // 
            this.SelectedCustomer.HeaderText = "Select Customer";
            this.SelectedCustomer.MinimumWidth = 6;
            this.SelectedCustomer.Name = "SelectedCustomer";
            this.SelectedCustomer.Width = 125;
            // 
            // lbConfirmation
            // 
            this.lbConfirmation.AutoSize = true;
            this.lbConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmation.Location = new System.Drawing.Point(59, 383);
            this.lbConfirmation.Name = "lbConfirmation";
            this.lbConfirmation.Size = new System.Drawing.Size(0, 20);
            this.lbConfirmation.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(63, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 51);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(223, 317);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 51);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbConfirmation);
            this.Controls.Add(this.dgAllCustomers);
            this.Name = "DeleteCustomer";
            this.Text = "DeleteCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAllCustomers;
        private System.Windows.Forms.Label lbConfirmation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIDs;
        private System.Windows.Forms.DataGridViewButtonColumn SelectedCustomer;
    }
}