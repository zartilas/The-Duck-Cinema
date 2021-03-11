namespace TheDuckCinema.Forms.Customer
{
    partial class Bar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bar));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_Menu = new System.Windows.Forms.PictureBox();
            this.button_Help = new System.Windows.Forms.Button();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.pictureBox_Backgrnd = new System.Windows.Forms.PictureBox();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Backgrnd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Controls.Add(this.pictureBox_Back);
            this.panel_Bottom.Location = new System.Drawing.Point(-1, 678);
            this.panel_Bottom.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(1057, 153);
            this.panel_Bottom.TabIndex = 11;
            // 
            // imageList_Buttons
            // 
            this.imageList_Buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Buttons.ImageStream")));
            this.imageList_Buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Buttons.Images.SetKeyName(0, "info.png");
            // 
            // pictureBox_Menu
            // 
            this.pictureBox_Menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Menu.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Menu.Image = global::TheDuckCinema.Properties.Resources.Menu;
            this.pictureBox_Menu.Location = new System.Drawing.Point(807, 568);
            this.pictureBox_Menu.Name = "pictureBox_Menu";
            this.pictureBox_Menu.Size = new System.Drawing.Size(91, 95);
            this.pictureBox_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Menu.TabIndex = 15;
            this.pictureBox_Menu.TabStop = false;
            this.pictureBox_Menu.Click += new System.EventHandler(this.pictureBox_Menu_Click);
            this.pictureBox_Menu.MouseEnter += new System.EventHandler(this.pictureBox_Menu_MouseEnter);
            this.pictureBox_Menu.MouseLeave += new System.EventHandler(this.pictureBox_Menu_MouseLeave);
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
            this.button_Help.Location = new System.Drawing.Point(485, 33);
            this.button_Help.Name = "button_Help";
            this.button_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Help.Size = new System.Drawing.Size(110, 31);
            this.button_Help.TabIndex = 11;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Back.Image = global::TheDuckCinema.Properties.Resources.Back_WhiteMode;
            this.pictureBox_Back.Location = new System.Drawing.Point(3, -9);
            this.pictureBox_Back.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(124, 110);
            this.pictureBox_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Back.TabIndex = 0;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Click += new System.EventHandler(this.pictureBox_Back_Click);
            // 
            // pictureBox_Backgrnd
            // 
            this.pictureBox_Backgrnd.Image = global::TheDuckCinema.Properties.Resources.Bar;
            this.pictureBox_Backgrnd.Location = new System.Drawing.Point(2, 0);
            this.pictureBox_Backgrnd.Name = "pictureBox_Backgrnd";
            this.pictureBox_Backgrnd.Size = new System.Drawing.Size(1051, 681);
            this.pictureBox_Backgrnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Backgrnd.TabIndex = 12;
            this.pictureBox_Backgrnd.TabStop = false;
            // 
            // Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 782);
            this.Controls.Add(this.pictureBox_Menu);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.pictureBox_Backgrnd);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Bar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Duck Cinema - Bar";
            this.Load += new System.EventHandler(this.Bar_Load);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Backgrnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.PictureBox pictureBox_Backgrnd;
        private System.Windows.Forms.PictureBox pictureBox_Menu;
    }
}