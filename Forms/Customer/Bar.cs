using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace TheDuckCinema.Forms.Customer
{
    public partial class Bar : Form
    {
        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            this.Text = "The Duck Cinema - Μπαρ";
        }

        public Bar()
        {
            InitializeComponent();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\CustomerGuide.chm", HelpNavigator.TopicId, "12");
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formHall = new Hall();
            formHall.Closed += (s, args) => this.Close();
            formHall.Show();
        }

        private void Bar_Load(object sender, EventArgs e)
        {
            pictureBox_Menu.Parent = pictureBox_Backgrnd;
            pictureBox_Menu.BackColor = Color.Transparent;

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

        private void pictureBox_Menu_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Menu.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\Menu-Active.png")));
        }

        private void pictureBox_Menu_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Menu.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Menu.png")));
        }

        private void pictureBox_Menu_Click(object sender, EventArgs e)
        {
            var formMenu = new Menu_FirstPage();
            formMenu.ShowDialog();
        }
    }
}
