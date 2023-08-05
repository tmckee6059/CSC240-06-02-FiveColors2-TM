using System.Drawing.Text;

namespace CSC240_06_02_FiveColors2_TM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioButton.Checked)
            {
                this.BackColor = Color.Red;
            }

            else
            {
                this.BackColor = Color.White;
            }
            
        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blueRadioButton.Checked)
            {
                this.BackColor = Color.Blue;
            }

            else
            {
                this.BackColor = Color.White;
            }
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (greenRadioButton.Checked)
            {
                this.BackColor = Color.Green;
            }

            else
            {
                this.BackColor = Color.White;
            }
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowRadioButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }

            else
            {
                this.BackColor = Color.White;
            }
        }

        private void purpleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (purpleRadioButton.Checked)
            {
                this.BackColor= Color.Purple;
            }

            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}