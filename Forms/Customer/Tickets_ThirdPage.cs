using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Customer
{
    public partial class Tickets_ThirdPage : Form
    {
        public string MsgBoxFailed = "Please fill all the form fields!";
        public string MsgBoxCardPay = "Transaction was completed successfully!\nA receipt has been send to your email.";
        public string MsgBoxCashCompleted = "The process is completed!\nMore information will be send to your email.";

        public Tickets_ThirdPage()
        {
            InitializeComponent();
        }

        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
            this.BackColor = Color.FromArgb(18, 18, 18);
            Label_TotalPrice.ForeColor = Color.White;
            label_TotalPriceSum.ForeColor = Color.White;
            panel_Card.BackColor = Color.FromArgb(30, 30, 30);
            panel_Cash.BackColor = Color.FromArgb(30, 30, 30);

            textBox_Card_CardNum.BackColor = Color.FromArgb(45, 45, 45);
            textBox_Card_Email.BackColor = Color.FromArgb(45, 45, 45);
            textBox_Card_Name.BackColor = Color.FromArgb(45, 45, 45);
            textBox_Card_Phone.BackColor = Color.FromArgb(45, 45, 45);

            textBox_Cash_Email.BackColor = Color.FromArgb(45, 45, 45);
            textBox_Cash_Name.BackColor = Color.FromArgb(45, 45, 45);
            textBox_Cash_Phone.BackColor = Color.FromArgb(45, 45, 45);
        }

        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            Label_TotalPrice.Text = "ΣΥΝΟΛΙΚΗ ΤΙΜΗ: ";
            button_Card.Text = "ΚΑΡΤΑ";
            button_Cash.Text = "ΑΝΤΙΚΑΤΑΒΟΛΗ";
            MsgBoxFailed = "Παρακαλώ συμπληρώστε όλα τα πεδία της φόρμας!";
            MsgBoxCardPay = "Η συναλλαγή έχει ολοκληρωθεί επιτυχώς!\nΗ απόδειξη έχει σταλθεί στην ηλεκτρονική σας διεύθυνση.";
            MsgBoxCashCompleted = "Η διαδικασία έχει ολοκληρωθεί!\nΠερισσότερες προροφορίες εχουν σταλθεί στην ηλεκτρονική σας διεύθυνση.";

            //Card
            label_Card_TitleForm.Text = "Συμπληρώστε την Φόρμα:";
            label_Card_Selected.Text = "Επιλέξατε: [Πιστωτική/Χρεωστική Κάρτα]";
            button_Card_Pay.Text = "ΠΛΗΡΩΜΗ";
            label_Card_Card.Text = "Αρ. Κάρτας";
            label_Card_Name.Text = "Ον/νυμο:";
            label_Card_Phone.Text = "Τελεφωνο";

            //Cash
            label_Cash_TitleForm.Text = "Συμπληρώστε την Φόρμα:";
            button_Cash_Completed.Text = "ΟΛΟΚΛΗΡΩΣΗ";
            label_Cash_Name.Text = "Ον/νυμο:";
            label_Cash_Phone.Text = "Τελεφωνο";
            label_Cash_Selected.Text = "Επιλέξατε: [Αντικαταβολή]";
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Tickets_SecondPage formTicketsSecondPage = new Tickets_SecondPage();
            formTicketsSecondPage.ShowDialog();
        }

        private void Tickets_ThirdPage_Load(object sender, EventArgs e)
        {
            int sum = Tickets_SecondPage.countSeats * 10;
            label_TotalPriceSum.Text = "€" + sum.ToString();

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
        }

        public bool toggleCash = false;
        public bool toggleCard = false;
        private void button_Card_Click(object sender, EventArgs e)
        {
            if (toggleCard == false)
            {
                toggleCard = true;
                panel_Card.Visible = true;
                panel_Cash.Visible = false;
                toggleCash = false;
            }
            else
            {
                toggleCard = false;
                panel_Card.Visible = false;
            }
        }

        private void button_Cash_Click(object sender, EventArgs e)
        {
            if (toggleCash == false)
            {
                toggleCash = true;
                panel_Cash.Visible = true;
                panel_Card.Visible = false;
                toggleCard = false;
            }
            else
            {
                toggleCash = false;
                panel_Cash.Visible = false;
            }
        }

        private void button_Card_Pay_Click(object sender, EventArgs e)
        {
            if ((textBox_Card_Name.Text == "") ||
                (textBox_Card_Email.Text == "") ||
                (textBox_Card_Phone.Text == ""))
            {
                MessageBox.Show(MsgBoxFailed, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show(MsgBoxCardPay, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button_Cash_Pay_Click(object sender, EventArgs e)
        {
            if ((textBox_Cash_Name.Text == "") ||
                (textBox_Cash_Email.Text == "") ||
                (textBox_Cash_Phone.Text == ""))
            {
                MessageBox.Show(MsgBoxFailed, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show(MsgBoxCashCompleted, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\CustomerGuide.chm", HelpNavigator.TopicId, "3");
        }
    }
}
