using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Employee
{
    public partial class Office : Form
    {
        public Office()
        {
            InitializeComponent();
        }

        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(45, 45, 45);
            this.BackColor = Color.FromArgb(18, 18, 18);
            pictureBox_Backgrnd.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\csdark.png")));
        }
        public void changeToGreek()
        {
            this.Text = "The Duck Cinema - Πρόσβαση Για Προσωπικό";
            button_Help.Text = "Βοήθεια";
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formMenu = new Main_Menu_Form();
            formMenu.Closed += (s, args) => this.Close();
            formMenu.Show();
        }

        private void Office_Load(object sender, EventArgs e)
        {
            pictureBox_Lights.Parent = pictureBox_Backgrnd;
            pictureBox_Lights.BackColor = Color.Transparent;
            pictureBox_Devices.Parent = pictureBox_Backgrnd;
            pictureBox_Devices.BackColor = Color.Transparent;
            pictureBox_Vacuum.Parent = pictureBox_Backgrnd;
            pictureBox_Vacuum.BackColor = Color.Transparent;

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

        private void pictureBox_Lights_Click(object sender, EventArgs e)
        {
            LightManager lightManager = new LightManager();
            lightManager.ShowDialog();
        }

        private void pictureBox_Lights_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Lights.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\Lights-On.png")));
        }

        private void pictureBox_Lights_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Lights.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Lights.png")));
        }

        private void pictureBox_Devices_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Devices.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\Devices-Active.png")));

        }

        private void pictureBox_Devices_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Devices.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Devices.png")));

        }

        private void pictureBox_Devices_Click(object sender, EventArgs e)
        {
            DevicesManager devicesManager = new DevicesManager();
            devicesManager.ShowDialog();
        }

        private void pictureBox_Vacuum_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Vacuum.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\Robot-Active.png")));
        }

        private void pictureBox_Vacuum_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Vacuum.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Robot.png")));
        }

        private void pictureBox_Vacuum_Click(object sender, EventArgs e)
        {
            Vacuum_FirstPage vacuum_FirstPage = new Vacuum_FirstPage();
            vacuum_FirstPage.ShowDialog();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\EmployeeGuide.chm");
        }
    }
}
