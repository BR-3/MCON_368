using MCON_368.WinForm.Code;

namespace MCON_368.WinForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            DoCalculations();
        }
        private void DoCalculations()
        {
            if (!LocalFunctions.IsNumeric(firstNumberTextBox.Text)) { resultsLabel.Text = "The first number must be numeric."; resultsLabel.ForeColor = Color.Red; }
            else if (!LocalFunctions.IsNumeric(secondNumberTextBox.Text)) { resultsLabel.Text = "The second number must be numeric."; resultsLabel.ForeColor = Color.Red; }
            else { resultsLabel.Text = (Convert.ToInt32(firstNumberTextBox.Text) * Convert.ToInt32(secondNumberTextBox.Text)).ToString(); resultsLabel.ForeColor = Color.Black; }
        }


        private void TextBoxLeaveEvent(object sender, EventArgs e)
        {
            DoCalculations();
        }

        private void firstNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondNumberTextBox_TextChanged(string sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void firstNumberTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}
