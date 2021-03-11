using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheDuckCinema.Forms.Customer
{
    public partial class Menu_FirstPage : Form
    {
        public static bool toggleHotduck;
        public static bool toggleDuckos;
        public static bool toggleQuackcorn;
        public static bool toggleDuckchips;
        public static bool toggleWaterBottle;
        public static bool toggleSoduckDrink;
        public static bool toggleDuckLabel;

        public Menu_FirstPage()
        {
            InitializeComponent();
        }

        public void unlockNextButton()
        {
            int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
            if (sum > 0)
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

        public void changeToDark()
        {
            panel_Bottom.BackColor = Color.FromArgb(30, 30, 30);
            numericUpDown_Duckchips.BackColor = Color.FromArgb(45, 45, 45);
            numericUpDown_Duckos.BackColor = Color.FromArgb(45, 45, 45);
            numericUpDown_Hotduck.BackColor = Color.FromArgb(45, 45, 45);
            numericUpDown_Quackcorn.BackColor = Color.FromArgb(45, 45, 45);
            numericUpDown_DuckLabel.BackColor = Color.FromArgb(45, 45, 45);
            numericUpDown_WaterBottle.BackColor = Color.FromArgb(45, 45, 45);
            numericUpDown_SoduckDrink.BackColor = Color.FromArgb(45, 45, 45);
        }
        public void changeToGreek()
        {
            button_Help.Text = "Βοήθεια";
            button_WaterBottle.Text = "Νερό";
            button_SoduckDrink.Text = "Ποτό Soduck";

            label_Foods.Text = "ΦΑΓΗΤΟ:";
            label_Drinks.Text = "ΠΟΤΑ:";
            Label_TotalPrice.Text = "ΣΥΝΟΛΙΚΗ ΤΙΜΗ:  €";
            toolTip.SetToolTip(this.pictureBox_Next, "Θα πρέπει να επιλέξετε τουλάχιστον ένα προιόν για να συνεχίσετε!");
        }

        private void Menu_FirstPage_Load(object sender, EventArgs e)
        {
            toggleHotduck = false;
            toggleDuckos = false;
            toggleQuackcorn = false;
            toggleDuckchips = false;
            toggleWaterBottle = false;
            toggleSoduckDrink = false;
            toggleDuckLabel = false;
            toolTip.SetToolTip(this.pictureBox_Next, "You must select at least an item to preceed!");

            pictureBox_Hotduck.Parent = pictureBox_Backgrnd;
            pictureBox_Hotduck.BackColor = Color.Transparent;
            pictureBox_Duckos.Parent = pictureBox_Backgrnd;
            pictureBox_Duckos.BackColor = Color.Transparent;
            pictureBox_Quackcorn.Parent = pictureBox_Backgrnd;
            pictureBox_Quackcorn.BackColor = Color.Transparent;
            pictureBox_Duckchips.Parent = pictureBox_Backgrnd;
            pictureBox_Duckchips.BackColor = Color.Transparent;
            pictureBox_WaterBottle.Parent = pictureBox_Backgrnd;
            pictureBox_WaterBottle.BackColor = Color.Transparent;
            pictureBox_SoduckDrink.Parent = pictureBox_Backgrnd;
            pictureBox_SoduckDrink.BackColor = Color.Transparent;
            pictureBox_DuckLabel.Parent = pictureBox_Backgrnd;
            pictureBox_DuckLabel.BackColor = Color.Transparent;

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

        private void button_Quackcorn_Click(object sender, EventArgs e)
        {
            if (toggleQuackcorn == false)
            {
                toggleQuackcorn = true;
                button_Quackcorn.FlatAppearance.BorderSize = 2;
                numericUpDown_Quackcorn.Visible = true;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum + numericUpDown_Quackcorn.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            else if (toggleQuackcorn == true)
            {
                toggleQuackcorn = false;
                button_Quackcorn.FlatAppearance.BorderSize = 0;
                numericUpDown_Quackcorn.Visible = false;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum - numericUpDown_Quackcorn.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            unlockNextButton();
        }

        private void button_Food_Duckos_Click(object sender, EventArgs e)
        {
            if (toggleDuckos == false)
            {
                toggleDuckos = true;
                button_Duckos.FlatAppearance.BorderSize = 2;
                numericUpDown_Duckos.Visible = true;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum + 4 * numericUpDown_Duckos.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            else if (toggleDuckos == true)
            {
                toggleDuckos = false;
                button_Duckos.FlatAppearance.BorderSize = 0;
                numericUpDown_Duckos.Visible = false;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum - 4 * numericUpDown_Duckos.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            unlockNextButton();
        }

        private void button_Hotduck_Click(object sender, EventArgs e)
        {
            if (toggleHotduck == false)
            {
                toggleHotduck = true;
                button_Hotduck.FlatAppearance.BorderSize = 2;
                numericUpDown_Hotduck.Visible = true;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum + 3 * numericUpDown_Hotduck.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            else if (toggleHotduck == true)
            {
                toggleHotduck = false;
                button_Hotduck.FlatAppearance.BorderSize = 0;
                numericUpDown_Hotduck.Visible = false;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum - 3 * numericUpDown_Hotduck.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            unlockNextButton();
        }

        private void button_Duckchips_Click(object sender, EventArgs e)
        {
            if (toggleDuckchips == false)
            {
                toggleDuckchips = true;
                button_Duckchips.FlatAppearance.BorderSize = 2;
                numericUpDown_Duckchips.Visible = true;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum + 2 * numericUpDown_Duckchips.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            else if (toggleDuckchips == true)
            {
                toggleDuckchips = false;
                button_Duckchips.FlatAppearance.BorderSize = 0;
                numericUpDown_Duckchips.Visible = false;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum - 2 * numericUpDown_Duckchips.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            unlockNextButton();
        }

        private void button_WaterBottle_Click(object sender, EventArgs e)
        {
            if (toggleWaterBottle == false)
            {
                toggleWaterBottle = true;
                button_WaterBottle.FlatAppearance.BorderSize = 2;
                numericUpDown_WaterBottle.Visible = true;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum + numericUpDown_WaterBottle.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            else if (toggleWaterBottle == true)
            {
                toggleWaterBottle = false;
                button_WaterBottle.FlatAppearance.BorderSize = 0;
                numericUpDown_WaterBottle.Visible = false;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum - numericUpDown_WaterBottle.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            unlockNextButton();
        }

        private void button_DuckLabel_Click(object sender, EventArgs e)
        {
            if (toggleDuckLabel == false)
            {
                toggleDuckLabel = true;
                button_DuckLabel.FlatAppearance.BorderSize = 2;
                numericUpDown_DuckLabel.Visible = true;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum + 5 * numericUpDown_DuckLabel.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            else if (toggleDuckLabel == true)
            {
                toggleDuckLabel = false;
                button_DuckLabel.FlatAppearance.BorderSize = 0;
                numericUpDown_DuckLabel.Visible = false;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum - 5 * numericUpDown_DuckLabel.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            unlockNextButton();
        }

        private void button_SoduckDrink_Click(object sender, EventArgs e)
        {
            if (toggleSoduckDrink == false)
            {
                toggleSoduckDrink = true;
                button_SoduckDrink.FlatAppearance.BorderSize = 2;
                numericUpDown_SoduckDrink.Visible = true;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum + 2 * numericUpDown_SoduckDrink.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            else if (toggleSoduckDrink == true)
            {
                toggleSoduckDrink = false;
                button_SoduckDrink.FlatAppearance.BorderSize = 0;
                numericUpDown_SoduckDrink.Visible = false;
                int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
                label_TotalPriceSum.Text = (sum - 2 * numericUpDown_SoduckDrink.Value).ToString();
                label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            }
            unlockNextButton();
        }

        decimal prevValue_WaterBottle = 0;
        private void numericUpDown_WaterBottle_ValueChanged(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
            if (numericUpDown_WaterBottle.Value < prevValue_WaterBottle)
            {
                label_TotalPriceSum.Text = (sum - 1).ToString();
            }
            else if (numericUpDown_WaterBottle.Value > prevValue_WaterBottle)
            {
                label_TotalPriceSum.Text = (sum + 1).ToString();
            }
            prevValue_WaterBottle = numericUpDown_WaterBottle.Value;
            label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            unlockNextButton();
        }

        decimal prevValue_DuckLabel = 0;
        private void numericUpDown_DuckLabel_ValueChanged(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
            if (numericUpDown_DuckLabel.Value < prevValue_DuckLabel)
            {
                label_TotalPriceSum.Text = (sum - 5).ToString();
            }
            else if (numericUpDown_DuckLabel.Value > prevValue_DuckLabel)
            {
                label_TotalPriceSum.Text = (sum + 5).ToString();
            }
            prevValue_DuckLabel = numericUpDown_DuckLabel.Value;
            label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            unlockNextButton();
        }

        decimal prevValue_SoduckDrink = 0;
        private void numericUpDown_SoduckDrink_ValueChanged(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
            if (numericUpDown_SoduckDrink.Value < prevValue_SoduckDrink)
            {
                label_TotalPriceSum.Text = (sum - 2).ToString();
            }
            else if (numericUpDown_SoduckDrink.Value > prevValue_SoduckDrink)
            {
                label_TotalPriceSum.Text = (sum + 2).ToString();
            }
            prevValue_SoduckDrink = numericUpDown_SoduckDrink.Value;
            label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            unlockNextButton();
        }

        decimal prevValue_Duckchips = 0;
        private void numericUpDown_Duckchips_ValueChanged(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
            if (numericUpDown_Duckchips.Value < prevValue_Duckchips)
            {
                label_TotalPriceSum.Text = (sum - 2).ToString();
            }
            else if (numericUpDown_Duckchips.Value > prevValue_Duckchips)
            {
                label_TotalPriceSum.Text = (sum + 2).ToString();
            }
            prevValue_Duckchips = numericUpDown_Duckchips.Value;
            label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            unlockNextButton();
        }

        decimal prevValue_Quackcorn = 0;
        private void numericUpDown_Quackcorn_ValueChanged(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
            if (numericUpDown_Quackcorn.Value < prevValue_Quackcorn)
            {
                label_TotalPriceSum.Text = (sum - 1).ToString();
            }
            else if (numericUpDown_Quackcorn.Value > prevValue_Quackcorn)
            {
                label_TotalPriceSum.Text = (sum + 1).ToString();
            }
            prevValue_Quackcorn = numericUpDown_Quackcorn.Value;
            label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            unlockNextButton();
        }

        decimal prevValue_Duckos = 0;
        private void numericUpDown_Duckos_ValueChanged(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
            if (numericUpDown_Duckos.Value < prevValue_Duckos)
            {
                label_TotalPriceSum.Text = (sum - 4).ToString();
            }
            else if (numericUpDown_Duckos.Value > prevValue_Duckos)
            {
                label_TotalPriceSum.Text = (sum + 4).ToString();
            }
            prevValue_Duckos = numericUpDown_Duckos.Value;
            label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            unlockNextButton();
        }

        decimal prevValue_Hotduck = 0;
        private void numericUpDown_Hotduck_ValueChanged(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
            if (numericUpDown_Hotduck.Value < prevValue_Hotduck)
            {
                label_TotalPriceSum.Text = (sum - 3).ToString();
            }
            else if (numericUpDown_Hotduck.Value > prevValue_Hotduck)
            {
                label_TotalPriceSum.Text = (sum + 3).ToString();
            }
            prevValue_Hotduck = numericUpDown_Hotduck.Value;
            label_TotalPriceSum.Text = label_TotalPriceSum.Text.Insert(0, "€");
            unlockNextButton();
        }

        private void pictureBox_Next_Click(object sender, EventArgs e)
        {
            if (pictureBox_Next.Cursor == Cursors.No)
                return;
            int sum = Convert.ToInt32(label_TotalPriceSum.Text.Replace("€", ""));
            var lines = File.ReadAllLines("Settings.txt");
            if (lines.Length < 3)
                File.AppendAllText("Settings.txt", Environment.NewLine + sum.ToString());
            else
                lineChanger(sum.ToString(), "Settings.txt", 3);
            
            Menu_SecondPage formMenuSecondPage = new Menu_SecondPage(this);
            formMenuSecondPage.ShowDialog();
        }
        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Help Files\\CustomerGuide.chm", HelpNavigator.TopicId, "2");
        }
    }
}
