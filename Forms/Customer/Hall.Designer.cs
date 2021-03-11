namespace TheDuckCinema.Forms.Customer
{
    partial class Hall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hall));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.button_Help = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_ViewMovies = new System.Windows.Forms.PictureBox();
            this.pictureBox_BuyTickets = new System.Windows.Forms.PictureBox();
            this.pictureBox_Elevator = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bar = new System.Windows.Forms.PictureBox();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ViewMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BuyTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.pictureBox_Back);
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Location = new System.Drawing.Point(2, 546);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(1282, 101);
            this.panel_Bottom.TabIndex = 10;
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.BackColor = System.Drawing.Color.Transparent;
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
            this.button_Help.Location = new System.Drawing.Point(536, 21);
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
            // pictureBox_ViewMovies
            // 
            this.pictureBox_ViewMovies.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ViewMovies.Image = global::TheDuckCinema.Properties.Resources.View;
            this.pictureBox_ViewMovies.Location = new System.Drawing.Point(584, 127);
            this.pictureBox_ViewMovies.Name = "pictureBox_ViewMovies";
            this.pictureBox_ViewMovies.Size = new System.Drawing.Size(64, 65);
            this.pictureBox_ViewMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ViewMovies.TabIndex = 11;
            this.pictureBox_ViewMovies.TabStop = false;
            this.pictureBox_ViewMovies.Click += new System.EventHandler(this.pictureBox_ViewMovies_Click);
            this.pictureBox_ViewMovies.MouseEnter += new System.EventHandler(this.pictureBox_ViewMovies_MouseEnter);
            this.pictureBox_ViewMovies.MouseLeave += new System.EventHandler(this.pictureBox_ViewMovies_MouseLeave);
            // 
            // pictureBox_BuyTickets
            // 
            this.pictureBox_BuyTickets.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_BuyTickets.Image = global::TheDuckCinema.Properties.Resources.BuyTickets;
            this.pictureBox_BuyTickets.Location = new System.Drawing.Point(574, 329);
            this.pictureBox_BuyTickets.Name = "pictureBox_BuyTickets";
            this.pictureBox_BuyTickets.Size = new System.Drawing.Size(66, 64);
            this.pictureBox_BuyTickets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_BuyTickets.TabIndex = 12;
            this.pictureBox_BuyTickets.TabStop = false;
            this.pictureBox_BuyTickets.Click += new System.EventHandler(this.pictureBox_BuyTickets_Click);
            this.pictureBox_BuyTickets.MouseEnter += new System.EventHandler(this.pictureBox_BuyTickets_MouseEnter);
            this.pictureBox_BuyTickets.MouseLeave += new System.EventHandler(this.pictureBox_BuyTickets_MouseLeave);
            // 
            // pictureBox_Elevator
            // 
            this.pictureBox_Elevator.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Elevator.Image = global::TheDuckCinema.Properties.Resources.Elevator;
            this.pictureBox_Elevator.Location = new System.Drawing.Point(317, 255);
            this.pictureBox_Elevator.Name = "pictureBox_Elevator";
            this.pictureBox_Elevator.Size = new System.Drawing.Size(64, 57);
            this.pictureBox_Elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Elevator.TabIndex = 13;
            this.pictureBox_Elevator.TabStop = false;
            this.pictureBox_Elevator.Click += new System.EventHandler(this.pictureBox_Elevator_Click);
            this.pictureBox_Elevator.MouseEnter += new System.EventHandler(this.pictureBox_Elevator_MouseEnter);
            this.pictureBox_Elevator.MouseLeave += new System.EventHandler(this.pictureBox_Elevator_MouseLeave);
            // 
            // pictureBox_Bar
            // 
            this.pictureBox_Bar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Bar.Image = global::TheDuckCinema.Properties.Resources.Food;
            this.pictureBox_Bar.Location = new System.Drawing.Point(1075, 304);
            this.pictureBox_Bar.Name = "pictureBox_Bar";
            this.pictureBox_Bar.Size = new System.Drawing.Size(76, 74);
            this.pictureBox_Bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bar.TabIndex = 14;
            this.pictureBox_Bar.TabStop = false;
            this.pictureBox_Bar.Click += new System.EventHandler(this.pictureBox_Bar_Click);
            this.pictureBox_Bar.MouseEnter += new System.EventHandler(this.pictureBox_Bar_MouseEnter);
            this.pictureBox_Bar.MouseLeave += new System.EventHandler(this.pictureBox_Bar_MouseLeave);
            // 
            // Hall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheDuckCinema.Properties.Resources.Hall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 620);
            this.Controls.Add(this.pictureBox_Bar);
            this.Controls.Add(this.pictureBox_Elevator);
            this.Controls.Add(this.pictureBox_BuyTickets);
            this.Controls.Add(this.pictureBox_ViewMovies);
            this.Controls.Add(this.panel_Bottom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Hall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Duck Cinema - Hall";
            this.Load += new System.EventHandler(this.Hall_Load);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ViewMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BuyTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.PictureBox pictureBox_ViewMovies;
        private System.Windows.Forms.PictureBox pictureBox_BuyTickets;
        private System.Windows.Forms.PictureBox pictureBox_Elevator;
        private System.Windows.Forms.PictureBox pictureBox_Bar;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.PictureBox pictureBox_Back;
    }
}