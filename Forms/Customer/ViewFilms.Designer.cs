namespace TheDuckCinema.Forms.Customer
{
    partial class ViewFilms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFilms));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.button_Help = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.pictureBox_TV = new System.Windows.Forms.PictureBox();
            this.listBox_Movies = new System.Windows.Forms.ListBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.listBox_MoviesHidden = new System.Windows.Forms.ListBox();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.pictureBox_Back);
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Location = new System.Drawing.Point(-1, 594);
            this.panel_Bottom.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(1226, 153);
            this.panel_Bottom.TabIndex = 10;
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Back.Image = global::TheDuckCinema.Properties.Resources.Back_WhiteMode;
            this.pictureBox_Back.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Back.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(124, 110);
            this.pictureBox_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Back.TabIndex = 0;
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
            this.button_Help.Location = new System.Drawing.Point(540, 42);
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
            // textBox_Search
            // 
            this.textBox_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.textBox_Search.ForeColor = System.Drawing.Color.White;
            this.textBox_Search.Location = new System.Drawing.Point(71, 68);
            this.textBox_Search.MaxLength = 25;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(263, 27);
            this.textBox_Search.TabIndex = 1;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // pictureBox_TV
            // 
            this.pictureBox_TV.Image = global::TheDuckCinema.Properties.Resources.TVMovies;
            this.pictureBox_TV.Location = new System.Drawing.Point(29, 13);
            this.pictureBox_TV.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_TV.Name = "pictureBox_TV";
            this.pictureBox_TV.Size = new System.Drawing.Size(1164, 561);
            this.pictureBox_TV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TV.TabIndex = 0;
            this.pictureBox_TV.TabStop = false;
            // 
            // listBox_Movies
            // 
            this.listBox_Movies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox_Movies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.listBox_Movies.Font = new System.Drawing.Font("Calibri", 18F);
            this.listBox_Movies.ForeColor = System.Drawing.Color.White;
            this.listBox_Movies.FormattingEnabled = true;
            this.listBox_Movies.ItemHeight = 29;
            this.listBox_Movies.Items.AddRange(new object[] {
            "Movie:\t \t\tShowtime: \tDirector:\t\t\tRatings:  \t\tPrice:",
            "---------------------------------------------------------------------------------" +
                "-----------------------------------------------------------------",
            "Duckpool,  \t\t18:00-20:00,               Marwan Hodson,  \t\t9.1/10,       \t€10",
            "The Princess and the Duck,  \t14:00-16:00,               Loui Archer,  \t\t7.2/10,  " +
                "     \t€10",
            "Ducklist,  \t\t20:00-22:00,               Ayaan Ramos,  \t\t9.6/10,       \t€10",
            "Ducks of Academy,  \t22:00-00:00,               Orion Sosa,  \t\t8.4/10,       \t€10",
            "Duck Wick,  \t\t18:00-21:00,               Christopher Regan,  \t7.8/10,       \t€10"});
            this.listBox_Movies.Location = new System.Drawing.Point(71, 151);
            this.listBox_Movies.Name = "listBox_Movies";
            this.listBox_Movies.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_Movies.Size = new System.Drawing.Size(1042, 323);
            this.listBox_Movies.TabIndex = 2;
            this.listBox_Movies.TabStop = false;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.button_Search.BackgroundImage = global::TheDuckCinema.Properties.Resources.Search;
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Calibri", 18F);
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Search.Location = new System.Drawing.Point(334, 69);
            this.button_Search.Name = "button_Search";
            this.button_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Search.Size = new System.Drawing.Size(28, 26);
            this.button_Search.TabIndex = 14;
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // listBox_MoviesHidden
            // 
            this.listBox_MoviesHidden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox_MoviesHidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.listBox_MoviesHidden.Font = new System.Drawing.Font("Calibri", 18F);
            this.listBox_MoviesHidden.ForeColor = System.Drawing.Color.White;
            this.listBox_MoviesHidden.FormattingEnabled = true;
            this.listBox_MoviesHidden.ItemHeight = 29;
            this.listBox_MoviesHidden.Items.AddRange(new object[] {
            "Movie:\t \t\tShowtime: \tDirector:\t\t\tRatings:  \t\tPrice:",
            "---------------------------------------------------------------------------------" +
                "-----------------------------------------------------------------",
            "Duckpool,  \t\t18:00-20:00,               Marwan Hodson,  \t\t9.1/10,       \t€10",
            "The Princess and the Duck,  \t14:00-16:00,               Loui Archer,  \t\t7.2/10,  " +
                "     \t€10",
            "Ducklist,  \t\t20:00-22:00,               Ayaan Ramos,  \t\t9.6/10,       \t€10",
            "Ducks of Academy,  \t22:00-00:00,               Orion Sosa,  \t\t8.4/10,       \t€10",
            "Duck Wick,  \t\t18:00-21:00,               Christopher Regan,  \t7.8/10,       \t€10"});
            this.listBox_MoviesHidden.Location = new System.Drawing.Point(71, 541);
            this.listBox_MoviesHidden.Name = "listBox_MoviesHidden";
            this.listBox_MoviesHidden.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_MoviesHidden.Size = new System.Drawing.Size(1042, 33);
            this.listBox_MoviesHidden.TabIndex = 15;
            this.listBox_MoviesHidden.TabStop = false;
            this.listBox_MoviesHidden.Visible = false;
            this.listBox_MoviesHidden.SelectedIndexChanged += new System.EventHandler(this.listBox_MoviesHidden_SelectedIndexChanged);
            // 
            // ViewFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1218, 704);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.listBox_Movies);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.pictureBox_TV);
            this.Controls.Add(this.listBox_MoviesHidden);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewFilms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ViewFilms_Load);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_TV;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.ListBox listBox_Movies;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ListBox listBox_MoviesHidden;
    }
}