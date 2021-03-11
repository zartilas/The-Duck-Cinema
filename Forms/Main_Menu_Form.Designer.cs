namespace TheDuckCinema
{
    partial class Main_Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu_Form));
            this.panel_Left = new System.Windows.Forms.Panel();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.button_Employee = new System.Windows.Forms.Button();
            this.button_Customer = new System.Windows.Forms.Button();
            this.label_Continue_As = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Line1 = new System.Windows.Forms.PictureBox();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.pictureBox_FullLogo = new System.Windows.Forms.PictureBox();
            this.panel_Left.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FullLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Left.Controls.Add(this.pictureBox1);
            this.panel_Left.Controls.Add(this.pictureBox_Line1);
            this.panel_Left.Controls.Add(this.button_Settings);
            this.panel_Left.Location = new System.Drawing.Point(-1, -1);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(197, 526);
            this.panel_Left.TabIndex = 0;
            // 
            // imageList_Buttons
            // 
            this.imageList_Buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Buttons.ImageStream")));
            this.imageList_Buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Buttons.Images.SetKeyName(0, "Settings.png");
            this.imageList_Buttons.Images.SetKeyName(1, "info.png");
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Controls.Add(this.button_Employee);
            this.panel_Bottom.Controls.Add(this.button_Customer);
            this.panel_Bottom.Controls.Add(this.label_Continue_As);
            this.panel_Bottom.Location = new System.Drawing.Point(195, 193);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(775, 326);
            this.panel_Bottom.TabIndex = 1;
            // 
            // button_Employee
            // 
            this.button_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.button_Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Employee.FlatAppearance.BorderSize = 0;
            this.button_Employee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Employee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Employee.Font = new System.Drawing.Font("Calibri", 18F);
            this.button_Employee.ForeColor = System.Drawing.Color.White;
            this.button_Employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Employee.Location = new System.Drawing.Point(264, 143);
            this.button_Employee.Name = "button_Employee";
            this.button_Employee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Employee.Size = new System.Drawing.Size(192, 64);
            this.button_Employee.TabIndex = 4;
            this.button_Employee.Text = "EMPLOYEE";
            this.button_Employee.UseVisualStyleBackColor = false;
            this.button_Employee.Click += new System.EventHandler(this.button_Employee_Click);
            // 
            // button_Customer
            // 
            this.button_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.button_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Customer.FlatAppearance.BorderSize = 0;
            this.button_Customer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Customer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Customer.Font = new System.Drawing.Font("Calibri", 18F);
            this.button_Customer.ForeColor = System.Drawing.Color.White;
            this.button_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Customer.Location = new System.Drawing.Point(264, 64);
            this.button_Customer.Name = "button_Customer";
            this.button_Customer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Customer.Size = new System.Drawing.Size(192, 64);
            this.button_Customer.TabIndex = 3;
            this.button_Customer.Text = "CUSTOMER";
            this.button_Customer.UseVisualStyleBackColor = false;
            this.button_Customer.Click += new System.EventHandler(this.button_Customer_Click);
            // 
            // label_Continue_As
            // 
            this.label_Continue_As.AutoSize = true;
            this.label_Continue_As.BackColor = System.Drawing.Color.Transparent;
            this.label_Continue_As.ForeColor = System.Drawing.Color.White;
            this.label_Continue_As.Location = new System.Drawing.Point(316, 28);
            this.label_Continue_As.Name = "label_Continue_As";
            this.label_Continue_As.Size = new System.Drawing.Size(90, 19);
            this.label_Continue_As.TabIndex = 0;
            this.label_Continue_As.Text = "Continue as:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::TheDuckCinema.Properties.Resources.AppLogo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_Line1
            // 
            this.pictureBox_Line1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Line1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Line1.Image = global::TheDuckCinema.Properties.Resources.black_line_png;
            this.pictureBox_Line1.Location = new System.Drawing.Point(-11, 439);
            this.pictureBox_Line1.Name = "pictureBox_Line1";
            this.pictureBox_Line1.Size = new System.Drawing.Size(227, 35);
            this.pictureBox_Line1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Line1.TabIndex = 2;
            this.pictureBox_Line1.TabStop = false;
            // 
            // button_Settings
            // 
            this.button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.button_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Settings.FlatAppearance.BorderSize = 0;
            this.button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.ForeColor = System.Drawing.Color.White;
            this.button_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Settings.ImageKey = "Settings.png";
            this.button_Settings.ImageList = this.imageList_Buttons;
            this.button_Settings.Location = new System.Drawing.Point(37, 476);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Settings.Size = new System.Drawing.Size(129, 31);
            this.button_Settings.TabIndex = 0;
            this.button_Settings.Text = "Settings";
            this.button_Settings.UseVisualStyleBackColor = false;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
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
            this.button_Help.Location = new System.Drawing.Point(299, 282);
            this.button_Help.Name = "button_Help";
            this.button_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Help.Size = new System.Drawing.Size(110, 31);
            this.button_Help.TabIndex = 3;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // pictureBox_FullLogo
            // 
            this.pictureBox_FullLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_FullLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_FullLogo.Image = global::TheDuckCinema.Properties.Resources.FullLogo;
            this.pictureBox_FullLogo.Location = new System.Drawing.Point(202, 34);
            this.pictureBox_FullLogo.Name = "pictureBox_FullLogo";
            this.pictureBox_FullLogo.Size = new System.Drawing.Size(753, 129);
            this.pictureBox_FullLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_FullLogo.TabIndex = 1;
            this.pictureBox_FullLogo.TabStop = false;
            // 
            // Main_Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 518);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.pictureBox_FullLogo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main_Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Duck Cinema - Welcome!";
            this.Load += new System.EventHandler(this.Main_Menu_Form_Load);
            this.panel_Left.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FullLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.PictureBox pictureBox_FullLogo;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.PictureBox pictureBox_Line1;
        private System.Windows.Forms.Button button_Employee;
        private System.Windows.Forms.Button button_Customer;
        private System.Windows.Forms.Label label_Continue_As;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

