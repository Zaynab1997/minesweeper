using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper_v1
{
    public partial class Form0 : Form
    {int count = 3; System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form0()
        {
            
            InitializeComponent();
            player.SoundLocation = "button-21.wav";
            meGlassButton2.Enabled = false;
            
        }

        private void Form0_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Form1 f = new Form1();
            f.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {--count;
            if (count == 2) pictureBox1.Image = Image.FromFile(@"C:\Users\HP\Desktop\acsdasc1.png");
            if (count == 1) { pictureBox1.Image = Image.FromFile(@"C:\Users\HP\Desktop\Untitled4.png");
                                     meGlassButton2.Enabled = true; meGlassButton1.Enabled = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void meGlassButton1_Click(object sender, EventArgs e)
        {
            --count;
            if (count == 2) pictureBox1.Image = Image.FromFile(@"acsdasc1.png");
            if (count == 1)
            {
                pictureBox1.Image = Image.FromFile(@"Untitled4.png");
                meGlassButton2.Visible = true; meGlassButton2.Enabled = true; meGlassButton1.Visible = false;
            }
        }

        private void meGlassButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
