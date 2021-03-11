using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Customer
{
    public partial class Cinema : Form
    {
        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            this.Text = "The Duck Cinema - Αίθουσα Σινεμά";
        }

        public Cinema()
        {
            InitializeComponent();
        }

        private void Cinema_Load(object sender, EventArgs e)
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
        }

        private void pictureBox_Exit4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formHall = new Hall();
            formHall.Closed += (s, args) => this.Close();
            formHall.Show();
        }

        private void pictureBox_Exit2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formHall = new Hall();
            formHall.Closed += (s, args) => this.Close();
            formHall.Show();
        }

        private void pictureBox_Exit3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formHall = new Hall();
            formHall.Closed += (s, args) => this.Close();
            formHall.Show();
        }

        private void pictureBox_Exit1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formHall = new Hall();
            formHall.Closed += (s, args) => this.Close();
            formHall.Show();
        }

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formHall = new Hall();
            formHall.Closed += (s, args) => this.Close();
            formHall.Show();
        }

        private void pictureBox_Exit1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Exit1.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\Exit-Active.png")));
        }

        private void pictureBox_Exit1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Exit1.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Exit.png")));
        }

        private void pictureBox_Exit2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Exit2.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\Exit-Active.png")));
        }

        private void pictureBox_Exit2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Exit2.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Exit.png")));
        }

        private void pictureBox_Exit3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Exit3.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\Exit-Active.png")));
        }

        private void pictureBox_Exit3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Exit3.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Exit.png")));
        }

        private void pictureBox_Exit4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Exit4.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\Exit-Active.png")));
        }

        private void pictureBox_Exit4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Exit4.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Exit.png")));
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\CustomerGuide.chm", HelpNavigator.TopicId, "15");
        }
    }
}
