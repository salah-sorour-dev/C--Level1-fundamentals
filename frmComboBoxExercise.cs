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
    public partial class frmComboBoxExercise : Form
    {
        public frmComboBoxExercise()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem.ToString().ToLower())
            {

                case "book":
                    pictureBox1.Image = Properties.Resources.Book;
                    lblTitle.Text = "Book";
                    break;

                case "boy":
                    pictureBox1.Image = Properties.Resources.Boy;
                    lblTitle.Text = "Boy";
                    break;

                case "girl":
                    pictureBox1.Image = Properties.Resources.Girl;
                    lblTitle.Text = "Girl";
                    break;

                case "pen":
                    pictureBox1.Image = Properties.Resources.Pen;
                    lblTitle.Text = "Pen";
                    break;
            }
        }

        private void frmComboBoxExercise_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 3;
        }
    }
}
