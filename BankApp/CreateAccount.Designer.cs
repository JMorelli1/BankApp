namespace BankApp
{
    partial class CreateAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type of Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Starting Balance";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(217, 255);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(133, 42);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(217, 304);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 43);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "SAV",
            "CHK",
            "MMA"});
            this.cbType.Location = new System.Drawing.Point(217, 135);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(133, 24);
            this.cbType.TabIndex = 8;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(217, 183);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(132, 22);
            this.txtBalance.TabIndex = 4;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateAccount";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtBalance;
    }
}