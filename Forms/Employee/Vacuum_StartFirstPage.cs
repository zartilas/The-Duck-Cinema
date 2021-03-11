using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Employee
{
    public partial class Vacuum_StartFirstPage : Form
    {
        public bool toggleLights_Cinema1 = false;
        public bool toggleLights_Cinema2 = false;
        public bool toggleLights_Cinema3 = false;
        public bool toggleLights_Cinema4 = false;
        public bool toggleLights_Cinema5 = false;
        public bool toggleLights_Cinema6 = false;
        public bool toggleLights_Hall = false;
        public bool toggleLights_Office = false;
        public bool toggleLights_Paths = false;

        public Vacuum_StartFirstPage()
        {
            InitializeComponent();
        }
        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
            this.BackColor = Color.FromArgb(18,18,18);
            pictureBox_TopViewCinema.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\topviewcinemalight.png")));
            label_Hall.ForeColor = Color.White;
            label_Office.ForeColor = Color.White;
            label_Path.ForeColor = Color.White;
            label_Screen1.ForeColor = Color.White;
            label_Screen2.ForeColor = Color.White;
            label_Screen3.ForeColor = Color.White;
            label_Screen4.ForeColor = Color.White;
            label_Screen5.ForeColor = Color.White;
            label_Screen6.ForeColor = Color.White;
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            label_Hall.Text = "Προθάλαμος και\nΜπαρ";
            label_Office.Text = "Γραφείο";
            label_Path.Text = "Διάδρομος";
            label_Screen1.Text = "Αίθουσα 1";
            label_Screen2.Text = "Αίθουσα 2";
            label_Screen3.Text = "Αίθουσα 3";
            label_Screen4.Text = "Αίθουσα 4";
            label_Screen5.Text = "Αίθουσα 5";
            label_Screen6.Text = "Αίθουσα 6";
        }

        private void LightManager_Load(object sender, EventArgs e)
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

        private void buttons_Clean_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Vacuum_StartSecondPage vacuum_StartSecondPage = new Vacuum_StartSecondPage();
            vacuum_StartSecondPage.ShowDialog();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\EmployeeGuide.chm", HelpNavigator.TopicId, "9");
        }
    }
}
