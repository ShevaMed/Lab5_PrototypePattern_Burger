using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurgerBuilderPrototypeLib.BurgerFactory;
using BurgerBuilderPrototypeLib.Prototypes;

namespace Lab5_PrototypePattern_BurgerBuilder
{
    public partial class Form1 : Form
    {
        Hamburger hamburger = BurgerFactory.MakeHamburger("..\\..\\images\\hamburger.jpg");
        McChicken mcChicken = BurgerFactory.MakeMcChicken("..\\..\\images\\mcChicken.jpg");
        FiletOFish filetOFish = BurgerFactory.MakeFiletOFish("..\\..\\images\\fileOFish.jpg");

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = hamburger.img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hamburger hamburger1 = (Hamburger)hamburger.Clone();
            pictureBox2.Image = hamburger1.img;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = mcChicken.img;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            McChicken mcChicken1 = (McChicken)mcChicken.Clone();
            pictureBox4.Image = mcChicken1.img;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = filetOFish.img;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FiletOFish filetOFish1 = (FiletOFish)filetOFish.Clone();
            pictureBox6.Image = filetOFish1.img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
