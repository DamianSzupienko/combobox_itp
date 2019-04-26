namespace KWZP2019
{
    partial class Finances
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCountPayments = new System.Windows.Forms.Button();
            this.btnCosts = new System.Windows.Forms.Button();
            this.btnEarnings = new System.Windows.Forms.Button();
            this.btnFinancialStatement = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.lblOtherFunctions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(49, 77);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(140, 50);
            this.btnPayments.TabIndex = 0;
            this.btnPayments.Text = "Wypłaty";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnCountpayments
            // 
            this.btnCountPayments.Location = new System.Drawing.Point(195, 77);
            this.btnCountPayments.Name = "btnCountpayments";
            this.btnCountPayments.Size = new System.Drawing.Size(140, 50);
            this.btnCountPayments.TabIndex = 1;
            this.btnCountPayments.Text = "Podlicz wypłaty";
            this.btnCountPayments.UseVisualStyleBackColor = true;
            this.btnCountPayments.Click += new System.EventHandler(this.btnCountPayments_Click);
            // 
            // btnCosts
            // 
            this.btnCosts.Location = new System.Drawing.Point(342, 77);
            this.btnCosts.Name = "btnCosts";
            this.btnCosts.Size = new System.Drawing.Size(140, 50);
            this.btnCosts.TabIndex = 2;
            this.btnCosts.Text = "Koszty";
            this.btnCosts.UseVisualStyleBackColor = true;
            this.btnCosts.Click += new System.EventHandler(this.btnCosts_Click);
            // 
            // btnEarnings
            // 
            this.btnEarnings.Location = new System.Drawing.Point(49, 218);
            this.btnEarnings.Name = "btnEarnings";
            this.btnEarnings.Size = new System.Drawing.Size(140, 50);
            this.btnEarnings.TabIndex = 3;
            this.btnEarnings.Text = "Zyski";
            this.btnEarnings.UseVisualStyleBackColor = true;
            this.btnEarnings.Click += new System.EventHandler(this.btnEarnings_Click);
            // 
            // btnFinancialstatement
            // 
            this.btnFinancialStatement.Location = new System.Drawing.Point(195, 218);
            this.btnFinancialStatement.Name = "btnFinancialstatement";
            this.btnFinancialStatement.Size = new System.Drawing.Size(140, 50);
            this.btnFinancialStatement.TabIndex = 4;
            this.btnFinancialStatement.Text = "Bilans finansowy";
            this.btnFinancialStatement.UseVisualStyleBackColor = true;
            this.btnFinancialStatement.Click += new System.EventHandler(this.btnFinancialStatement_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(342, 218);
            this.btnAddInvoice.Name = "btnAddinvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(140, 50);
            this.btnAddInvoice.TabIndex = 5;
            this.btnAddInvoice.Text = "Dodaj fakturę";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(218, 32);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(99, 13);
            this.lblIntroduction.TabIndex = 6;
            this.lblIntroduction.Text = "WPROWADZANIE";
            // 
            // lblOtherFunctions
            // 
            this.lblOtherFunctions.AutoSize = true;
            this.lblOtherFunctions.Location = new System.Drawing.Point(203, 186);
            this.lblOtherFunctions.Name = "lblOtherfunctions";
            this.lblOtherFunctions.Size = new System.Drawing.Size(123, 13);
            this.lblOtherFunctions.TabIndex = 7;
            this.lblOtherFunctions.Text = "POZOSTAŁE FUNKCJE";
            // 
            // finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 331);
            this.Controls.Add(this.lblOtherFunctions);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.btnFinancialStatement);
            this.Controls.Add(this.btnEarnings);
            this.Controls.Add(this.btnCosts);
            this.Controls.Add(this.btnCountPayments);
            this.Controls.Add(this.btnPayments);
            this.Name = "finances";
            this.Text = "Finanse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCountPayments;
        private System.Windows.Forms.Button btnCosts;
        private System.Windows.Forms.Button btnEarnings;
        private System.Windows.Forms.Button btnFinancialStatement;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.Label lblOtherFunctions;
    }
}

