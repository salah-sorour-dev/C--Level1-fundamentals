using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyFirstWinFormsProject
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            for (int i = 0; i < 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500); // Simulate some work being done
                    progressBar1.Value += 10; // Increment the progress bar by 10

                    label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%"; // Update the label with the percentage

                    progressBar1.Refresh(); // Refresh the progress bar to show the updated value
                    label1.Refresh(); // Refresh the label to show the updated percentage
                }
                else
                {
                    button1.Enabled = false; // Disable the button when the progress bar reaches its maximum value
                }

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0; // Reset the progress bar value to 0
            label1.Text = "0%"; // Reset the label text to 0%
        }
    }
}
