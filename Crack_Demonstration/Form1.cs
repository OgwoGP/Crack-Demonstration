using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crack_Demonstration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool chk1 = checkBox1.Checked;
            if(chk1)
            {
                this.guna2Button1.Enabled = true;
                this.guna2Button2.Enabled = true;
            }
            else
            {
                this.guna2Button1.Enabled = false;
                this.guna2Button2.Enabled = false;
            }
        }
        /// <summary>
        /// Timer Start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        /// <summary>
        /// Timer Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Increment(1);
            guna2ProgressBar1.Value.ToString();
            label3.Text = guna2ProgressBar1.Value.ToString() + "%";
            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Successfully / 完了","Progress", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ProgressBar1.Maximum = 100;
        }
        /// <summary>
        /// Timer Stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        /// <summary>
        /// Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value = 0;
            timer1.Stop();
            label3.Text = "0%";
        }
    }
}
