namespace KWZP2019
{
    partial class EntranceControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceControlForm));
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblControlDate = new System.Windows.Forms.Label();
            this.lblThickness = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblMass = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.picboxControlStatus = new System.Windows.Forms.PictureBox();
            this.domUDSuppId = new System.Windows.Forms.DomainUpDown();
            this.domUDDetailId = new System.Windows.Forms.DomainUpDown();
            this.domUDControlerId = new System.Windows.Forms.DomainUpDown();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox();
            this.domUDColour = new System.Windows.Forms.DomainUpDown();
            this.txtboxControlDate = new System.Windows.Forms.TextBox();
            this.txtboxThickness = new System.Windows.Forms.TextBox();
            this.txtboxWidth = new System.Windows.Forms.TextBox();
            this.txtboxMass = new System.Windows.Forms.TextBox();
            this.txtboxComment = new System.Windows.Forms.TextBox();
            this.checkBoxComposition = new System.Windows.Forms.CheckBox();
            this.checkBoxControlStatus = new System.Windows.Forms.CheckBox();
            this.lblParameterCheck = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxControlStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
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
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(67, 32);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 120);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Wprowadź dane kontroli";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlDate
            // 
            this.lblControlDate.BackColor = System.Drawing.Color.Transparent;
            this.lblControlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblControlDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblControlDate.Location = new System.Drawing.Point(542, 378);
            this.lblControlDate.Name = "lblControlDate";
            this.lblControlDate.Size = new System.Drawing.Size(160, 26);
            this.lblControlDate.TabIndex = 3;
            this.lblControlDate.Text = "Data kontroli";
            this.lblControlDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThickness
            // 
            this.lblThickness.BackColor = System.Drawing.Color.Transparent;
            this.lblThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblThickness.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblThickness.Location = new System.Drawing.Point(835, 233);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(160, 26);
            this.lblThickness.TabIndex = 4;
            this.lblThickness.Text = "Grubość";
            this.lblThickness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWidth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWidth.Location = new System.Drawing.Point(835, 306);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(160, 26);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Szerokość";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMass
            // 
            this.lblMass.BackColor = System.Drawing.Color.Transparent;
            this.lblMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMass.Location = new System.Drawing.Point(835, 378);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(160, 26);
            this.lblMass.TabIndex = 6;
            this.lblMass.Text = "Masa";
            this.lblMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComment
            // 
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComment.Location = new System.Drawing.Point(835, 614);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(160, 26);
            this.lblComment.TabIndex = 9;
            this.lblComment.Text = "Komentarz";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picboxControlStatus
            // 
            this.picboxControlStatus.BackColor = System.Drawing.Color.Transparent;
            this.picboxControlStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxControlStatus.BackgroundImage")));
            this.picboxControlStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxControlStatus.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picboxControlStatus.ErrorImage")));
            this.picboxControlStatus.InitialImage = ((System.Drawing.Image)(resources.GetObject("picboxControlStatus.InitialImage")));
            this.picboxControlStatus.Location = new System.Drawing.Point(545, 509);
            this.picboxControlStatus.Name = "picboxControlStatus";
            this.picboxControlStatus.Size = new System.Drawing.Size(160, 160);
            this.picboxControlStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxControlStatus.TabIndex = 10;
            this.picboxControlStatus.TabStop = false;
            // 
            // domUDSuppId
            // 
            this.domUDSuppId.BackColor = System.Drawing.SystemColors.Window;
            this.domUDSuppId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domUDSuppId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domUDSuppId.Location = new System.Drawing.Point(545, 233);
            this.domUDSuppId.Name = "domUDSuppId";
            this.domUDSuppId.Size = new System.Drawing.Size(160, 26);
            this.domUDSuppId.TabIndex = 12;
            this.domUDSuppId.Text = "Id Dostawcy";
            this.domUDSuppId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // domUDDetailId
            // 
            this.domUDDetailId.BackColor = System.Drawing.SystemColors.Window;
            this.domUDDetailId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domUDDetailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domUDDetailId.Location = new System.Drawing.Point(545, 277);
            this.domUDDetailId.Name = "domUDDetailId";
            this.domUDDetailId.Size = new System.Drawing.Size(160, 26);
            this.domUDDetailId.TabIndex = 13;
            this.domUDDetailId.Text = "Id Detalu";
            this.domUDDetailId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // domUDControlerId
            // 
            this.domUDControlerId.BackColor = System.Drawing.SystemColors.Window;
            this.domUDControlerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domUDControlerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domUDControlerId.Location = new System.Drawing.Point(545, 325);
            this.domUDControlerId.Name = "domUDControlerId";
            this.domUDControlerId.Size = new System.Drawing.Size(160, 26);
            this.domUDControlerId.TabIndex = 14;
            this.domUDControlerId.Text = "Id Kontrolującego";
            this.domUDControlerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxForm
            // 
            this.pictureBoxForm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxForm.BackgroundImage")));
            this.pictureBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxForm.Location = new System.Drawing.Point(438, 12);
            this.pictureBoxForm.Name = "pictureBoxForm";
            this.pictureBoxForm.Size = new System.Drawing.Size(670, 737);
            this.pictureBoxForm.TabIndex = 17;
            this.pictureBoxForm.TabStop = false;
            // 
            // domUDColour
            // 
            this.domUDColour.BackColor = System.Drawing.SystemColors.Window;
            this.domUDColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domUDColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domUDColour.Location = new System.Drawing.Point(835, 458);
            this.domUDColour.Name = "domUDColour";
            this.domUDColour.Size = new System.Drawing.Size(160, 26);
            this.domUDColour.TabIndex = 18;
            this.domUDColour.Text = "Kolor";
            this.domUDColour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxControlDate
            // 
            this.txtboxControlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxControlDate.Location = new System.Drawing.Point(542, 407);
            this.txtboxControlDate.Name = "txtboxControlDate";
            this.txtboxControlDate.Size = new System.Drawing.Size(160, 26);
            this.txtboxControlDate.TabIndex = 21;
            // 
            // txtboxThickness
            // 
            this.txtboxThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxThickness.Location = new System.Drawing.Point(835, 262);
            this.txtboxThickness.Name = "txtboxThickness";
            this.txtboxThickness.Size = new System.Drawing.Size(160, 26);
            this.txtboxThickness.TabIndex = 22;
            // 
            // txtboxWidth
            // 
            this.txtboxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxWidth.Location = new System.Drawing.Point(835, 335);
            this.txtboxWidth.Name = "txtboxWidth";
            this.txtboxWidth.Size = new System.Drawing.Size(160, 26);
            this.txtboxWidth.TabIndex = 23;
            // 
            // txtboxMass
            // 
            this.txtboxMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxMass.Location = new System.Drawing.Point(835, 407);
            this.txtboxMass.Name = "txtboxMass";
            this.txtboxMass.Size = new System.Drawing.Size(160, 26);
            this.txtboxMass.TabIndex = 24;
            // 
            // txtboxComment
            // 
            this.txtboxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxComment.Location = new System.Drawing.Point(835, 643);
            this.txtboxComment.Name = "txtboxComment";
            this.txtboxComment.Size = new System.Drawing.Size(160, 26);
            this.txtboxComment.TabIndex = 25;
            // 
            // checkBoxComposition
            // 
            this.checkBoxComposition.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxComposition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxComposition.Location = new System.Drawing.Point(835, 509);
            this.checkBoxComposition.Name = "checkBoxComposition";
            this.checkBoxComposition.Size = new System.Drawing.Size(200, 26);
            this.checkBoxComposition.TabIndex = 26;
            this.checkBoxComposition.Text = "Zgodność składu";
            this.checkBoxComposition.UseVisualStyleBackColor = false;
            // 
            // checkBoxControlStatus
            // 
            this.checkBoxControlStatus.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxControlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxControlStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxControlStatus.Location = new System.Drawing.Point(835, 568);
            this.checkBoxControlStatus.Name = "checkBoxControlStatus";
            this.checkBoxControlStatus.Size = new System.Drawing.Size(200, 26);
            this.checkBoxControlStatus.TabIndex = 27;
            this.checkBoxControlStatus.Text = "Kontrola pozytywna";
            this.checkBoxControlStatus.UseVisualStyleBackColor = false;
            // 
            // lblParameterCheck
            // 
            this.lblParameterCheck.BackColor = System.Drawing.Color.Transparent;
            this.lblParameterCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParameterCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblParameterCheck.Location = new System.Drawing.Point(521, 480);
            this.lblParameterCheck.Name = "lblParameterCheck";
            this.lblParameterCheck.Size = new System.Drawing.Size(200, 26);
            this.lblParameterCheck.TabIndex = 28;
            this.lblParameterCheck.Text = "Zgodność parametrów";
            this.lblParameterCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClear.TabIndex = 29;
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
            this.btnDone.TabIndex = 30;
            this.btnDone.Text = "Zatwierdź";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // EntranceControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblParameterCheck);
            this.Controls.Add(this.checkBoxControlStatus);
            this.Controls.Add(this.checkBoxComposition);
            this.Controls.Add(this.txtboxComment);
            this.Controls.Add(this.txtboxMass);
            this.Controls.Add(this.txtboxWidth);
            this.Controls.Add(this.txtboxThickness);
            this.Controls.Add(this.txtboxControlDate);
            this.Controls.Add(this.domUDColour);
            this.Controls.Add(this.domUDControlerId);
            this.Controls.Add(this.domUDDetailId);
            this.Controls.Add(this.domUDSuppId);
            this.Controls.Add(this.picboxControlStatus);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblMass);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblThickness);
            this.Controls.Add(this.lblControlDate);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.pictureBoxForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntranceControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola Wejściowa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntranceControlForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picboxControlStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblControlDate;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.PictureBox picboxControlStatus;
        private System.Windows.Forms.DomainUpDown domUDSuppId;
        private System.Windows.Forms.DomainUpDown domUDDetailId;
        private System.Windows.Forms.DomainUpDown domUDControlerId;
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.DomainUpDown domUDColour;
        private System.Windows.Forms.TextBox txtboxControlDate;
        private System.Windows.Forms.TextBox txtboxThickness;
        private System.Windows.Forms.TextBox txtboxWidth;
        private System.Windows.Forms.TextBox txtboxMass;
        private System.Windows.Forms.TextBox txtboxComment;
        private System.Windows.Forms.CheckBox checkBoxComposition;
        private System.Windows.Forms.CheckBox checkBoxControlStatus;
        private System.Windows.Forms.Label lblParameterCheck;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
    }
}