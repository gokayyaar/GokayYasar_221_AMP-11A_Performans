using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GÖKAY_PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBox1.Left += rd.Next(5, 15);
            pictureBox2.Left += rd.Next(5, 15);
            pictureBox3.Left += rd.Next(5, 15);
            if(pictureBox1.Left>label6.Left)
            {
                timer1.Stop();
                MessageBox.Show("TOROS KAZANDI ");
        
            }
             else if(pictureBox2.Left>label6.Left)
            {
                timer1.Stop();
                MessageBox.Show("TOFAŞ KAZANDI");
            }
            else if (pictureBox3.Left > label6.Left)
            {
                timer1.Stop();
                MessageBox.Show("TOGG KAZANDI");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    label7.Text = "SEÇİLEN: TOROS";
                    break;

                case 1:
                    label7.Text = "SEÇİLEN: TOFAŞ";
                    break;

                case 2:
                    label7.Text = "SEÇİLEN: TOGG";
                    break;
            }

        }
    }
}
