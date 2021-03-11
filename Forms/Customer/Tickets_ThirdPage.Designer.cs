namespace TheDuckCinema.Forms.Customer
{
    partial class Tickets_ThirdPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets_ThirdPage));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.label_TotalPriceSum = new System.Windows.Forms.Label();
            this.Label_TotalPrice = new System.Windows.Forms.Label();
            this.panel_Card = new System.Windows.Forms.Panel();
            this.label_Card_Phone = new System.Windows.Forms.Label();
            this.label_Card_Email = new System.Windows.Forms.Label();
            this.label_Card_Name = new System.Windows.Forms.Label();
            this.label_Card_Card = new System.Windows.Forms.Label();
            this.textBox_Card_Email = new System.Windows.Forms.TextBox();
            this.textBox_Card_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Card_Name = new System.Windows.Forms.TextBox();
            this.textBox_Card_CardNum = new System.Windows.Forms.TextBox();
            this.label_Card_Selected = new System.Windows.Forms.Label();
            this.button_Card_Pay = new System.Windows.Forms.Button();
            this.label_Card_TitleForm = new System.Windows.Forms.Label();
            this.button_Cash = new System.Windows.Forms.Button();
            this.button_Card = new System.Windows.Forms.Button();
            this.panel_Cash = new System.Windows.Forms.Panel();
            this.label_Cash_Phone = new System.Windows.Forms.Label();
            this.label_Cash_Email = new System.Windows.Forms.Label();
            this.label_Cash_Name = new System.Windows.Forms.Label();
            this.textBox_Cash_Email = new System.Windows.Forms.TextBox();
            this.textBox_Cash_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Cash_Name = new System.Windows.Forms.TextBox();
            this.label_Cash_Selected = new System.Windows.Forms.Label();
            this.button_Cash_Completed = new System.Windows.Forms.Button();
            this.label_Cash_TitleForm = new System.Windows.Forms.Label();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.panel_Card.SuspendLayout();
            this.panel_Cash.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Controls.Add(this.pictureBox_Back);
            this.panel_Bottom.Location = new System.Drawing.Point(-1, 525);
            this.panel_Bottom.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(454, 136);
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
            this.button_Help.Location = new System.Drawing.Point(173, 28);
            this.button_Help.Name = "button_Help";
            this.button_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Help.Size = new System.Drawing.Size(110, 31);
            this.button_Help.TabIndex = 15;
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
            // label_TotalPriceSum
            // 
            this.label_TotalPriceSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_TotalPriceSum.AutoSize = true;
            this.label_TotalPriceSum.BackColor = System.Drawing.Color.Transparent;
            this.label_TotalPriceSum.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalPriceSum.ForeColor = System.Drawing.Color.Black;
            this.label_TotalPriceSum.Location = new System.Drawing.Point(306, 47);
            this.label_TotalPriceSum.Name = "label_TotalPriceSum";
            this.label_TotalPriceSum.Size = new System.Drawing.Size(37, 29);
            this.label_TotalPriceSum.TabIndex = 46;
            this.label_TotalPriceSum.Text = "€0";
            // 
            // Label_TotalPrice
            // 
            this.Label_TotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_TotalPrice.AutoSize = true;
            this.Label_TotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.Label_TotalPrice.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalPrice.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalPrice.Location = new System.Drawing.Point(133, 47);
            this.Label_TotalPrice.Name = "Label_TotalPrice";
            this.Label_TotalPrice.Size = new System.Drawing.Size(149, 29);
            this.Label_TotalPrice.TabIndex = 45;
            this.Label_TotalPrice.Text = "TOTAL PRICE: ";
            // 
            // panel_Card
            // 
            this.panel_Card.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panel_Card.Controls.Add(this.label_Card_Phone);
            this.panel_Card.Controls.Add(this.label_Card_Email);
            this.panel_Card.Controls.Add(this.label_Card_Name);
            this.panel_Card.Controls.Add(this.label_Card_Card);
            this.panel_Card.Controls.Add(this.textBox_Card_Email);
            this.panel_Card.Controls.Add(this.textBox_Card_Phone);
            this.panel_Card.Controls.Add(this.textBox_Card_Name);
            this.panel_Card.Controls.Add(this.textBox_Card_CardNum);
            this.panel_Card.Controls.Add(this.label_Card_Selected);
            this.panel_Card.Controls.Add(this.button_Card_Pay);
            this.panel_Card.Controls.Add(this.label_Card_TitleForm);
            this.panel_Card.Location = new System.Drawing.Point(38, 191);
            this.panel_Card.Name = "panel_Card";
            this.panel_Card.Size = new System.Drawing.Size(372, 262);
            this.panel_Card.TabIndex = 51;
            this.panel_Card.Visible = false;
            // 
            // label_Card_Phone
            // 
            this.label_Card_Phone.BackColor = System.Drawing.Color.Transparent;
            this.label_Card_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Card_Phone.ForeColor = System.Drawing.Color.White;
            this.label_Card_Phone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Card_Phone.Location = new System.Drawing.Point(-2, 139);
            this.label_Card_Phone.Name = "label_Card_Phone";
            this.label_Card_Phone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Card_Phone.Size = new System.Drawing.Size(118, 19);
            this.label_Card_Phone.TabIndex = 55;
            this.label_Card_Phone.Text = "Phone Number:";
            this.label_Card_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Card_Email
            // 
            this.label_Card_Email.BackColor = System.Drawing.Color.Transparent;
            this.label_Card_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Card_Email.ForeColor = System.Drawing.Color.White;
            this.label_Card_Email.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Card_Email.Location = new System.Drawing.Point(10, 172);
            this.label_Card_Email.Name = "label_Card_Email";
            this.label_Card_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Card_Email.Size = new System.Drawing.Size(106, 19);
            this.label_Card_Email.TabIndex = 54;
            this.label_Card_Email.Text = "Email:";
            this.label_Card_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Card_Name
            // 
            this.label_Card_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Card_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Card_Name.ForeColor = System.Drawing.Color.White;
            this.label_Card_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Card_Name.Location = new System.Drawing.Point(-12, 106);
            this.label_Card_Name.Name = "label_Card_Name";
            this.label_Card_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Card_Name.Size = new System.Drawing.Size(128, 19);
            this.label_Card_Name.TabIndex = 53;
            this.label_Card_Name.Text = "Full Name:";
            this.label_Card_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Card_Card
            // 
            this.label_Card_Card.BackColor = System.Drawing.Color.Transparent;
            this.label_Card_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Card_Card.ForeColor = System.Drawing.Color.White;
            this.label_Card_Card.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Card_Card.Location = new System.Drawing.Point(0, 75);
            this.label_Card_Card.Name = "label_Card_Card";
            this.label_Card_Card.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Card_Card.Size = new System.Drawing.Size(116, 19);
            this.label_Card_Card.TabIndex = 52;
            this.label_Card_Card.Text = "Card Number:";
            this.label_Card_Card.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Card_Email
            // 
            this.textBox_Card_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Card_Email.ForeColor = System.Drawing.Color.White;
            this.textBox_Card_Email.Location = new System.Drawing.Point(124, 169);
            this.textBox_Card_Email.Name = "textBox_Card_Email";
            this.textBox_Card_Email.Size = new System.Drawing.Size(183, 27);
            this.textBox_Card_Email.TabIndex = 51;
            // 
            // textBox_Card_Phone
            // 
            this.textBox_Card_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Card_Phone.ForeColor = System.Drawing.Color.White;
            this.textBox_Card_Phone.Location = new System.Drawing.Point(124, 136);
            this.textBox_Card_Phone.Name = "textBox_Card_Phone";
            this.textBox_Card_Phone.Size = new System.Drawing.Size(183, 27);
            this.textBox_Card_Phone.TabIndex = 50;
            // 
            // textBox_Card_Name
            // 
            this.textBox_Card_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Card_Name.ForeColor = System.Drawing.Color.White;
            this.textBox_Card_Name.Location = new System.Drawing.Point(124, 103);
            this.textBox_Card_Name.Name = "textBox_Card_Name";
            this.textBox_Card_Name.Size = new System.Drawing.Size(183, 27);
            this.textBox_Card_Name.TabIndex = 49;
            // 
            // textBox_Card_CardNum
            // 
            this.textBox_Card_CardNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Card_CardNum.ForeColor = System.Drawing.Color.White;
            this.textBox_Card_CardNum.Location = new System.Drawing.Point(124, 70);
            this.textBox_Card_CardNum.Name = "textBox_Card_CardNum";
            this.textBox_Card_CardNum.Size = new System.Drawing.Size(183, 27);
            this.textBox_Card_CardNum.TabIndex = 48;
            // 
            // label_Card_Selected
            // 
            this.label_Card_Selected.AutoSize = true;
            this.label_Card_Selected.BackColor = System.Drawing.Color.Transparent;
            this.label_Card_Selected.ForeColor = System.Drawing.Color.White;
            this.label_Card_Selected.Location = new System.Drawing.Point(6, 5);
            this.label_Card_Selected.Name = "label_Card_Selected";
            this.label_Card_Selected.Size = new System.Drawing.Size(196, 19);
            this.label_Card_Selected.TabIndex = 47;
            this.label_Card_Selected.Text = "Selected: [Credit/Debit Card]";
            // 
            // button_Card_Pay
            // 
            this.button_Card_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.button_Card_Pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Card_Pay.FlatAppearance.BorderSize = 0;
            this.button_Card_Pay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_Card_Pay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_Card_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Card_Pay.Font = new System.Drawing.Font("Calibri", 14F);
            this.button_Card_Pay.ForeColor = System.Drawing.Color.White;
            this.button_Card_Pay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Card_Pay.Location = new System.Drawing.Point(124, 208);
            this.button_Card_Pay.Name = "button_Card_Pay";
            this.button_Card_Pay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Card_Pay.Size = new System.Drawing.Size(183, 36);
            this.button_Card_Pay.TabIndex = 46;
            this.button_Card_Pay.Text = "PAY";
            this.button_Card_Pay.UseVisualStyleBackColor = false;
            this.button_Card_Pay.Click += new System.EventHandler(this.button_Card_Pay_Click);
            // 
            // label_Card_TitleForm
            // 
            this.label_Card_TitleForm.AutoSize = true;
            this.label_Card_TitleForm.BackColor = System.Drawing.Color.Transparent;
            this.label_Card_TitleForm.ForeColor = System.Drawing.Color.White;
            this.label_Card_TitleForm.Location = new System.Drawing.Point(120, 45);
            this.label_Card_TitleForm.Name = "label_Card_TitleForm";
            this.label_Card_TitleForm.Size = new System.Drawing.Size(96, 19);
            this.label_Card_TitleForm.TabIndex = 0;
            this.label_Card_TitleForm.Text = "Fill The Form:";
            // 
            // button_Cash
            // 
            this.button_Cash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.button_Cash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cash.FlatAppearance.BorderSize = 0;
            this.button_Cash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Cash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cash.Font = new System.Drawing.Font("Calibri", 18F);
            this.button_Cash.ForeColor = System.Drawing.Color.White;
            this.button_Cash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cash.Location = new System.Drawing.Point(227, 91);
            this.button_Cash.Name = "button_Cash";
            this.button_Cash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Cash.Size = new System.Drawing.Size(183, 71);
            this.button_Cash.TabIndex = 50;
            this.button_Cash.Text = "CASH";
            this.button_Cash.UseVisualStyleBackColor = false;
            this.button_Cash.Click += new System.EventHandler(this.button_Cash_Click);
            // 
            // button_Card
            // 
            this.button_Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.button_Card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Card.FlatAppearance.BorderSize = 0;
            this.button_Card.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Card.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Card.Font = new System.Drawing.Font("Calibri", 18F);
            this.button_Card.ForeColor = System.Drawing.Color.White;
            this.button_Card.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Card.Location = new System.Drawing.Point(38, 91);
            this.button_Card.Name = "button_Card";
            this.button_Card.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Card.Size = new System.Drawing.Size(183, 71);
            this.button_Card.TabIndex = 49;
            this.button_Card.Text = "CREDIT/DEBIT CARD";
            this.button_Card.UseVisualStyleBackColor = false;
            this.button_Card.Click += new System.EventHandler(this.button_Card_Click);
            // 
            // panel_Cash
            // 
            this.panel_Cash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Cash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panel_Cash.Controls.Add(this.label_Cash_Phone);
            this.panel_Cash.Controls.Add(this.label_Cash_Email);
            this.panel_Cash.Controls.Add(this.label_Cash_Name);
            this.panel_Cash.Controls.Add(this.textBox_Cash_Email);
            this.panel_Cash.Controls.Add(this.textBox_Cash_Phone);
            this.panel_Cash.Controls.Add(this.textBox_Cash_Name);
            this.panel_Cash.Controls.Add(this.label_Cash_Selected);
            this.panel_Cash.Controls.Add(this.button_Cash_Completed);
            this.panel_Cash.Controls.Add(this.label_Cash_TitleForm);
            this.panel_Cash.Location = new System.Drawing.Point(38, 191);
            this.panel_Cash.Name = "panel_Cash";
            this.panel_Cash.Size = new System.Drawing.Size(372, 236);
            this.panel_Cash.TabIndex = 56;
            this.panel_Cash.Visible = false;
            // 
            // label_Cash_Phone
            // 
            this.label_Cash_Phone.BackColor = System.Drawing.Color.Transparent;
            this.label_Cash_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Cash_Phone.ForeColor = System.Drawing.Color.White;
            this.label_Cash_Phone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Cash_Phone.Location = new System.Drawing.Point(-2, 111);
            this.label_Cash_Phone.Name = "label_Cash_Phone";
            this.label_Cash_Phone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Cash_Phone.Size = new System.Drawing.Size(118, 19);
            this.label_Cash_Phone.TabIndex = 55;
            this.label_Cash_Phone.Text = "Phone Number:";
            this.label_Cash_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Cash_Email
            // 
            this.label_Cash_Email.BackColor = System.Drawing.Color.Transparent;
            this.label_Cash_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Cash_Email.ForeColor = System.Drawing.Color.White;
            this.label_Cash_Email.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Cash_Email.Location = new System.Drawing.Point(10, 144);
            this.label_Cash_Email.Name = "label_Cash_Email";
            this.label_Cash_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Cash_Email.Size = new System.Drawing.Size(106, 19);
            this.label_Cash_Email.TabIndex = 54;
            this.label_Cash_Email.Text = "Email:";
            this.label_Cash_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Cash_Name
            // 
            this.label_Cash_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Cash_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Cash_Name.ForeColor = System.Drawing.Color.White;
            this.label_Cash_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Cash_Name.Location = new System.Drawing.Point(-12, 78);
            this.label_Cash_Name.Name = "label_Cash_Name";
            this.label_Cash_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Cash_Name.Size = new System.Drawing.Size(128, 19);
            this.label_Cash_Name.TabIndex = 53;
            this.label_Cash_Name.Text = "Full Name:";
            this.label_Cash_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Cash_Email
            // 
            this.textBox_Cash_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Cash_Email.ForeColor = System.Drawing.Color.White;
            this.textBox_Cash_Email.Location = new System.Drawing.Point(124, 141);
            this.textBox_Cash_Email.Name = "textBox_Cash_Email";
            this.textBox_Cash_Email.Size = new System.Drawing.Size(183, 27);
            this.textBox_Cash_Email.TabIndex = 51;
            // 
            // textBox_Cash_Phone
            // 
            this.textBox_Cash_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Cash_Phone.ForeColor = System.Drawing.Color.White;
            this.textBox_Cash_Phone.Location = new System.Drawing.Point(124, 108);
            this.textBox_Cash_Phone.Name = "textBox_Cash_Phone";
            this.textBox_Cash_Phone.Size = new System.Drawing.Size(183, 27);
            this.textBox_Cash_Phone.TabIndex = 50;
            // 
            // textBox_Cash_Name
            // 
            this.textBox_Cash_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Cash_Name.ForeColor = System.Drawing.Color.White;
            this.textBox_Cash_Name.Location = new System.Drawing.Point(124, 75);
            this.textBox_Cash_Name.Name = "textBox_Cash_Name";
            this.textBox_Cash_Name.Size = new System.Drawing.Size(183, 27);
            this.textBox_Cash_Name.TabIndex = 49;
            // 
            // label_Cash_Selected
            // 
            this.label_Cash_Selected.AutoSize = true;
            this.label_Cash_Selected.BackColor = System.Drawing.Color.Transparent;
            this.label_Cash_Selected.ForeColor = System.Drawing.Color.White;
            this.label_Cash_Selected.Location = new System.Drawing.Point(6, 5);
            this.label_Cash_Selected.Name = "label_Cash_Selected";
            this.label_Cash_Selected.Size = new System.Drawing.Size(114, 19);
            this.label_Cash_Selected.TabIndex = 47;
            this.label_Cash_Selected.Text = "Selected: [Cash]";
            // 
            // button_Cash_Completed
            // 
            this.button_Cash_Completed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.button_Cash_Completed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cash_Completed.FlatAppearance.BorderSize = 0;
            this.button_Cash_Completed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_Cash_Completed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_Cash_Completed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cash_Completed.Font = new System.Drawing.Font("Calibri", 14F);
            this.button_Cash_Completed.ForeColor = System.Drawing.Color.White;
            this.button_Cash_Completed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Cash_Completed.Location = new System.Drawing.Point(124, 180);
            this.button_Cash_Completed.Name = "button_Cash_Completed";
            this.button_Cash_Completed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Cash_Completed.Size = new System.Drawing.Size(183, 36);
            this.button_Cash_Completed.TabIndex = 46;
            this.button_Cash_Completed.Text = "COMPLETE";
            this.button_Cash_Completed.UseVisualStyleBackColor = false;
            this.button_Cash_Completed.Click += new System.EventHandler(this.button_Cash_Pay_Click);
            // 
            // label_Cash_TitleForm
            // 
            this.label_Cash_TitleForm.AutoSize = true;
            this.label_Cash_TitleForm.BackColor = System.Drawing.Color.Transparent;
            this.label_Cash_TitleForm.ForeColor = System.Drawing.Color.White;
            this.label_Cash_TitleForm.Location = new System.Drawing.Point(120, 45);
            this.label_Cash_TitleForm.Name = "label_Cash_TitleForm";
            this.label_Cash_TitleForm.Size = new System.Drawing.Size(96, 19);
            this.label_Cash_TitleForm.TabIndex = 0;
            this.label_Cash_TitleForm.Text = "Fill The Form:";
            // 
            // Tickets_ThirdPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 612);
            this.Controls.Add(this.panel_Cash);
            this.Controls.Add(this.panel_Card);
            this.Controls.Add(this.button_Cash);
            this.Controls.Add(this.button_Card);
            this.Controls.Add(this.label_TotalPriceSum);
            this.Controls.Add(this.Label_TotalPrice);
            this.Controls.Add(this.panel_Bottom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Tickets_ThirdPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tickets_ThirdPage_Load);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.panel_Card.ResumeLayout(false);
            this.panel_Card.PerformLayout();
            this.panel_Cash.ResumeLayout(false);
            this.panel_Cash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.Label label_TotalPriceSum;
        private System.Windows.Forms.Label Label_TotalPrice;
        private System.Windows.Forms.Panel panel_Card;
        private System.Windows.Forms.Label label_Card_Phone;
        private System.Windows.Forms.Label label_Card_Email;
        private System.Windows.Forms.Label label_Card_Name;
        private System.Windows.Forms.Label label_Card_Card;
        private System.Windows.Forms.TextBox textBox_Card_Email;
        private System.Windows.Forms.TextBox textBox_Card_Phone;
        private System.Windows.Forms.TextBox textBox_Card_Name;
        private System.Windows.Forms.TextBox textBox_Card_CardNum;
        private System.Windows.Forms.Label label_Card_Selected;
        private System.Windows.Forms.Button button_Card_Pay;
        private System.Windows.Forms.Label label_Card_TitleForm;
        private System.Windows.Forms.Button button_Cash;
        private System.Windows.Forms.Button button_Card;
        private System.Windows.Forms.Panel panel_Cash;
        private System.Windows.Forms.Label label_Cash_Phone;
        private System.Windows.Forms.Label label_Cash_Email;
        private System.Windows.Forms.Label label_Cash_Name;
        private System.Windows.Forms.TextBox textBox_Cash_Email;
        private System.Windows.Forms.TextBox textBox_Cash_Phone;
        private System.Windows.Forms.TextBox textBox_Cash_Name;
        private System.Windows.Forms.Label label_Cash_Selected;
        private System.Windows.Forms.Button button_Cash_Completed;
        private System.Windows.Forms.Label label_Cash_TitleForm;
    }
}