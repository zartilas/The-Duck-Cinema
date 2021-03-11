using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Customer
{
    public partial class Tickets_FirstPage : Form
    {
        public Tickets_FirstPage()
        {
            InitializeComponent();
        }

        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
            panel_Center.BackColor = Color.FromArgb(30, 30, 30);
            this.BackColor = Color.FromArgb(18, 18, 18);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            label_Movies.Text = "Ταινίες:";
            label_Seats.Text = "Διαθέσιμες Θέσεις:";
            label_Price.Text = "Τιμή:";
        }

        private void Tickets_FirstPage_Load(object sender, EventArgs e)
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

        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttons_Movie_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTicketSecondPage = new Tickets_SecondPage();
            this.Close();
            formTicketSecondPage.ShowDialog();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\CustomerGuide.chm", HelpNavigator.TopicId, "3");
        }
    }
}
