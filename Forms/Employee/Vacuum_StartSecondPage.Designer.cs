namespace TheDuckCinema.Forms.Employee
{
    partial class Vacuum_StartSecondPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacuum_StartSecondPage));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.button_Help = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.panel_Center = new System.Windows.Forms.Panel();
            this.comboBox_CleaningMode = new System.Windows.Forms.ComboBox();
            this.label_CleaningMode = new System.Windows.Forms.Label();
            this.comboBox_Vacuum = new System.Windows.Forms.ComboBox();
            this.label_Vacuum = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.button_Form_Finish = new System.Windows.Forms.Button();
            this.label_FormTitle = new System.Windows.Forms.Label();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.panel_Center.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.pictureBox_Back);
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Location = new System.Drawing.Point(0, 315);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(1211, 101);
            this.panel_Bottom.TabIndex = 11;
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Back.Image = global::TheDuckCinema.Properties.Resources.Back_WhiteMode;
            this.pictureBox_Back.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(90, 75);
            this.pictureBox_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Back.TabIndex = 15;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Click += new System.EventHandler(this.pictureBox_Back_Click);
            // 
            // button_Help
            // 
            this.button_Help.BackColor = System.Drawing.Color.Transparent;
            this.button_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Help.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help.ForeColor = System.Drawing.Color.White;
            this.button_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Help.ImageKey = "info.png";
            this.button_Help.ImageList = this.imageList_Buttons;
            this.button_Help.Location = new System.Drawing.Point(229, 23);
            this.button_Help.Name = "button_Help";
            this.button_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Help.Size = new System.Drawing.Size(110, 31);
            this.button_Help.TabIndex = 10;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // imageList_Buttons
            // 
            this.imageList_Buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Buttons.ImageStream")));
            this.imageList_Buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Buttons.Images.SetKeyName(0, "info.png");
            // 
            // panel_Center
            // 
            this.panel_Center.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panel_Center.Controls.Add(this.comboBox_CleaningMode);
            this.panel_Center.Controls.Add(this.label_CleaningMode);
            this.panel_Center.Controls.Add(this.comboBox_Vacuum);
            this.panel_Center.Controls.Add(this.label_Vacuum);
            this.panel_Center.Controls.Add(this.label_Time);
            this.panel_Center.Controls.Add(this.textBox_Time);
            this.panel_Center.Controls.Add(this.button_Form_Finish);
            this.panel_Center.Controls.Add(this.label_FormTitle);
            this.panel_Center.Location = new System.Drawing.Point(31, 19);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(402, 262);
            this.panel_Center.TabIndex = 49;
            // 
            // comboBox_CleaningMode
            // 
            this.comboBox_CleaningMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_CleaningMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.comboBox_CleaningMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_CleaningMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CleaningMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_CleaningMode.ForeColor = System.Drawing.Color.White;
            this.comboBox_CleaningMode.FormattingEnabled = true;
            this.comboBox_CleaningMode.Items.AddRange(new object[] {
            "Fast Cleaning",
            "Deep Cleaning"});
            this.comboBox_CleaningMode.Location = new System.Drawing.Point(162, 120);
            this.comboBox_CleaningMode.MaxDropDownItems = 2;
            this.comboBox_CleaningMode.Name = "comboBox_CleaningMode";
            this.comboBox_CleaningMode.Size = new System.Drawing.Size(183, 27);
            this.comboBox_CleaningMode.TabIndex = 54;
            this.comboBox_CleaningMode.TabStop = false;
            // 
            // label_CleaningMode
            // 
            this.label_CleaningMode.BackColor = System.Drawing.Color.Transparent;
            this.label_CleaningMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CleaningMode.ForeColor = System.Drawing.Color.White;
            this.label_CleaningMode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_CleaningMode.Location = new System.Drawing.Point(-19, 119);
            this.label_CleaningMode.Name = "label_CleaningMode";
            this.label_CleaningMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_CleaningMode.Size = new System.Drawing.Size(175, 19);
            this.label_CleaningMode.TabIndex = 55;
            this.label_CleaningMode.Text = "Cleaning Mode:";
            this.label_CleaningMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_Vacuum
            // 
            this.comboBox_Vacuum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Vacuum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.comboBox_Vacuum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Vacuum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Vacuum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Vacuum.ForeColor = System.Drawing.Color.White;
            this.comboBox_Vacuum.FormattingEnabled = true;
            this.comboBox_Vacuum.Items.AddRange(new object[] {
            "Vacuum No. 1",
            "Vacuum No. 2",
            "Vacuum No. 3",
            "Vacuum No. 4",
            "Vacuum No. 5"});
            this.comboBox_Vacuum.Location = new System.Drawing.Point(162, 82);
            this.comboBox_Vacuum.MaxDropDownItems = 2;
            this.comboBox_Vacuum.Name = "comboBox_Vacuum";
            this.comboBox_Vacuum.Size = new System.Drawing.Size(183, 27);
            this.comboBox_Vacuum.TabIndex = 50;
            this.comboBox_Vacuum.TabStop = false;
            // 
            // label_Vacuum
            // 
            this.label_Vacuum.BackColor = System.Drawing.Color.Transparent;
            this.label_Vacuum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Vacuum.ForeColor = System.Drawing.Color.White;
            this.label_Vacuum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Vacuum.Location = new System.Drawing.Point(23, 85);
            this.label_Vacuum.Name = "label_Vacuum";
            this.label_Vacuum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Vacuum.Size = new System.Drawing.Size(133, 19);
            this.label_Vacuum.TabIndex = 53;
            this.label_Vacuum.Text = "Vacuum:";
            this.label_Vacuum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Time
            // 
            this.label_Time.BackColor = System.Drawing.Color.Transparent;
            this.label_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Time.ForeColor = System.Drawing.Color.White;
            this.label_Time.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Time.Location = new System.Drawing.Point(27, 51);
            this.label_Time.Name = "label_Time";
            this.label_Time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Time.Size = new System.Drawing.Size(129, 19);
            this.label_Time.TabIndex = 52;
            this.label_Time.Text = "Time:";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Time
            // 
            this.textBox_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Time.ForeColor = System.Drawing.Color.White;
            this.textBox_Time.Location = new System.Drawing.Point(162, 43);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.Size = new System.Drawing.Size(183, 27);
            this.textBox_Time.TabIndex = 48;
            // 
            // button_Form_Finish
            // 
            this.button_Form_Finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.button_Form_Finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Form_Finish.FlatAppearance.BorderSize = 0;
            this.button_Form_Finish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_Form_Finish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_Form_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Form_Finish.Font = new System.Drawing.Font("Calibri", 14F);
            this.button_Form_Finish.ForeColor = System.Drawing.Color.White;
            this.button_Form_Finish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Form_Finish.Location = new System.Drawing.Point(162, 179);
            this.button_Form_Finish.Name = "button_Form_Finish";
            this.button_Form_Finish.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Form_Finish.Size = new System.Drawing.Size(183, 36);
            this.button_Form_Finish.TabIndex = 46;
            this.button_Form_Finish.Text = "FINISH";
            this.button_Form_Finish.UseVisualStyleBackColor = false;
            this.button_Form_Finish.Click += new System.EventHandler(this.button_Form_Complete_Click);
            // 
            // label_FormTitle
            // 
            this.label_FormTitle.AutoSize = true;
            this.label_FormTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_FormTitle.ForeColor = System.Drawing.Color.White;
            this.label_FormTitle.Location = new System.Drawing.Point(128, 20);
            this.label_FormTitle.Name = "label_FormTitle";
            this.label_FormTitle.Size = new System.Drawing.Size(150, 19);
            this.label_FormTitle.TabIndex = 0;
            this.label_FormTitle.Text = "Make your selections:";
            // 
            // Vacuum_StartSecondPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 392);
            this.Controls.Add(this.panel_Center);
            this.Controls.Add(this.panel_Bottom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Vacuum_StartSecondPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LightManager_Load);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.panel_Center.ResumeLayout(false);
            this.panel_Center.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Button button_Form_Finish;
        private System.Windows.Forms.Label label_FormTitle;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.ComboBox comboBox_CleaningMode;
        private System.Windows.Forms.Label label_CleaningMode;
        private System.Windows.Forms.ComboBox comboBox_Vacuum;
        private System.Windows.Forms.Label label_Vacuum;
    }
}