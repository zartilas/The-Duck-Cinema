using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Employee
{
    public partial class Vacuum_SecondPage : Form
    {
        public Vacuum_SecondPage()
        {
            InitializeComponent();
        }

        public void changeToDark()
        {
            label_Title.ForeColor = Color.White;
            panel_Bottom.BackColor = Color.FromArgb(45, 45, 45);
            panel_Center.BackColor = Color.FromArgb(45, 45, 45);
            this.BackColor = Color.FromArgb(18, 18, 18);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            label_Title.Text = "ΙΣΤΟΡΙΚΟ ΚΑΘΑΡΙΣΜΑΤΟΣ";
            label_ListHeader.Text = "ID:        Αρ. Σκούπας:   Αίθουσα:    Ημ/νια:         Ώρα:";
        }
        private void Vacuum_SecondPage_Load(object sender, EventArgs e)
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
            this.Hide();
            this.Close();
            Vacuum_FirstPage vacuum_FirstPage = new Vacuum_FirstPage();
            vacuum_FirstPage.ShowDialog();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\EmployeeGuide.chm", HelpNavigator.TopicId, "2");
        }
    }
}
