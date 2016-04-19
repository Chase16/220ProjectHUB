using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220ProjectHUB
{
    public partial class Reviews_Form : Form
    {
        public Reviews_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Item = movieToWishList.Text;
            reviewsBox.Items.Add(Item);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reviewsBox.Items.RemoveAt(reviewsBox.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reviewsBox.Items.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (starValueBar.Value < 20)
            {
                starValueLbl.Text = "1";
            }
            else if ((starValueBar.Value >= 40) && (starValueBar.Value < 60))
            {
                starValueLbl.Text = "2";
            }
            else if ((starValueBar.Value >= 60) && (starValueBar.Value < 80))
            {
                starValueLbl.Text = "3";
            }
            else if ((starValueBar.Value >= 80) && (starValueBar.Value < 100))
            {
                starValueLbl.Text = "4";
            }
            else if (starValueBar.Value >= 100)
            {
                starValueLbl.Text = "5";
            }
        }
    }
}
