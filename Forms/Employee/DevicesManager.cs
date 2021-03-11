using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Employee
{
    public partial class DevicesManager : Form
    {
        public bool toggleDevices_Printer = false;
        public bool toggleDevices_Cashier = false;
        public bool toggleDevices_Fridge = false;
        public bool toggleDevices_Coffee = false;

        public DevicesManager()
        {
            InitializeComponent();
        }
        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
            panel_Center.BackColor = Color.FromArgb(30, 30, 30);
            this.BackColor = Color.FromArgb(18,18,18);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            label_Title.Text = "ΣΥΣΚΕΥΕΣ";
            label_Cashier.Text = "Ταμειακές Μηχανές";
            label_Coffee.Text = "Μηχανές Καφέ";
            label_Fridge.Text = "Ψυγεία";
            label_Printer.Text = "Εκτυπωτές/Σαρωτές";
        }

        private void DevicesManager_Load(object sender, EventArgs e)
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

        private void pictureBox_Printer_Click(object sender, EventArgs e)
        {
            if (!toggleDevices_Printer)
            {
                pictureBox_Printer.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Printer-Not.png")));
                toggleDevices_Printer = true;
            }
            else
            {
                pictureBox_Printer.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Printer.png")));
                toggleDevices_Printer = false;
            }
        }

        private void pictureBox_Cashier_Click(object sender, EventArgs e)
        {
            if (!toggleDevices_Cashier)
            {
                pictureBox_Cashier.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Cashier-Not.png")));
                toggleDevices_Cashier = true;
            }
            else
            {
                pictureBox_Cashier.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Cashier.png")));
                toggleDevices_Cashier = false;
            }
        }

        private void pictureBox_Fridge_Click(object sender, EventArgs e)
        {
            if (!toggleDevices_Fridge)
            {
                pictureBox_Fridge.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Fridge-Not.png")));
                toggleDevices_Fridge = true;
            }
            else
            {
                pictureBox_Fridge.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Fridge.png")));
                toggleDevices_Fridge = false;
            }
        }

        private void pictureBox_Coffee_Click(object sender, EventArgs e)
        {
            if (!toggleDevices_Coffee)
            {
                pictureBox_Coffee.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Coffee-Not.png")));
                toggleDevices_Coffee = true;
            }
            else
            {
                pictureBox_Coffee.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Coffee.png")));
                toggleDevices_Coffee = false;
            }
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\EmployeeGuide.chm", HelpNavigator.TopicId, "9");
        }
    }
}
