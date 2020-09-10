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
        public Main()
        {
            InitializeComponent();
        }

        private void openDialog_Click(object sender, EventArgs e)
        {
            var dialog = new Dialog("cool input string");

            dialog.ShowDialog();

            var result = dialog.DialogResult;
        }
    }
}
