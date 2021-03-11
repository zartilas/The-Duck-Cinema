using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Customer
{
    public partial class Tickets_SecondPage : Form
    {
        public string MsgBoxSeatOccupied = "This seat is already reserved!";

        public Tickets_SecondPage()
        {
            InitializeComponent();
        }

        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            label_SelectSeats.Text = "Επιλέξτε θέση/εις:";
            label_Monitor.Text = "Οθόνη";
            MsgBoxSeatOccupied = "Αυτή η θέση είναι πιασμένη!";
            toolTip.SetToolTip(this.pictureBox_Next, "Πρέπει να επιλέξετε θέση για να συνεχίσετε!");
        }

        private void Tickets_SecondPage_Load(object sender, EventArgs e)
        {
            Cursor newCursor = new Cursor(@"cursor_hand.cur");
            this.Cursor = newCursor;

            toolTip.SetToolTip(this.pictureBox_Next, "You must select a seat to preceed!");
            
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
            var formTicketsFirstPage = new Tickets_FirstPage();
            formTicketsFirstPage.ShowDialog();
        }

        public static int countSeats;
        private void buttons_Click(object sender, EventArgs e)
        {
            Button buttonText = (Button)sender;

            if (buttonText.BackColor == Color.FromArgb(171, 0, 20))
            {
                MessageBox.Show(MsgBoxSeatOccupied, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (buttonText.FlatAppearance.BorderSize == 1)
            {
                buttonText.FlatAppearance.BorderSize = 2;
                buttonText.FlatAppearance.BorderColor = Color.FromArgb(0, 168, 0);
                buttonText.BackColor = Color.FromArgb(82, 176, 230);
                countSeats += 1;
            }
            else
            {
                buttonText.FlatAppearance.BorderSize = 1;
                buttonText.FlatAppearance.BorderColor = Color.Black;
                buttonText.BackColor = Color.White;
                countSeats -= 1;
            }
            if (countSeats > 0)
            {
                toolTip.Active = false;
                pictureBox_Next.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Button-Next.png")));
                pictureBox_Next.Cursor = Cursors.Hand;
            }
            else
            {
                toolTip.Active = true;
                pictureBox_Next.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Button-Next-Unavailable.png")));
                pictureBox_Next.Cursor = Cursors.No;
            }
        }

        private void pictureBox_Next_Click(object sender, EventArgs e)
        {
            if (pictureBox_Next.Cursor == Cursors.No)
                return;
            this.Hide();
            this.Close();
            Form formTicketsThirdPage = new Tickets_ThirdPage();
            formTicketsThirdPage.ShowDialog();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\CustomerGuide.chm", HelpNavigator.TopicId, "3");
        }
    }
}
