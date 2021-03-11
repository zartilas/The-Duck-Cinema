using TheDuckCinema.Forms.Customer;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TheDuckCinema.Forms.Employee;

namespace TheDuckCinema
{
    public partial class Main_Menu_Form : Form
    {
        public void changeToDark()
        {
            panel_Left.BackColor = Color.FromArgb(30, 30, 30);
            panel_Bottom.BackColor = Color.FromArgb(45, 45, 45);

            button_Customer.ForeColor = Color.Black;
            button_Employee.ForeColor = Color.Black;

            this.BackColor = Color.FromArgb(18, 18, 18);
        }
        public void changeToGreek()
        {
            this.Text = "The Duck Cinema - Καλωσορίσατε!";
            label_Continue_As.Text = "Συνεχίστε ως:";
            button_Customer.Text = "ΠΕΛΑΤΗΣ";
            button_Employee.Text = "ΥΠΑΛΛΗΛΟΣ";
            button_Settings.Text = "Ρυθμίσεις";
            button_Help.Text = "Βοήθεια";
        }

        public Main_Menu_Form()
        {
            InitializeComponent();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formSettings = new Forms.Settings_Form();
            formSettings.Closed += (s, args) => this.Close();
            formSettings.Show();
        }

        private void Main_Menu_Form_Load(object sender, EventArgs e)
        {
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

        private void button_Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formHall = new Hall();
            formHall.Closed += (s, args) => this.Close();
            formHall.Show();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\GettingStarted.chm");
        }

        private void button_Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formOffice = new Office();
            formOffice.Closed += (s, args) => this.Close();
            formOffice.Show();
        }
    }
}
