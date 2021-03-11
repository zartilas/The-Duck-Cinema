namespace TheDuckCinema.Forms.Customer
{
    partial class Cinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cinema));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit4 = new System.Windows.Forms.PictureBox();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Controls.Add(this.pictureBox_Back);
            this.panel_Bottom.Location = new System.Drawing.Point(0, 630);
            this.panel_Bottom.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(1301, 138);
            this.panel_Bottom.TabIndex = 11;
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
            this.button_Help.Location = new System.Drawing.Point(602, 29);
            this.button_Help.Name = "button_Help";
            this.button_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Help.Size = new System.Drawing.Size(110, 31);
            this.button_Help.TabIndex = 11;
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
            // pictureBox_Back
            // 
            this.pictureBox_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Back.Image = global::TheDuckCinema.Properties.Resources.Back_WhiteMode;
            this.pictureBox_Back.Location = new System.Drawing.Point(0, -13);
            this.pictureBox_Back.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(124, 110);
            this.pictureBox_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Back.TabIndex = 0;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Click += new System.EventHandler(this.pictureBox_Back_Click);
            // 
            // pictureBox_Exit1
            // 
            this.pictureBox_Exit1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Exit1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit1.Image")));
            this.pictureBox_Exit1.Location = new System.Drawing.Point(41, 321);
            this.pictureBox_Exit1.Name = "pictureBox_Exit1";
            this.pictureBox_Exit1.Size = new System.Drawing.Size(64, 57);
            this.pictureBox_Exit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit1.TabIndex = 14;
            this.pictureBox_Exit1.TabStop = false;
            this.pictureBox_Exit1.Click += new System.EventHandler(this.pictureBox_Exit1_Click);
            this.pictureBox_Exit1.MouseEnter += new System.EventHandler(this.pictureBox_Exit1_MouseEnter);
            this.pictureBox_Exit1.MouseLeave += new System.EventHandler(this.pictureBox_Exit1_MouseLeave);
            // 
            // pictureBox_Exit2
            // 
            this.pictureBox_Exit2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Exit2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit2.Image")));
            this.pictureBox_Exit2.Location = new System.Drawing.Point(256, 293);
            this.pictureBox_Exit2.Name = "pictureBox_Exit2";
            this.pictureBox_Exit2.Size = new System.Drawing.Size(64, 57);
            this.pictureBox_Exit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit2.TabIndex = 15;
            this.pictureBox_Exit2.TabStop = false;
            this.pictureBox_Exit2.Click += new System.EventHandler(this.pictureBox_Exit2_Click);
            this.pictureBox_Exit2.MouseEnter += new System.EventHandler(this.pictureBox_Exit2_MouseEnter);
            this.pictureBox_Exit2.MouseLeave += new System.EventHandler(this.pictureBox_Exit2_MouseLeave);
            // 
            // pictureBox_Exit3
            // 
            this.pictureBox_Exit3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Exit3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit3.Image")));
            this.pictureBox_Exit3.Location = new System.Drawing.Point(975, 293);
            this.pictureBox_Exit3.Name = "pictureBox_Exit3";
            this.pictureBox_Exit3.Size = new System.Drawing.Size(64, 57);
            this.pictureBox_Exit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit3.TabIndex = 16;
            this.pictureBox_Exit3.TabStop = false;
            this.pictureBox_Exit3.Click += new System.EventHandler(this.pictureBox_Exit3_Click);
            this.pictureBox_Exit3.MouseEnter += new System.EventHandler(this.pictureBox_Exit3_MouseEnter);
            this.pictureBox_Exit3.MouseLeave += new System.EventHandler(this.pictureBox_Exit3_MouseLeave);
            // 
            // pictureBox_Exit4
            // 
            this.pictureBox_Exit4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Exit4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit4.Image")));
            this.pictureBox_Exit4.Location = new System.Drawing.Point(1174, 321);
            this.pictureBox_Exit4.Name = "pictureBox_Exit4";
            this.pictureBox_Exit4.Size = new System.Drawing.Size(64, 57);
            this.pictureBox_Exit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Exit4.TabIndex = 17;
            this.pictureBox_Exit4.TabStop = false;
            this.pictureBox_Exit4.Click += new System.EventHandler(this.pictureBox_Exit4_Click);
            this.pictureBox_Exit4.MouseEnter += new System.EventHandler(this.pictureBox_Exit4_MouseEnter);
            this.pictureBox_Exit4.MouseLeave += new System.EventHandler(this.pictureBox_Exit4_MouseLeave);
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheDuckCinema.Properties.Resources.CinemaRoom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1285, 721);
            this.Controls.Add(this.pictureBox_Exit4);
            this.Controls.Add(this.pictureBox_Exit3);
            this.Controls.Add(this.pictureBox_Exit2);
            this.Controls.Add(this.pictureBox_Exit1);
            this.Controls.Add(this.panel_Bottom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Cinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Duck Cinema - Cinema Room";
            this.Load += new System.EventHandler(this.Cinema_Load);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.PictureBox pictureBox_Exit1;
        private System.Windows.Forms.PictureBox pictureBox_Exit2;
        private System.Windows.Forms.PictureBox pictureBox_Exit3;
        private System.Windows.Forms.PictureBox pictureBox_Exit4;
    }
}