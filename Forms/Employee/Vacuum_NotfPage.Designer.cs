namespace TheDuckCinema.Forms.Employee
{
    partial class Vacuum_NotfPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacuum_NotfPage));
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.button_Help = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_List = new System.Windows.Forms.Label();
            this.panel_Center = new System.Windows.Forms.Panel();
            this.button_Send2 = new System.Windows.Forms.Button();
            this.label_ListHeader = new System.Windows.Forms.Label();
            this.button_Send1 = new System.Windows.Forms.Button();
            this.label_NotificationText = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.panel_Center.SuspendLayout();
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
            this.panel_Bottom.Location = new System.Drawing.Point(3, 298);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(945, 101);
            this.panel_Bottom.TabIndex = 17;
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Back.Image = global::TheDuckCinema.Properties.Resources.Back_WhiteMode;
            this.pictureBox_Back.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(101, 89);
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
            this.button_Help.Location = new System.Drawing.Point(402, 31);
            this.button_Help.Name = "button_Help";
            this.button_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Help.Size = new System.Drawing.Size(110, 31);
            this.button_Help.TabIndex = 10;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Title.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(334, 19);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(209, 32);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "NOTIFICATIONS";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_List
            // 
            this.label_List.AutoSize = true;
            this.label_List.BackColor = System.Drawing.Color.Transparent;
            this.label_List.ForeColor = System.Drawing.Color.White;
            this.label_List.Location = new System.Drawing.Point(39, 30);
            this.label_List.Name = "label_List";
            this.label_List.Size = new System.Drawing.Size(566, 38);
            this.label_List.TabIndex = 2;
            this.label_List.Text = resources.GetString("label_List.Text");
            this.label_List.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Center
            // 
            this.panel_Center.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panel_Center.Controls.Add(this.button_Send2);
            this.panel_Center.Controls.Add(this.label_ListHeader);
            this.panel_Center.Controls.Add(this.label_List);
            this.panel_Center.Controls.Add(this.button_Send1);
            this.panel_Center.Location = new System.Drawing.Point(21, 91);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(862, 124);
            this.panel_Center.TabIndex = 18;
            // 
            // button_Send2
            // 
            this.button_Send2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.button_Send2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Send2.FlatAppearance.BorderSize = 0;
            this.button_Send2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Send2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Send2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Send2.Font = new System.Drawing.Font("Calibri", 18F);
            this.button_Send2.ForeColor = System.Drawing.Color.White;
            this.button_Send2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Send2.Location = new System.Drawing.Point(16, 51);
            this.button_Send2.Name = "button_Send2";
            this.button_Send2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Send2.Size = new System.Drawing.Size(15, 13);
            this.button_Send2.TabIndex = 20;
            this.button_Send2.UseVisualStyleBackColor = false;
            this.button_Send2.Click += new System.EventHandler(this.button_Send2_Click);
            // 
            // label_ListHeader
            // 
            this.label_ListHeader.AutoSize = true;
            this.label_ListHeader.BackColor = System.Drawing.Color.Transparent;
            this.label_ListHeader.ForeColor = System.Drawing.Color.White;
            this.label_ListHeader.Location = new System.Drawing.Point(39, 9);
            this.label_ListHeader.Name = "label_ListHeader";
            this.label_ListHeader.Size = new System.Drawing.Size(397, 19);
            this.label_ListHeader.TabIndex = 3;
            this.label_ListHeader.Text = "ID:        Vacuum:         Cleanup ID:         Date:           Problem:";
            this.label_ListHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Send1
            // 
            this.button_Send1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.button_Send1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Send1.FlatAppearance.BorderSize = 0;
            this.button_Send1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Send1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Send1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Send1.Font = new System.Drawing.Font("Calibri", 18F);
            this.button_Send1.ForeColor = System.Drawing.Color.White;
            this.button_Send1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Send1.Location = new System.Drawing.Point(16, 32);
            this.button_Send1.Name = "button_Send1";
            this.button_Send1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Send1.Size = new System.Drawing.Size(15, 13);
            this.button_Send1.TabIndex = 19;
            this.button_Send1.UseVisualStyleBackColor = false;
            this.button_Send1.Click += new System.EventHandler(this.button_Send1_Click);
            // 
            // label_NotificationText
            // 
            this.label_NotificationText.AutoSize = true;
            this.label_NotificationText.BackColor = System.Drawing.Color.Transparent;
            this.label_NotificationText.ForeColor = System.Drawing.Color.Black;
            this.label_NotificationText.Location = new System.Drawing.Point(17, 69);
            this.label_NotificationText.Name = "label_NotificationText";
            this.label_NotificationText.Size = new System.Drawing.Size(163, 19);
            this.label_NotificationText.TabIndex = 4;
            this.label_NotificationText.Text = "You have 2 notifications";
            this.label_NotificationText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Vacuum_NotfPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 386);
            this.Controls.Add(this.label_NotificationText);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Center);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Vacuum_NotfPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Vacuum_SecondPage_Load);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.panel_Center.ResumeLayout(false);
            this.panel_Center.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_List;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.Label label_ListHeader;
        private System.Windows.Forms.Label label_NotificationText;
        private System.Windows.Forms.Button button_Send1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_Send2;
    }
}