using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC470_P2
{
    public partial class Main : Form
    {
        public string fishType;
        public Main()
        {
            InitializeComponent();
        }

        private void openDialog_Click(object sender, EventArgs e)
        {
            var dialog = new Dialog(fishType);

            dialog.ShowDialog();

            var result = dialog.DialogResult;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.fishType = "Crappie";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.fishType = "Perch";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.fishType = "Walleye";
        }
    }
}
