using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Customer
{
    public partial class Menu_SecondPage : Form
    {
        public string MsgBoxReserveFailed = "Please fill all the form fields!";
        public string MsgBoxReserveCompleted = "Transaction was completed successfully!\nA receipt has been send to your email.";
        public string MsgBoxPayNow = "You have given the required money to the employer.\nThe process is completed!";

        private Form Menu_FirstPage;
        public Menu_SecondPage(Form formMenuFirstPage)
        {
            InitializeComponent();
            this.Menu_FirstPage = formMenuFirstPage;
            formMenuFirstPage.Hide();
        }

        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
            panel_PayNow.BackColor = Color.FromArgb(18, 18, 18);
            panel_Reserve.BackColor = Color.FromArgb(18, 18, 18);
            textBox_CardNum.BackColor = Color.FromArgb(45, 45, 45);
            textBox_Email.BackColor = Color.FromArgb(45, 45, 45);
            textBox_Name.BackColor = Color.FromArgb(45, 45, 45);
            textBox_Phone.BackColor = Color.FromArgb(45, 45, 45);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            Label_TotalPrice.Text = "ΣΥΝΟΛΙΚΗ ΤΙΜΗ:  €";
            button_Reserve.Text = "ΚΡΑΤΗΣΗ ΠΡΟΪΟΝΤΩΝ";
            button_Pay.Text = "ΠΛΗΡΩΣΤΕ ΤΩΡΑ";
            MsgBoxReserveFailed = "Παρακαλώ συμπληρώστε όλα τα πεδία της φόρμας!";
            MsgBoxReserveCompleted = "Η συναλλαγή έχει ολοκληρωθεί επιτυχώς!\nΗ απόδειξη έχει σταλθεί στην ηλεκτρονική σας διεύθυνση.";
            MsgBoxPayNow = "Δώσατε τα χρήματα στον υπάλληλο.\nΗ διαδικασία έχει ολοκληρωθεί!";

            //Reserve
            label_Reserve_Selected.Text = "Επιλέξατε: [Κράτηση Προϊόντων]";
            label_Reserve_TitleForm.Text = "Συμπληρώστε Την Φόρμα:";
            button_Reserve_Form_Complete.Text = "ΚΡΑΤΗΣΗ";
            label_Phone.Text = "Τηλέφωνο:";
            label_Name.Text = "Ον/νυμο:";
            label_Card.Text = "Αρ. Κάρτας";

            //PayNow
            label_PayNow_SelectPayment.Text = "Επιλέξτε τρόπο πληρωμής:";
            label_Selected.Text = "Επιλέξατε: [Πληρωμή Τώρα]";
            button_PayNow_Card.Text = "ΚΑΡΤΑ";
            button_PayNow_Cash.Text = "ΜΕΤΡΗΤΑ";
        }

        
        private void Menu_SecondPage_Load(object sender, EventArgs e)
        {
            Cursor newCursor = new Cursor(@"cursor_hand.cur");
            this.Cursor = newCursor;

            string path = "Settings.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine("English");
                    tw.WriteLine("Light");
                    tw.Close();
                }
            }
            var lines = File.ReadAllLines("Settings.txt");
            if (lines[0].ToLower().Equals("greek"))
            {
                changeToGreek();
            }
            if (lines[1].ToLower().Equals("dark"))
            {
                changeToDark();
            }
            label_TotalPriceSum.Text = "€" + lines[2];
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            Menu_FirstPage.Show();
            this.Close();
        }

        private void button_Reserve_Form_Complete_Click(object sender, EventArgs e)
        {
            if ((textBox_CardNum.Text == "") || 
                (textBox_Name.Text == "") ||
                (textBox_Email.Text == "") ||
                (textBox_Phone.Text == ""))
            {
                MessageBox.Show(MsgBoxReserveFailed, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show(MsgBoxReserveCompleted, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
                Menu_FirstPage.Dispose();
            }
        }

        public bool togglePayNow = false;
        public bool toggleReserve = false;
        private void button_Pay_Click(object sender, EventArgs e)
        {
            if (togglePayNow == false)
            {
                togglePayNow = true;
                panel_PayNow.Visible = true;
                panel_Reserve.Visible = false;
                toggleReserve = false;
            }
            else
            {
                togglePayNow = false;
                panel_PayNow.Visible = false;
            }
        }

        private void button_Reserve_Click(object sender, EventArgs e)
        {
            if (toggleReserve == false)
            {
                toggleReserve = true;
                panel_Reserve.Visible = true;
                panel_PayNow.Visible = false;
                togglePayNow = false;
            }
            else
            {
                toggleReserve = false;
                panel_Reserve.Visible = false;
            }
        }

        private void button_PayNow_Card_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_SecondPagePOS menu_SecondPagePOS = new Menu_SecondPagePOS();
            menu_SecondPagePOS.ShowDialog();
        }

        private void button_PayNow_Cash_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(MsgBoxPayNow, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
                Menu_FirstPage.Dispose();
            }
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\CustomerGuide.chm", HelpNavigator.TopicId, "14");
        }
    }
}
