namespace TheDuckCinema.Forms.Employee
{
    partial class DevicesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevicesManager));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.button_Help = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.panel_Center = new System.Windows.Forms.Panel();
            this.label_Fridge = new System.Windows.Forms.Label();
            this.pictureBox_Fridge = new System.Windows.Forms.PictureBox();
            this.label_Cashier = new System.Windows.Forms.Label();
            this.pictureBox_Cashier = new System.Windows.Forms.PictureBox();
            this.label_Coffee = new System.Windows.Forms.Label();
            this.pictureBox_Coffee = new System.Windows.Forms.PictureBox();
            this.label_Printer = new System.Windows.Forms.Label();
            this.pictureBox_Printer = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.panel_Center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fridge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Coffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Printer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.pictureBox_Back);
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Location = new System.Drawing.Point(0, 499);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(1197, 101);
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
            this.button_Help.Location = new System.Drawing.Point(172, 23);
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
            this.panel_Center.Controls.Add(this.label_Fridge);
            this.panel_Center.Controls.Add(this.pictureBox_Fridge);
            this.panel_Center.Controls.Add(this.label_Cashier);
            this.panel_Center.Controls.Add(this.pictureBox_Cashier);
            this.panel_Center.Controls.Add(this.label_Coffee);
            this.panel_Center.Controls.Add(this.pictureBox_Coffee);
            this.panel_Center.Controls.Add(this.label_Printer);
            this.panel_Center.Controls.Add(this.pictureBox_Printer);
            this.panel_Center.Controls.Add(this.label_Title);
            this.panel_Center.Location = new System.Drawing.Point(25, 25);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(394, 435);
            this.panel_Center.TabIndex = 49;
            // 
            // label_Fridge
            // 
            this.label_Fridge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Fridge.ForeColor = System.Drawing.Color.White;
            this.label_Fridge.Location = new System.Drawing.Point(225, 235);
            this.label_Fridge.Name = "label_Fridge";
            this.label_Fridge.Size = new System.Drawing.Size(108, 19);
            this.label_Fridge.TabIndex = 55;
            this.label_Fridge.Text = "Fridge";
            this.label_Fridge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Fridge
            // 
            this.pictureBox_Fridge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Fridge.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Fridge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Fridge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Fridge.Image = global::TheDuckCinema.Properties.Resources.Fridge;
            this.pictureBox_Fridge.Location = new System.Drawing.Point(224, 257);
            this.pictureBox_Fridge.Name = "pictureBox_Fridge";
            this.pictureBox_Fridge.Size = new System.Drawing.Size(117, 98);
            this.pictureBox_Fridge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Fridge.TabIndex = 54;
            this.pictureBox_Fridge.TabStop = false;
            this.pictureBox_Fridge.Click += new System.EventHandler(this.pictureBox_Fridge_Click);
            // 
            // label_Cashier
            // 
            this.label_Cashier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Cashier.ForeColor = System.Drawing.Color.White;
            this.label_Cashier.Location = new System.Drawing.Point(23, 235);
            this.label_Cashier.Name = "label_Cashier";
            this.label_Cashier.Size = new System.Drawing.Size(156, 19);
            this.label_Cashier.TabIndex = 53;
            this.label_Cashier.Text = "Cashier";
            this.label_Cashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Cashier
            // 
            this.pictureBox_Cashier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Cashier.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Cashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Cashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Cashier.Image = global::TheDuckCinema.Properties.Resources.Cashier;
            this.pictureBox_Cashier.Location = new System.Drawing.Point(48, 257);
            this.pictureBox_Cashier.Name = "pictureBox_Cashier";
            this.pictureBox_Cashier.Size = new System.Drawing.Size(117, 98);
            this.pictureBox_Cashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Cashier.TabIndex = 52;
            this.pictureBox_Cashier.TabStop = false;
            this.pictureBox_Cashier.Click += new System.EventHandler(this.pictureBox_Cashier_Click);
            // 
            // label_Coffee
            // 
            this.label_Coffee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Coffee.ForeColor = System.Drawing.Color.White;
            this.label_Coffee.Location = new System.Drawing.Point(220, 72);
            this.label_Coffee.Name = "label_Coffee";
            this.label_Coffee.Size = new System.Drawing.Size(123, 19);
            this.label_Coffee.TabIndex = 51;
            this.label_Coffee.Text = "Coffee Machinery";
            this.label_Coffee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Coffee
            // 
            this.pictureBox_Coffee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Coffee.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Coffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Coffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Coffee.Image = global::TheDuckCinema.Properties.Resources.Coffee;
            this.pictureBox_Coffee.Location = new System.Drawing.Point(224, 94);
            this.pictureBox_Coffee.Name = "pictureBox_Coffee";
            this.pictureBox_Coffee.Size = new System.Drawing.Size(119, 103);
            this.pictureBox_Coffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Coffee.TabIndex = 50;
            this.pictureBox_Coffee.TabStop = false;
            this.pictureBox_Coffee.Click += new System.EventHandler(this.pictureBox_Coffee_Click);
            // 
            // label_Printer
            // 
            this.label_Printer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Printer.ForeColor = System.Drawing.Color.White;
            this.label_Printer.Location = new System.Drawing.Point(27, 72);
            this.label_Printer.Name = "label_Printer";
            this.label_Printer.Size = new System.Drawing.Size(152, 19);
            this.label_Printer.TabIndex = 49;
            this.label_Printer.Text = "Printer and Scanner";
            this.label_Printer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Printer
            // 
            this.pictureBox_Printer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Printer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Printer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Printer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Printer.Image = global::TheDuckCinema.Properties.Resources.Printer;
            this.pictureBox_Printer.Location = new System.Drawing.Point(48, 94);
            this.pictureBox_Printer.Name = "pictureBox_Printer";
            this.pictureBox_Printer.Size = new System.Drawing.Size(117, 103);
            this.pictureBox_Printer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Printer.TabIndex = 48;
            this.pictureBox_Printer.TabStop = false;
            this.pictureBox_Printer.Click += new System.EventHandler(this.pictureBox_Printer_Click);
            // 
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(87, 21);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(231, 32);
            this.label_Title.TabIndex = 47;
            this.label_Title.Text = "DEVICES";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevicesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 576);
            this.Controls.Add(this.panel_Center);
            this.Controls.Add(this.panel_Bottom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DevicesManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DevicesManager_Load);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.panel_Center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fridge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Coffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Printer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Printer;
        private System.Windows.Forms.PictureBox pictureBox_Printer;
        private System.Windows.Forms.Label label_Cashier;
        private System.Windows.Forms.PictureBox pictureBox_Cashier;
        private System.Windows.Forms.Label label_Coffee;
        private System.Windows.Forms.PictureBox pictureBox_Coffee;
        private System.Windows.Forms.Label label_Fridge;
        private System.Windows.Forms.PictureBox pictureBox_Fridge;
    }
}