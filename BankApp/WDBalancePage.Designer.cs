namespace BankApp
{
    partial class WDBalancePage
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtAcccount = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(162, 337);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(176, 57);
            this.btnWithdraw.TabIndex = 0;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(346, 337);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(177, 57);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // txtAcccount
            // 
            this.txtAcccount.AutoSize = true;
            this.txtAcccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcccount.Location = new System.Drawing.Point(257, 124);
            this.txtAcccount.Name = "txtAcccount";
            this.txtAcccount.Size = new System.Drawing.Size(81, 29);
            this.txtAcccount.TabIndex = 2;
            this.txtAcccount.Text = "label1";
            // 
            // txtBalance
            // 
            this.txtBalance.AutoSize = true;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(257, 177);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(81, 29);
            this.txtBalance.TabIndex = 3;
            this.txtBalance.Text = "label1";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(262, 250);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(161, 22);
            this.tbAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter the amount you would like to to withdraw or deposit";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(162, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 57);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // WDBalancePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtAcccount);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WDBalancePage";
            this.Text = "WDBalancePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label txtAcccount;
        private System.Windows.Forms.Label txtBalance;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}