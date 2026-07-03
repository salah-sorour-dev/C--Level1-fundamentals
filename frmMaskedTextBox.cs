using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmMaskedTextBox : Form
    {
        public frmMaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.MaskFull)
            {
                MessageBox.Show("User entered: " + maskedTextBox2.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number.");
            }
        }
    }
}
