using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Employee
{
    public partial class Vacuum_NotfPage : Form
    {
        public string MsgBoxTask = "Task completed successfully!";

        public Vacuum_NotfPage()
        {
            InitializeComponent();
        }

        public void changeToDark()
        {
            label_Title.ForeColor = Color.White;
            label_NotificationText.ForeColor = Color.White;
            panel_Bottom.BackColor = Color.FromArgb(45, 45, 45);
            panel_Center.BackColor = Color.FromArgb(45, 45, 45);
            this.BackColor = Color.FromArgb(18, 18, 18);
            toolTip1.BackColor = Color.FromArgb(18, 18, 18);
            toolTip1.ForeColor = Color.White;
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            label_Title.Text = "ΕΙΔΟΠΟΙΗΣΕΙΣ";
            label_ListHeader.Text = "ID:        Αρ. Σκούπας:   Ιστορικό Καθαρίσματος ID:    Ημ/νια:         Πρόβλημα:";
            label_List.Text = "1          1                      2                                          20/2/19            Ένα κλειδί βρέθηκε κοντά στην θέση 15\n" +
                              "2          4                      1                                          19 / 2 / 19        Η περιοχή ανάμεσα στις θέσεις 5 - 10 ήταν πολύ βρόμικη.";
            label_NotificationText.Text = "Έχετε 2 ειδοποιήσεις.";
            toolTip1.SetToolTip(this.button_Send1, "Να ενημερωθούν οι πελάτες που ήταν\nκοντά σε αυτήν την θέση.");
            toolTip1.SetToolTip(this.button_Send2, "Προειδοποίηση πελατών που ήταν κοντά\nστην θέση να είναι πιο προσεκτικοί.");
            MsgBoxTask = "Η διαδικασία έχει ολοκληρωθεί επιτυχώς!";
        }
        private void Vacuum_SecondPage_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.button_Send1, "Notify the customers that were\nnear that seat.");
            toolTip1.SetToolTip(this.button_Send2, "Warn the customers that were\nnear that seat to be more careful.");

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

        private void button_Send1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgBoxTask, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Send2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgBoxTask, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\EmployeeGuide.chm", HelpNavigator.TopicId, "3");
        }
    }
}
