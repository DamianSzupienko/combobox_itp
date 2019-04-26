namespace KWZP2019
{
    partial class OutControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutControlForm));
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.checkBoxControlStatus = new System.Windows.Forms.CheckBox();
            this.txtboxComment = new System.Windows.Forms.TextBox();
            this.txtboxControlDate = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblControlDate = new System.Windows.Forms.Label();
            this.domUDControlerId = new System.Windows.Forms.DomainUpDown();
            this.domUDProcessId = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.BackgroundImage")));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Location = new System.Drawing.Point(67, 186);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(200, 120);
            this.btnReturnMain.TabIndex = 0;
            this.btnReturnMain.Text = "Menu Główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Location = new System.Drawing.Point(67, 32);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 120);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(67, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 120);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Wyczyść dane";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDone.FlatAppearance.BorderSize = 3;
            this.btnDone.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDone.Image = ((System.Drawing.Image)(resources.GetObject("btnDone.Image")));
            this.btnDone.Location = new System.Drawing.Point(67, 614);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(200, 120);
            this.btnDone.TabIndex = 31;
            this.btnDone.Text = "Zatwierdź";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // pictureBoxForm
            // 
            this.pictureBoxForm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxForm.BackgroundImage")));
            this.pictureBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxForm.Location = new System.Drawing.Point(438, 12);
            this.pictureBoxForm.Name = "pictureBoxForm";
            this.pictureBoxForm.Size = new System.Drawing.Size(670, 737);
            this.pictureBoxForm.TabIndex = 32;
            this.pictureBoxForm.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Location = new System.Drawing.Point(576, 126);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(387, 56);
            this.lblFormTitle.TabIndex = 33;
            this.lblFormTitle.Text = "Wprowadź dane kontroli";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxControlStatus
            // 
            this.checkBoxControlStatus.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxControlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxControlStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxControlStatus.Location = new System.Drawing.Point(835, 643);
            this.checkBoxControlStatus.Name = "checkBoxControlStatus";
            this.checkBoxControlStatus.Size = new System.Drawing.Size(200, 26);
            this.checkBoxControlStatus.TabIndex = 48;
            this.checkBoxControlStatus.Text = "Kontrola pozytywna";
            this.checkBoxControlStatus.UseVisualStyleBackColor = false;
            // 
            // txtboxComment
            // 
            this.txtboxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxComment.Location = new System.Drawing.Point(549, 643);
            this.txtboxComment.Name = "txtboxComment";
            this.txtboxComment.Size = new System.Drawing.Size(160, 26);
            this.txtboxComment.TabIndex = 46;
            // 
            // txtboxControlDate
            // 
            this.txtboxControlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxControlDate.Location = new System.Drawing.Point(545, 354);
            this.txtboxControlDate.Name = "txtboxControlDate";
            this.txtboxControlDate.Size = new System.Drawing.Size(160, 26);
            this.txtboxControlDate.TabIndex = 43;
            // 
            // lblComment
            // 
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComment.Location = new System.Drawing.Point(549, 614);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(160, 26);
            this.lblComment.TabIndex = 38;
            this.lblComment.Text = "Komentarz";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlDate
            // 
            this.lblControlDate.BackColor = System.Drawing.Color.Transparent;
            this.lblControlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblControlDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblControlDate.Location = new System.Drawing.Point(545, 325);
            this.lblControlDate.Name = "lblControlDate";
            this.lblControlDate.Size = new System.Drawing.Size(160, 26);
            this.lblControlDate.TabIndex = 34;
            this.lblControlDate.Text = "Data kontroli";
            this.lblControlDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // domUDControlerId
            // 
            this.domUDControlerId.BackColor = System.Drawing.SystemColors.Window;
            this.domUDControlerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domUDControlerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domUDControlerId.Location = new System.Drawing.Point(545, 277);
            this.domUDControlerId.Name = "domUDControlerId";
            this.domUDControlerId.Size = new System.Drawing.Size(160, 26);
            this.domUDControlerId.TabIndex = 52;
            this.domUDControlerId.Text = "Id Kontrolującego";
            this.domUDControlerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // domUDProcessId
            // 
            this.domUDProcessId.BackColor = System.Drawing.SystemColors.Window;
            this.domUDProcessId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domUDProcessId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domUDProcessId.Location = new System.Drawing.Point(545, 233);
            this.domUDProcessId.Name = "domUDProcessId";
            this.domUDProcessId.Size = new System.Drawing.Size(160, 26);
            this.domUDProcessId.TabIndex = 50;
            this.domUDProcessId.Text = "Id Procesu";
            this.domUDProcessId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.domUDControlerId);
            this.Controls.Add(this.domUDProcessId);
            this.Controls.Add(this.checkBoxControlStatus);
            this.Controls.Add(this.txtboxComment);
            this.Controls.Add(this.txtboxControlDate);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblControlDate);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.pictureBoxForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola Wyjściowa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OutControlForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.CheckBox checkBoxControlStatus;
        private System.Windows.Forms.TextBox txtboxComment;
        private System.Windows.Forms.TextBox txtboxControlDate;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblControlDate;
        private System.Windows.Forms.DomainUpDown domUDControlerId;
        private System.Windows.Forms.DomainUpDown domUDProcessId;
    }
}