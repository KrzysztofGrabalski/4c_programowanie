namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //comboBoxFavouriteMeal.SelectedIndex = 2;
            InitializeComponent();
            comboBoxFavouriteMeal.SelectedIndex = 2;

            labelCurentTime.Text = DateTime.Now.ToString();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            string schoolSubject = "Ulubione przedmioty:\n";
            if (checkBoxSchoolSubjectMathematics.Checked)
            {
                schoolSubject += "matematyka\n";
            }
            if (checkBoxSchoolSubjectGerman.Checked)
            {
                schoolSubject += "j�zyk niemiecki\n";
            }

            string pizzaWithPineapple = "";
            if (radioButtonPizzaQuestionYes.Checked)
            {
                pizzaWithPineapple = "Lubi� pizze z ananasem.";
            }
            else
            {
                pizzaWithPineapple = "Pizza z ananasem to nieporozumienie";
            }

            string favouriteMeal = comboBoxFavouriteMeal.Text;

            MessageBox.Show(
                $"Witaj {name} w pierwszym programie.\n {schoolSubject}"
                + $"\n{pizzaWithPineapple}"
                + $"\nUlubiona potrawa: {favouriteMeal}",
                "Komunikat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
        }

        private void buttonRefreshTime_Click(object sender, EventArgs e)
        {
            labelCurentTime.Text = DateTime.Now.ToString();
            //timerRefreshTime.Enabled = !timerRefreshTime.Enabled;
        }

        private void timerRefreshTime_Tick(object sender, EventArgs e)
        {
            labelCurentTime.Text = DateTime.Now.ToString();
        }
    }
}