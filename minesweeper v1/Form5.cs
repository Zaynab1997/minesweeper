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
    public partial class Form5 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Form7 f = new Form7();
        public Form5()
        {
            InitializeComponent();
            player.SoundLocation = "button-21.wav";

        }
        public static bool adv = false;
      
        public static int number1,number2,bombs;
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            number1 = 9;
            number2 = 9;
            bombs = 10;
            Form7 f = new Form7();
            f.Size= new Size(90 + 25 * number1, 150 + 25 * number2);
            f.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
            number1 = 16;
            number2 = 16;
            bombs = 40;
            Form7 f = new Form7();
          //  f.Size = new Size(80 + 25 * number1, 140 + 25 *number2);
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Refresh();
            number1 = 30;
            number2 = 16;
            bombs = 99;
            Form7 f = new Form7();
          //  f.Size = new Size(80 + 25 *number1, 140 + 25 * number2);
            f.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adv = true;
            Form8 f = new Form8();
            f.Show();
            Hide();

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void meGlassButton1_Click(object sender, EventArgs e)
        {
            player.Play();
            this.Refresh();
            number1 = 9;
            number2 = 9;
            bombs = 10;
            Form7 f = new Form7();
            f.Size = new Size(90 + 25 * number1, 150 + 25 * number2);
            f.Show();
            Hide();
        }

        private void meGlassButton2_Click(object sender, EventArgs e)
        {
            player.Play();
            this.Refresh();
            number1 = 16;
            number2 = 16;
            bombs = 40;
            Form7 f = new Form7();
             f.Size = new Size(80 + 25 * number1, 140 + 25 *number2);
            f.Show();
            Hide();
        }

        private void meGlassButton3_Click(object sender, EventArgs e)
        {
            player.Play();
            this.Refresh();
            number1 = 30;
            number2 = 16;
            bombs = 99;
            Form7 f = new Form7();
            f.Size = new Size(80 + 25 *number1, 140 + 25 * number2);
            f.Show();
            Hide();
        }

        private void meGlassButton4_Click(object sender, EventArgs e)
        {
            player.Play();
            adv = true;
            Form8 f = new Form8();
            f.Show();
            Hide();

        }

        private void meGlassButton5_Click(object sender, EventArgs e)
        {
            player.Play();
            Form6 f1 = new Form6();
            f1.Show();
            Hide();

        }

        private void meGlassButton5_Click_1(object sender, EventArgs e)
        {

        }

        private void meGlassButton6_Click(object sender, EventArgs e)
        {
            player.Play();
            Form6 f1 = new Form6();
            f1.Show();
            Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Form7.count = 0;//?
            if (!Form4.correct)
            {
              
                meGlassButton4.Enabled = false;
                meGlassButton4.BackColor = Color.Gray;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f1 = new Form6();
            f1.Show();

        }
     
       
    }
}
