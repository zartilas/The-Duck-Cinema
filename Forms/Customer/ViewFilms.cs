using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Customer
{
    public partial class ViewFilms : Form
    {
        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";

        }

        public ViewFilms()
        {
            InitializeComponent();
        }

        private void ViewFilms_Load(object sender, EventArgs e)
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
                listBox_Movies.Items[0] = "Ταινία:	 		Ώρα Προβολής: 	    Σκηνοθέτης:		Αξιολόγηση:  	Τιμή:";
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

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (!textBox_Search.Text.Equals("") || !string.IsNullOrWhiteSpace(textBox_Search.Text))
            {
                var lines = File.ReadAllLines("Settings.txt");
                string headerMsg = "Movie:	 		Showtime: 	Director:			Ratings:  		Price:";
                if (lines[0].ToLower().Equals("greek"))
                {
                    headerMsg = "Ταινία:	 		Ώρα Προβολής: 	    Σκηνοθέτης:		Αξιολόγηση:  		Τιμή:";
                }
                foreach (string movie in listBox_MoviesHidden.Items) {
                    var movie_properties = movie.Split(',');
                    if (movie_properties[0].Equals(textBox_Search.Text, StringComparison.InvariantCultureIgnoreCase) && !movie_properties[0].Equals("Movie:", StringComparison.InvariantCultureIgnoreCase))
                    {
                        listBox_Movies.Items.Clear();
                        listBox_Movies.Items.Add(headerMsg);
                        listBox_Movies.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------");
                        listBox_Movies.Items.Add(movie_properties[0] 
                                                + " "
                                                + movie_properties[1]
                                                + " "
                                                + movie_properties[2]
                                                + " "
                                                + movie_properties[3]
                                                + " "
                                                + movie_properties[4]);
                        return;
                    }
                }
                listBox_Movies.Items.Clear();
                if (lines[0].ToLower().Equals("greek"))
                    listBox_Movies.Items.Add("Δεν υπάρχει ταινία με όνομα " + "'" + textBox_Search.Text + "'");
                else
                    listBox_Movies.Items.Add("There is no movie called " + "'" + textBox_Search.Text + "'");
            }
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Search.Text.Equals(""))
            {
                var lines = File.ReadAllLines("Settings.txt");
                string headerMsg = "Movie:	 		Showtime: 	Director:			Ratings:  		Price:";
                if (lines[0].ToLower().Equals("greek"))
                {
                    headerMsg = "Ταινία:	 		Ώρα Προβολής: 	    Σκηνοθέτης:			Αξιολόγηση:  		Τιμή:";
                }
                listBox_Movies.Items.Clear();
                listBox_Movies.Items.Add(headerMsg);
                listBox_Movies.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox_Movies.Items.Add("Duckpool,  		18:00-20:00,               Marwan Hodson,  		9.1/10,                           €10");
                listBox_Movies.Items.Add("The Princess and the Duck,  	14:00-16:00,               Loui Archer,  		7.2/10,                           €10");
                listBox_Movies.Items.Add("Ducklist,  		20:00-22:00,               Ayaan Ramos,  		9.6/10,                           €10");
                listBox_Movies.Items.Add("Ducks of Academy,  	22:00-00:00,               Orion Sosa,  		8.4/10,                           €10");
                listBox_Movies.Items.Add("Duck Wick,  		18:00-21:00,               Christopher Regan,                   7.8/10,                           €10");
            }
        }

        private void listBox_MoviesHidden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\CustomerGuide.chm", HelpNavigator.TopicId, "13");
        }
    }
}
