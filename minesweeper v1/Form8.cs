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
    public partial class Form8 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        DataSet d = new DataSet();
        public static int level;
        public static RadioButton[] rd = new RadioButton[13];
        public Form8()
        {
            InitializeComponent();
            player.SoundLocation = "button-21.wav";
            rd[0] = radioButton1; rd[1] = radioButton2; rd[2] = radioButton3; rd[3] = radioButton4; rd[4] = radioButton5; rd[5] = radioButton6;
            rd[6] = radioButton7; rd[7] = radioButton8; rd[8] = radioButton9; rd[9] = radioButton10; rd[10] = radioButton11; rd[11] = radioButton12;
            rd[12] = radioButton13;

        }
        public static int lives;
        public static int hints8;

        private void button1_Click(object sender, EventArgs e)
        {
            level = 1;
            Form5.number1 = 9;
            Form5.number2 = 9;
            Form5.bombs = 10;
            Form7 f = new Form7();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            level = 2;
            Form5.number1 = 15;
            Form5.number2 = 12;
            Form5.bombs = 36;
            Form7 f = new Form7();
            f.Size = new Size(90 + 25 * Form5.number1, 150 + 25 * Form5.number2);
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            level = 3;
            Form5.number1 = 18;
            Form5.number2 = 20;
            Form5.bombs = 72;
            Form7 f = new Form7();
            f.Size = new Size(90 + 25 * Form5.number1, 150 + 25 * Form5.number2);
            f.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            level = 4;
            Form5.number1 = 20;
            Form5.number2 = 25;
            Form5.bombs = 144;
            Form7 f = new Form7();
            f.Size = new Size(90 + 25 * Form5.number1, 150 + 25 * Form5.number2);
            f.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            level = 5;
            Form5.number1 = 24;
            Form5.number2 = 30;
            Form5.bombs = 288;
            Form7 f = new Form7();
            f.Size = new Size(90 + 25 * Form5.number1, 150 + 25 * Form5.number2);
            f.Show();
            Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            Hide();

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            d.ReadXml(Application.StartupPath + @"\minesweeperdata.xml");
            foreach (DataRow dr1 in d.Tables[0].Rows)
                if (string.CompareOrdinal(dr1[0].ToString(), Form2.user.ToString()) == 0)
                    hints8 = int.Parse(dr1[2].ToString());
            lives = 3;

        }

        private void meGlassButton1_Click(object sender, EventArgs e)
        {
            level = 1;
            Form5.number1 = 9;
            Form5.number2 = 9;
            Form5.bombs = 10;
            Form7 f = new Form7();
            f.Size = new Size(90 + 25 * Form5.number1, 150 + 25 * Form5.number2);
            f.Show();
            Hide();
        }

        private void meGlassButton3_Click(object sender, EventArgs e)
        {
            level = 2;
            Form5.number1 = 15;
            Form5.number2 = 12;
            Form5.bombs = 36;
            Form7 f = new Form7();
            f.Size = new Size(90 + 25 * Form5.number1, 150 + 25 * Form5.number2);
            f.Show();
            Hide();
        }

        private void meGlassButton4_Click(object sender, EventArgs e)
        {
            level = 4;
            Form5.number1 = 20;
            Form5.number2 = 25;
            Form5.bombs = 144;
            Form7 f = new Form7();
            f.Size = new Size(90 + 25 * Form5.number1, 150 + 25 * Form5.number2);
            f.Show();
            Hide();
        }

        private void meGlassButton6_Click(object sender, EventArgs e)
        {
            level = 3;
            Form5.number1 = 18;
            Form5.number2 = 20;
            Form5.bombs = 72;
            Form7 f = new Form7();
            f.Size = new Size(90 + 25 * Form5.number1, 150 + 25 * Form5.number2);
            f.Show();
            Hide();
        }

        private void meGlassButton5_Click(object sender, EventArgs e)
        {
            level = 5;
            Form5.number1 = 24;
            Form5.number2 = 30;
            Form5.bombs = 288;
            Form7 f = new Form7();
            f.Size = new Size(90 + 25 * Form5.number1, 150 + 25 * Form5.number2);
            f.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i=0;
            rd[i++].Checked = true;
            if (i == 3) i = 0;
        }
    }
}
