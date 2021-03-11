using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Customer
{
    public partial class Menu_SecondPagePOS : Form
    {
        public Menu_SecondPagePOS()
        {
            InitializeComponent();
        }

        public string MsgBoxCompleted = "Payment successful!";
        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
            panel_Steps.BackColor = Color.FromArgb(30, 30, 30);
            this.BackColor = Color.FromArgb(18, 18, 18);
        }

        public void changeToGreek()
        {
            label_Steps.Text = "Βήματα:\n1. Τοποθετήστε την κάρτα στο POS.\n2.Πατήστε το πράσινο κουμπί (Κύκλος)";
            button_Help.Text = "Βοήθεια";
            MsgBoxCompleted = "Η συναλλαγή ήταν επιτυχής!";
        }

        private void Menu_SecondPagePOS_Load(object sender, EventArgs e)
        {
            pictureBox_CircleGif.Parent = pictureBox_POS;
            pictureBox_CircleGif.BackColor = Color.Transparent;

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

        private void pictureBox_CircleGif_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(MsgBoxCompleted, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\CustomerGuide.chm", HelpNavigator.TopicId, "2");
        }
    }
}
