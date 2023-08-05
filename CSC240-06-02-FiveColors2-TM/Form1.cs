using System.Drawing.Text;

namespace CSC240_06_02_FiveColors2_TM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            defaultRadioButton.Checked = true;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioButton.Checked)
            {
                this.BackColor = Color.Red;
            }

        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blueRadioButton.Checked)
            {
                this.BackColor = Color.Blue;
            }

        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (greenRadioButton.Checked)
            {
                this.BackColor = Color.Green;
            }

        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowRadioButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }

        }

        private void purpleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (purpleRadioButton.Checked)
            {
                this.BackColor = Color.Purple;
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (resetButton.Enabled == true)
            {
                defaultRadioButton.Checked = true;
            }
        }

        private void defaultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}