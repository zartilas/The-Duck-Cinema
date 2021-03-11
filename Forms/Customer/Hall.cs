using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Customer
{
    public partial class Hall : Form
    {
        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
        }
        public void changeToGreek()
        {
            this.Text = "The Duck Cinema - Προθάλαμος";
            button_Help.Text = "Βοήθεια";
        }

        public Hall()
        {
            InitializeComponent();
        }

        private void pictureBox_ViewMovies_Click(object sender, EventArgs e)
        {
            var formViewMovies = new ViewFilms();
            formViewMovies.ShowDialog();
        }

        private void Hall_Load(object sender, EventArgs e)
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
            this.Hide();
            var formMenu = new Main_Menu_Form();
            formMenu.Closed += (s, args) => this.Close();
            formMenu.Show();
        }

        private void pictureBox_Elevator_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCinema = new Cinema();
            formCinema.Closed += (s, args) => this.Close();
            formCinema.Show();
        }

        private void pictureBox_Bar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBar = new Bar();
            formBar.Closed += (s, args) => this.Close();
            formBar.Show();
        }

        private void pictureBox_ViewMovies_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_ViewMovies.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\View-Active.png")));
        }

        private void pictureBox_ViewMovies_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_ViewMovies.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\View.png")));
        }

        private void pictureBox_BuyTickets_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_BuyTickets.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\BuyTickets-Active.png")));
        }

        private void pictureBox_BuyTickets_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_BuyTickets.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\BuyTickets.png")));
        }

        private void pictureBox_Elevator_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Elevator.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\Elevator-Active.png")));
        }

        private void pictureBox_Elevator_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Elevator.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Elevator.png")));
        }

        private void pictureBox_Bar_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Bar.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Buttons_Active\\Food-Active.png")));
        }

        private void pictureBox_Bar_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Bar.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\Food.png")));
        }

        private void pictureBox_BuyTickets_Click(object sender, EventArgs e)
        {
            var formTicketsFirstPage = new Tickets_FirstPage();
            formTicketsFirstPage.ShowDialog();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\CustomerGuide.chm");
        }
    }
}
