using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_06_02_FiveColors2_TM
{
    public partial class PurpleForm : Form
    {
        public PurpleForm()
        {
            InitializeComponent();
        }

        private void purpleformLabel_Click(object sender, EventArgs e)
        {
            string urlToOpen = "https://www.youtube.com/watch?v=TvnYmWpD_T8";
            System.Diagnostics.Process.Start(urlToOpen);
        }

        private void purplerainButton_Click(object sender, EventArgs e)
        {
            string urlToOpen = "https://www.youtube.com/watch?v=TvnYmWpD_T8";
            System.Diagnostics.Process.Start("msedge.exe", urlToOpen);
        }
    }
}
