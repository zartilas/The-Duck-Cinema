using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Employee
{
    public partial class Vacuum_FirstPage : Form
    {
        public Vacuum_FirstPage()
        {
            InitializeComponent();
        }

        public void changeToDark()
        {
            label_Title.ForeColor = Color.White;
            panel_Bottom.BackColor = Color.FromArgb(45, 45, 45);
            this.BackColor = Color.FromArgb(18, 18, 18);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            label_Title.Text = "ΣΚΟΥΠΑ-ΡΟΜΠΟΤ";
            button_History.Text = "ΙΣΤΟΡΙΚΟ ΚΑΘΑΡΙΣΜΑΤΟΣ";
            button_Start.Text = "ΕΚΚΙΝΗΣΗ ΚΑΘΑΡΙΣΜΑΤΟΣ";
            button_Notifications.Text = "(2) ΕΙΔΟΠΟΙΗΣΕΙΣ";
        }
        private void Vacuum_FirstPage_Load(object sender, EventArgs e)
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

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_History_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Vacuum_SecondPage vacuum_SecondPage = new Vacuum_SecondPage();
            vacuum_SecondPage.ShowDialog();
        }

        private void button_Notifications_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Vacuum_NotfPage vacuum_Notifications = new Vacuum_NotfPage();
            vacuum_Notifications.ShowDialog();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Vacuum_StartFirstPage vacuum_StartFirstPage = new Vacuum_StartFirstPage();
            vacuum_StartFirstPage.ShowDialog();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\EmployeeGuide.chm", HelpNavigator.TopicId, "0");
        }
    }
}
