namespace TheDuckCinema.Forms.Customer
{
    partial class Menu_SecondPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_SecondPage));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.imageList_Buttons = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.Label_TotalPrice = new System.Windows.Forms.Label();
            this.button_Reserve = new System.Windows.Forms.Button();
            this.button_Pay = new System.Windows.Forms.Button();
            this.label_TotalPriceSum = new System.Windows.Forms.Label();
            this.panel_PayNow = new System.Windows.Forms.Panel();
            this.label_Selected = new System.Windows.Forms.Label();
            this.button_PayNow_Cash = new System.Windows.Forms.Button();
            this.button_PayNow_Card = new System.Windows.Forms.Button();
            this.label_PayNow_SelectPayment = new System.Windows.Forms.Label();
            this.panel_Reserve = new System.Windows.Forms.Panel();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Card = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_CardNum = new System.Windows.Forms.TextBox();
            this.label_Reserve_Selected = new System.Windows.Forms.Label();
            this.button_Reserve_Form_Complete = new System.Windows.Forms.Button();
            this.label_Reserve_TitleForm = new System.Windows.Forms.Label();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.panel_PayNow.SuspendLayout();
            this.panel_Reserve.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.panel_Bottom.Controls.Add(this.button_Help);
            this.panel_Bottom.Controls.Add(this.pictureBox_Back);
            this.panel_Bottom.Location = new System.Drawing.Point(-2, 708);
            this.panel_Bottom.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(454, 136);
            this.panel_Bottom.TabIndex = 12;
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
            // Label_TotalPrice
            // 
            this.Label_TotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_TotalPrice.AutoSize = true;
            this.Label_TotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.Label_TotalPrice.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalPrice.ForeColor = System.Drawing.Color.White;
            this.Label_TotalPrice.Location = new System.Drawing.Point(94, 208);
            this.Label_TotalPrice.Name = "Label_TotalPrice";
            this.Label_TotalPrice.Size = new System.Drawing.Size(149, 29);
            this.Label_TotalPrice.TabIndex = 41;
            this.Label_TotalPrice.Text = "TOTAL PRICE: ";
            // 
            // button_Reserve
            // 
            this.button_Reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.button_Reserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Reserve.FlatAppearance.BorderSize = 0;
            this.button_Reserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Reserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reserve.Font = new System.Drawing.Font("Calibri", 18F);
            this.button_Reserve.ForeColor = System.Drawing.Color.White;
            this.button_Reserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Reserve.Location = new System.Drawing.Point(29, 259);
            this.button_Reserve.Name = "button_Reserve";
            this.button_Reserve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Reserve.Size = new System.Drawing.Size(183, 71);
            this.button_Reserve.TabIndex = 42;
            this.button_Reserve.Text = "RESERVE THE PRODUCTS";
            this.button_Reserve.UseVisualStyleBackColor = false;
            this.button_Reserve.Click += new System.EventHandler(this.button_Reserve_Click);
            // 
            // button_Pay
            // 
            this.button_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.button_Pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Pay.FlatAppearance.BorderSize = 0;
            this.button_Pay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Pay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(169)))));
            this.button_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pay.Font = new System.Drawing.Font("Calibri", 18F);
            this.button_Pay.ForeColor = System.Drawing.Color.White;
            this.button_Pay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Pay.Location = new System.Drawing.Point(218, 259);
            this.button_Pay.Name = "button_Pay";
            this.button_Pay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Pay.Size = new System.Drawing.Size(183, 71);
            this.button_Pay.TabIndex = 43;
            this.button_Pay.Text = "PAY NOW";
            this.button_Pay.UseVisualStyleBackColor = false;
            this.button_Pay.Click += new System.EventHandler(this.button_Pay_Click);
            // 
            // label_TotalPriceSum
            // 
            this.label_TotalPriceSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_TotalPriceSum.AutoSize = true;
            this.label_TotalPriceSum.BackColor = System.Drawing.Color.Transparent;
            this.label_TotalPriceSum.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalPriceSum.ForeColor = System.Drawing.Color.White;
            this.label_TotalPriceSum.Location = new System.Drawing.Point(267, 208);
            this.label_TotalPriceSum.Name = "label_TotalPriceSum";
            this.label_TotalPriceSum.Size = new System.Drawing.Size(37, 29);
            this.label_TotalPriceSum.TabIndex = 44;
            this.label_TotalPriceSum.Text = "€0";
            // 
            // panel_PayNow
            // 
            this.panel_PayNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_PayNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panel_PayNow.Controls.Add(this.label_Selected);
            this.panel_PayNow.Controls.Add(this.button_PayNow_Cash);
            this.panel_PayNow.Controls.Add(this.button_PayNow_Card);
            this.panel_PayNow.Controls.Add(this.label_PayNow_SelectPayment);
            this.panel_PayNow.Location = new System.Drawing.Point(29, 359);
            this.panel_PayNow.Name = "panel_PayNow";
            this.panel_PayNow.Size = new System.Drawing.Size(372, 167);
            this.panel_PayNow.TabIndex = 16;
            this.panel_PayNow.Visible = false;
            // 
            // label_Selected
            // 
            this.label_Selected.AutoSize = true;
            this.label_Selected.BackColor = System.Drawing.Color.Transparent;
            this.label_Selected.ForeColor = System.Drawing.Color.White;
            this.label_Selected.Location = new System.Drawing.Point(6, 5);
            this.label_Selected.Name = "label_Selected";
            this.label_Selected.Size = new System.Drawing.Size(138, 19);
            this.label_Selected.TabIndex = 47;
            this.label_Selected.Text = "Selected: [Pay Now]";
            // 
            // button_PayNow_Cash
            // 
            this.button_PayNow_Cash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.button_PayNow_Cash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_PayNow_Cash.FlatAppearance.BorderSize = 0;
            this.button_PayNow_Cash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_PayNow_Cash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_PayNow_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PayNow_Cash.Font = new System.Drawing.Font("Calibri", 14F);
            this.button_PayNow_Cash.ForeColor = System.Drawing.Color.White;
            this.button_PayNow_Cash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PayNow_Cash.Location = new System.Drawing.Point(96, 117);
            this.button_PayNow_Cash.Name = "button_PayNow_Cash";
            this.button_PayNow_Cash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_PayNow_Cash.Size = new System.Drawing.Size(183, 36);
            this.button_PayNow_Cash.TabIndex = 46;
            this.button_PayNow_Cash.Text = "Cash";
            this.button_PayNow_Cash.UseVisualStyleBackColor = false;
            this.button_PayNow_Cash.Click += new System.EventHandler(this.button_PayNow_Cash_Click);
            // 
            // button_PayNow_Card
            // 
            this.button_PayNow_Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.button_PayNow_Card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_PayNow_Card.FlatAppearance.BorderSize = 0;
            this.button_PayNow_Card.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_PayNow_Card.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_PayNow_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PayNow_Card.Font = new System.Drawing.Font("Calibri", 14F);
            this.button_PayNow_Card.ForeColor = System.Drawing.Color.White;
            this.button_PayNow_Card.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PayNow_Card.Location = new System.Drawing.Point(96, 75);
            this.button_PayNow_Card.Name = "button_PayNow_Card";
            this.button_PayNow_Card.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_PayNow_Card.Size = new System.Drawing.Size(183, 36);
            this.button_PayNow_Card.TabIndex = 45;
            this.button_PayNow_Card.Text = "Credit/Debit Card";
            this.button_PayNow_Card.UseVisualStyleBackColor = false;
            this.button_PayNow_Card.Click += new System.EventHandler(this.button_PayNow_Card_Click);
            // 
            // label_PayNow_SelectPayment
            // 
            this.label_PayNow_SelectPayment.AutoSize = true;
            this.label_PayNow_SelectPayment.BackColor = System.Drawing.Color.Transparent;
            this.label_PayNow_SelectPayment.ForeColor = System.Drawing.Color.White;
            this.label_PayNow_SelectPayment.Location = new System.Drawing.Point(106, 45);
            this.label_PayNow_SelectPayment.Name = "label_PayNow_SelectPayment";
            this.label_PayNow_SelectPayment.Size = new System.Drawing.Size(157, 19);
            this.label_PayNow_SelectPayment.TabIndex = 0;
            this.label_PayNow_SelectPayment.Text = "Select payment option:";
            // 
            // panel_Reserve
            // 
            this.panel_Reserve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panel_Reserve.Controls.Add(this.label_Phone);
            this.panel_Reserve.Controls.Add(this.label_Email);
            this.panel_Reserve.Controls.Add(this.label_Name);
            this.panel_Reserve.Controls.Add(this.label_Card);
            this.panel_Reserve.Controls.Add(this.textBox_Email);
            this.panel_Reserve.Controls.Add(this.textBox_Phone);
            this.panel_Reserve.Controls.Add(this.textBox_Name);
            this.panel_Reserve.Controls.Add(this.textBox_CardNum);
            this.panel_Reserve.Controls.Add(this.label_Reserve_Selected);
            this.panel_Reserve.Controls.Add(this.button_Reserve_Form_Complete);
            this.panel_Reserve.Controls.Add(this.label_Reserve_TitleForm);
            this.panel_Reserve.Location = new System.Drawing.Point(29, 359);
            this.panel_Reserve.Name = "panel_Reserve";
            this.panel_Reserve.Size = new System.Drawing.Size(372, 262);
            this.panel_Reserve.TabIndex = 48;
            this.panel_Reserve.Visible = false;
            // 
            // label_Phone
            // 
            this.label_Phone.BackColor = System.Drawing.Color.Transparent;
            this.label_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Phone.ForeColor = System.Drawing.Color.White;
            this.label_Phone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Phone.Location = new System.Drawing.Point(-2, 139);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Phone.Size = new System.Drawing.Size(118, 19);
            this.label_Phone.TabIndex = 55;
            this.label_Phone.Text = "Phone Number:";
            this.label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Email
            // 
            this.label_Email.BackColor = System.Drawing.Color.Transparent;
            this.label_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Email.ForeColor = System.Drawing.Color.White;
            this.label_Email.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Email.Location = new System.Drawing.Point(10, 172);
            this.label_Email.Name = "label_Email";
            this.label_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Email.Size = new System.Drawing.Size(106, 19);
            this.label_Email.TabIndex = 54;
            this.label_Email.Text = "Email:";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Name
            // 
            this.label_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Name.Location = new System.Drawing.Point(-12, 106);
            this.label_Name.Name = "label_Name";
            this.label_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Name.Size = new System.Drawing.Size(128, 19);
            this.label_Name.TabIndex = 53;
            this.label_Name.Text = "Full Name:";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Card
            // 
            this.label_Card.BackColor = System.Drawing.Color.Transparent;
            this.label_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Card.ForeColor = System.Drawing.Color.White;
            this.label_Card.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Card.Location = new System.Drawing.Point(0, 75);
            this.label_Card.Name = "label_Card";
            this.label_Card.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Card.Size = new System.Drawing.Size(116, 19);
            this.label_Card.TabIndex = 52;
            this.label_Card.Text = "Card Number:";
            this.label_Card.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Email.ForeColor = System.Drawing.Color.White;
            this.textBox_Email.Location = new System.Drawing.Point(124, 169);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(183, 27);
            this.textBox_Email.TabIndex = 51;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Phone.ForeColor = System.Drawing.Color.White;
            this.textBox_Phone.Location = new System.Drawing.Point(124, 136);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(183, 27);
            this.textBox_Phone.TabIndex = 50;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_Name.ForeColor = System.Drawing.Color.White;
            this.textBox_Name.Location = new System.Drawing.Point(124, 103);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(183, 27);
            this.textBox_Name.TabIndex = 49;
            // 
            // textBox_CardNum
            // 
            this.textBox_CardNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.textBox_CardNum.ForeColor = System.Drawing.Color.White;
            this.textBox_CardNum.Location = new System.Drawing.Point(124, 70);
            this.textBox_CardNum.Name = "textBox_CardNum";
            this.textBox_CardNum.Size = new System.Drawing.Size(183, 27);
            this.textBox_CardNum.TabIndex = 48;
            // 
            // label_Reserve_Selected
            // 
            this.label_Reserve_Selected.AutoSize = true;
            this.label_Reserve_Selected.BackColor = System.Drawing.Color.Transparent;
            this.label_Reserve_Selected.ForeColor = System.Drawing.Color.White;
            this.label_Reserve_Selected.Location = new System.Drawing.Point(6, 5);
            this.label_Reserve_Selected.Name = "label_Reserve_Selected";
            this.label_Reserve_Selected.Size = new System.Drawing.Size(222, 19);
            this.label_Reserve_Selected.TabIndex = 47;
            this.label_Reserve_Selected.Text = "Selected: [Reserve The Products]";
            // 
            // button_Reserve_Form_Complete
            // 
            this.button_Reserve_Form_Complete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.button_Reserve_Form_Complete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Reserve_Form_Complete.FlatAppearance.BorderSize = 0;
            this.button_Reserve_Form_Complete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_Reserve_Form_Complete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_Reserve_Form_Complete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reserve_Form_Complete.Font = new System.Drawing.Font("Calibri", 14F);
            this.button_Reserve_Form_Complete.ForeColor = System.Drawing.Color.White;
            this.button_Reserve_Form_Complete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Reserve_Form_Complete.Location = new System.Drawing.Point(124, 208);
            this.button_Reserve_Form_Complete.Name = "button_Reserve_Form_Complete";
            this.button_Reserve_Form_Complete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Reserve_Form_Complete.Size = new System.Drawing.Size(183, 36);
            this.button_Reserve_Form_Complete.TabIndex = 46;
            this.button_Reserve_Form_Complete.Text = "RESERVE";
            this.button_Reserve_Form_Complete.UseVisualStyleBackColor = false;
            this.button_Reserve_Form_Complete.Click += new System.EventHandler(this.button_Reserve_Form_Complete_Click);
            // 
            // label_Reserve_TitleForm
            // 
            this.label_Reserve_TitleForm.AutoSize = true;
            this.label_Reserve_TitleForm.BackColor = System.Drawing.Color.Transparent;
            this.label_Reserve_TitleForm.ForeColor = System.Drawing.Color.White;
            this.label_Reserve_TitleForm.Location = new System.Drawing.Point(120, 45);
            this.label_Reserve_TitleForm.Name = "label_Reserve_TitleForm";
            this.label_Reserve_TitleForm.Size = new System.Drawing.Size(96, 19);
            this.label_Reserve_TitleForm.TabIndex = 0;
            this.label_Reserve_TitleForm.Text = "Fill The Form:";
            // 
            // Menu_SecondPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TheDuckCinema.Properties.Resources.Menu1;
            this.ClientSize = new System.Drawing.Size(439, 802);
            this.Controls.Add(this.panel_Reserve);
            this.Controls.Add(this.label_TotalPriceSum);
            this.Controls.Add(this.button_Pay);
            this.Controls.Add(this.button_Reserve);
            this.Controls.Add(this.Label_TotalPrice);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_PayNow);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_SecondPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_SecondPage_Load);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.panel_PayNow.ResumeLayout(false);
            this.panel_PayNow.PerformLayout();
            this.panel_Reserve.ResumeLayout(false);
            this.panel_Reserve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.ImageList imageList_Buttons;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Label Label_TotalPrice;
        private System.Windows.Forms.Button button_Reserve;
        private System.Windows.Forms.Button button_Pay;
        private System.Windows.Forms.Label label_TotalPriceSum;
        private System.Windows.Forms.Panel panel_PayNow;
        private System.Windows.Forms.Label label_PayNow_SelectPayment;
        private System.Windows.Forms.Button button_PayNow_Cash;
        private System.Windows.Forms.Button button_PayNow_Card;
        private System.Windows.Forms.Label label_Selected;
        private System.Windows.Forms.Panel panel_Reserve;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Card;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_CardNum;
        private System.Windows.Forms.Label label_Reserve_Selected;
        private System.Windows.Forms.Button button_Reserve_Form_Complete;
        private System.Windows.Forms.Label label_Reserve_TitleForm;
    }
}