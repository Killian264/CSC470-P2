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
    public partial class Dialog : Form
    {
        public string DialogResult = "";
        public Dialog(string param)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.label1.Text = param;
        }
    }
}
