using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SikorskiD_tire_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tireWidth = int.Parse(textBox1.Text);
            int profileHeight = int.Parse(textBox2.Text);
            int rimDiameter = int.Parse(textBox3.Text);

            double rimDiameterMm = rimDiameter * 25.4;
            double profileHeightMm = (tireWidth * profileHeight) / 100;
            double outerDiameter = 2 * profileHeightMm + rimDiameterMm;

            textBox4.Text = Convert.ToString(tireWidth);
            textBox5.Text = Convert.ToString(profileHeightMm);
            textBox6.Text = Convert.ToString(rimDiameterMm);
            textBox7.Text = Convert.ToString(outerDiameter);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
