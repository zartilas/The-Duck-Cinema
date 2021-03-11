using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Employee
{
    public partial class Vacuum_StartSecondPage : Form
    {
        public string MsgBoxFailed = "You must fill all the fields of the form!";
        public string MsgBoxProgrammedNow = "The Robot-Vacuum has started cleaning!";
        public string MsgBoxProgrammedLater = "The Robot-Vacuum has been programmed to clean at ";

        public Vacuum_StartSecondPage()
        {
            InitializeComponent();
        }
        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
            this.BackColor = Color.FromArgb(18,18,18);
            textBox_Time.BackColor = Color.FromArgb(45, 45, 45);
            comboBox_Vacuum.BackColor = Color.FromArgb(45, 45, 45);
            comboBox_CleaningMode.BackColor = Color.FromArgb(45, 45, 45);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            label_Time.Text = "Ώρα:";
            label_Vacuum.Text = "Σκούπα:";
            label_CleaningMode.Text = "Τρόπος Καθαρισμού:";
            label_FormTitle.Text = "Κάντε τις επιλογές σας:";
            comboBox_Vacuum.Items.Clear();
            comboBox_Vacuum.Items.Add("Σκούπα με αρ. 1");
            comboBox_Vacuum.Items.Add("Σκούπα με αρ. 2");
            comboBox_Vacuum.Items.Add("Σκούπα με αρ. 3");
            comboBox_Vacuum.Items.Add("Σκούπα με αρ. 4");
            comboBox_Vacuum.Items.Add("Σκούπα με αρ. 5");
            comboBox_CleaningMode.Items.Clear();
            comboBox_CleaningMode.Items.Add("Γρήγορο Καθάρισμα");
            comboBox_CleaningMode.Items.Add("Καθάρισμα εις Βάθος");
            MsgBoxFailed = "Πρέπει να συμπληρώσετε όλα τα πεδία της φόρμας!";
            MsgBoxProgrammedNow = "Η σκούπα έχει αρχίσει το καθάρισμα!";
            MsgBoxProgrammedLater = "Η σκούπα έχει προγραμματιστεί να καθαρίσει η ώρα ";
            button_Form_Finish.Text = "ΟΛΟΚΛΗΡΩΣΗ";
        }

        private void LightManager_Load(object sender, EventArgs e)
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
            this.Hide();
            this.Close();
            Vacuum_StartFirstPage vacuum_StartFirstPage = new Vacuum_StartFirstPage();
            vacuum_StartFirstPage.ShowDialog();
        }

        private void button_Form_Complete_Click(object sender, EventArgs e)
        {
            if ((textBox_Time.Text == "") ||
                (comboBox_CleaningMode.SelectedIndex == -1) ||
                (comboBox_Vacuum.SelectedIndex == -1))
            {
                MessageBox.Show(MsgBoxFailed, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((textBox_Time.Text.Equals("Now", StringComparison.InvariantCultureIgnoreCase)) ||
                (textBox_Time.Text.Equals("Τώρα", StringComparison.InvariantCultureIgnoreCase)))
            {
                MessageBox.Show(MsgBoxProgrammedNow, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                this.Close();
                return;
            }
            MessageBox.Show(MsgBoxProgrammedLater + textBox_Time.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            this.Close();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\EmployeeGuide.chm", HelpNavigator.TopicId, "1");
        }
    }
}
