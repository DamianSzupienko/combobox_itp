namespace KWZP2019
{
    partial class FinancesAndHR
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
            this.btnFinances = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinances
            // 
            this.btnFinances.Location = new System.Drawing.Point(125, 43);
            this.btnFinances.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinances.Name = "btnFinances";
            this.btnFinances.Size = new System.Drawing.Size(321, 92);
            this.btnFinances.TabIndex = 0;
            this.btnFinances.Text = "Finanse";
            this.btnFinances.UseVisualStyleBackColor = true;
            this.btnFinances.Click += new System.EventHandler(this.btnFinances_Click);
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(125, 167);
            this.btnHR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(321, 92);
            this.btnHR.TabIndex = 1;
            this.btnHR.Text = "Kadry";
            this.btnHR.UseVisualStyleBackColor = true;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // FinancesAndHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnFinances);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FinancesAndHR";
            this.Text = "Finanse i Kadry";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnFinances;
        private System.Windows.Forms.Button btnHR;
    }
}