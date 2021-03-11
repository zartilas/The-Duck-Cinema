namespace TheDuckCinema.Forms.Customer
{
    partial class Menu_SecondPagePOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_SecondPagePOS));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.panel_Steps = new System.Windows.Forms.Panel();
            this.label_Steps = new System.Windows.Forms.Label();
            this.pictureBox_CircleGif = new System.Windows.Forms.PictureBox();
            this.pictureBox_POS = new System.Windows.Forms.PictureBox();
            this.panel_Bottom.SuspendLayout();
            this.panel_Steps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CircleGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_POS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Location = new System.Drawing.Point(-1, 507);
            this.panel_Bottom.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(944, 120);
            this.panel_Bottom.TabIndex = 13;
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
            this.button_Help.Location = new System.Drawing.Point(234, 21);
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
            // panel_Steps
            // 
            this.panel_Steps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Steps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panel_Steps.Controls.Add(this.label_Steps);
            this.panel_Steps.Location = new System.Drawing.Point(442, 178);
            this.panel_Steps.Name = "panel_Steps";
            this.panel_Steps.Size = new System.Drawing.Size(267, 80);
            this.panel_Steps.TabIndex = 49;
            // 
            // label_Steps
            // 
            this.label_Steps.AutoSize = true;
            this.label_Steps.BackColor = System.Drawing.Color.Transparent;
            this.label_Steps.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Steps.ForeColor = System.Drawing.Color.White;
            this.label_Steps.Location = new System.Drawing.Point(4, 9);
            this.label_Steps.Name = "label_Steps";
            this.label_Steps.Size = new System.Drawing.Size(227, 57);
            this.label_Steps.TabIndex = 47;
            this.label_Steps.Text = "Steps:\r\n1. Place your card on the POS.\r\n2. Press the green button (Circle).";
            // 
            // pictureBox_CircleGif
            // 
            this.pictureBox_CircleGif.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CircleGif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_CircleGif.Image = global::TheDuckCinema.Properties.Resources.green_circle;
            this.pictureBox_CircleGif.Location = new System.Drawing.Point(296, 392);
            this.pictureBox_CircleGif.Name = "pictureBox_CircleGif";
            this.pictureBox_CircleGif.Size = new System.Drawing.Size(71, 69);
            this.pictureBox_CircleGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CircleGif.TabIndex = 50;
            this.pictureBox_CircleGif.TabStop = false;
            this.pictureBox_CircleGif.Click += new System.EventHandler(this.pictureBox_CircleGif_Click);
            // 
            // pictureBox_POS
            // 
            this.pictureBox_POS.Image = global::TheDuckCinema.Properties.Resources.POS;
            this.pictureBox_POS.Location = new System.Drawing.Point(40, -10);
            this.pictureBox_POS.Name = "pictureBox_POS";
            this.pictureBox_POS.Size = new System.Drawing.Size(491, 490);
            this.pictureBox_POS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_POS.TabIndex = 12;
            this.pictureBox_POS.TabStop = false;
            // 
            // Menu_SecondPagePOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 583);
            this.Controls.Add(this.pictureBox_CircleGif);
            this.Controls.Add(this.panel_Steps);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.pictureBox_POS);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Menu_SecondPagePOS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_SecondPagePOS_Load);
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Steps.ResumeLayout(false);
            this.panel_Steps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CircleGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_POS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.PictureBox pictureBox_POS;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.Panel panel_Steps;
        private System.Windows.Forms.Label label_Steps;
        private System.Windows.Forms.PictureBox pictureBox_CircleGif;
    }
}