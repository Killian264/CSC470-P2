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

            LoadPictures();
        }

        private void LoadPictures()
        {
            switch(this.label1.Text)
            {
                case "Crappie":
                    pictureBox1.Image = Properties.Resources.Crappie;
                    break;
                case "Perch":
                    pictureBox1.Image = Properties.Resources.Perch;
                    break;
                case "Walleye":
                    pictureBox1.Image = Properties.Resources.Walleye;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cancel
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Release
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Keep
        }
    }
}
