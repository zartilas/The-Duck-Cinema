namespace TheDuckCinema.Forms.Employee
{
    partial class Office
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Office));
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.button_Help = new System.Windows.Forms.Button();
            this.pictureBox_Vacuum = new System.Windows.Forms.PictureBox();
            this.pictureBox_Devices = new System.Windows.Forms.PictureBox();
            this.pictureBox_Lights = new System.Windows.Forms.PictureBox();
            this.pictureBox_Backgrnd = new System.Windows.Forms.PictureBox();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Vacuum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Devices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Lights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Backgrnd)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList_Buttons
            // 
            this.imageList_Buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Buttons.ImageStream")));
            this.imageList_Buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Buttons.Images.SetKeyName(0, "info.png");
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.pictureBox_Back);
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Location = new System.Drawing.Point(-2, 556);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(1282, 101);
            this.panel_Bottom.TabIndex = 15;
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
            this.button_Help.Location = new System.Drawing.Point(470, 22);
            this.button_Help.Name = "button_Help";
            this.button_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Help.Size = new System.Drawing.Size(110, 31);
            this.button_Help.TabIndex = 10;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // pictureBox_Vacuum
            // 
            this.pictureBox_Vacuum.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Vacuum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Vacuum.Image = global::TheDuckCinema.Properties.Resources.Robot;
            this.pictureBox_Vacuum.Location = new System.Drawing.Point(253, 246);
            this.pictureBox_Vacuum.Name = "pictureBox_Vacuum";
            this.pictureBox_Vacuum.Size = new System.Drawing.Size(64, 65);
            this.pictureBox_Vacuum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Vacuum.TabIndex = 20;
            this.pictureBox_Vacuum.TabStop = false;
            this.pictureBox_Vacuum.Click += new System.EventHandler(this.pictureBox_Vacuum_Click);
            this.pictureBox_Vacuum.MouseEnter += new System.EventHandler(this.pictureBox_Vacuum_MouseEnter);
            this.pictureBox_Vacuum.MouseLeave += new System.EventHandler(this.pictureBox_Vacuum_MouseLeave);
            // 
            // pictureBox_Devices
            // 
            this.pictureBox_Devices.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Devices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Devices.Image = global::TheDuckCinema.Properties.Resources.Devices;
            this.pictureBox_Devices.Location = new System.Drawing.Point(253, 162);
            this.pictureBox_Devices.Name = "pictureBox_Devices";
            this.pictureBox_Devices.Size = new System.Drawing.Size(64, 65);
            this.pictureBox_Devices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Devices.TabIndex = 19;
            this.pictureBox_Devices.TabStop = false;
            this.pictureBox_Devices.Click += new System.EventHandler(this.pictureBox_Devices_Click);
            this.pictureBox_Devices.MouseEnter += new System.EventHandler(this.pictureBox_Devices_MouseEnter);
            this.pictureBox_Devices.MouseLeave += new System.EventHandler(this.pictureBox_Devices_MouseLeave);
            // 
            // pictureBox_Lights
            // 
            this.pictureBox_Lights.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Lights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Lights.Image = global::TheDuckCinema.Properties.Resources.Lights;
            this.pictureBox_Lights.Location = new System.Drawing.Point(253, 78);
            this.pictureBox_Lights.Name = "pictureBox_Lights";
            this.pictureBox_Lights.Size = new System.Drawing.Size(64, 65);
            this.pictureBox_Lights.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Lights.TabIndex = 16;
            this.pictureBox_Lights.TabStop = false;
            this.pictureBox_Lights.Click += new System.EventHandler(this.pictureBox_Lights_Click);
            this.pictureBox_Lights.MouseEnter += new System.EventHandler(this.pictureBox_Lights_MouseEnter);
            this.pictureBox_Lights.MouseLeave += new System.EventHandler(this.pictureBox_Lights_MouseLeave);
            // 
            // pictureBox_Backgrnd
            // 
            this.pictureBox_Backgrnd.Image = global::TheDuckCinema.Properties.Resources.computer;
            this.pictureBox_Backgrnd.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox_Backgrnd.Name = "pictureBox_Backgrnd";
            this.pictureBox_Backgrnd.Size = new System.Drawing.Size(1060, 556);
            this.pictureBox_Backgrnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Backgrnd.TabIndex = 18;
            this.pictureBox_Backgrnd.TabStop = false;
            // 
            // Office
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 635);
            this.Controls.Add(this.pictureBox_Vacuum);
            this.Controls.Add(this.pictureBox_Devices);
            this.Controls.Add(this.pictureBox_Lights);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.pictureBox_Backgrnd);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Office";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Duck Cinema - Staff Access";
            this.Load += new System.EventHandler(this.Office_Load);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Vacuum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Devices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Lights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Backgrnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.PictureBox pictureBox_Backgrnd;
        private System.Windows.Forms.PictureBox pictureBox_Lights;
        private System.Windows.Forms.PictureBox pictureBox_Devices;
        private System.Windows.Forms.PictureBox pictureBox_Vacuum;
    }
}