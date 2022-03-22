using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace minesweeper_v1
{// MEEEEEE
    public partial class Form9 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public static string[,] q = new string[5, 30];
        public static bool right = false;
        public Form9()
        {
            InitializeComponent();
            player.SoundLocation = "button-21.wav";
            StreamReader fr = new StreamReader("HINTS.txt");
            for (int j = 0; j < 30; j++)
                for (int i = 0; i < 5; i++)
                    q[i, j] = fr.ReadLine();

            fr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rd in this.Controls.OfType<RadioButton>())
            {
                if ((rd.Checked) && (string.CompareOrdinal(rd.Tag.ToString(), "") != 0))
                {
                    MessageBox.Show("CORRECT"); this.Close(); right = true;

                    break;
                }
                if ((rd.Checked == true) && (string.CompareOrdinal(rd.Tag.ToString(), "Ci") != 0))
                { MessageBox.Show("Wrong answer"); this.Close(); break; }
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

            label1.Text = q[0, -10+ Form8.hints8];
            radioButton1.Text = q[1, -10+ Form8.hints8];
            radioButton2.Text = q[2,  - 10+Form8.hints8];
            radioButton3.Text = q[3,  - 10+Form8.hints8];
            if (string.CompareOrdinal(q[4, -10+Form8.hints8 ], "A") == 0)
            {
                radioButton1.Tag = "Ci";
                radioButton2.Tag = "";
                radioButton3.Tag = "";
            }
            if (string.CompareOrdinal(q[4, -10+Form8.hints8 ], "B") == 0)
            {
                radioButton2.Tag = "Ci";
                radioButton1.Tag = "";
                radioButton3.Tag = "";
            }
            if (string.CompareOrdinal(q[4, -10+Form8.hints8], "C") == 0)
            {
                radioButton2.Tag = "";
                radioButton1.Tag = "";
                radioButton3.Tag = "Ci";
            }
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void meGlassButton1_Click(object sender, EventArgs e)
        {

            foreach (RadioButton rd in this.Controls.OfType<RadioButton>())
            {
                if ((rd.Checked) && (string.CompareOrdinal(rd.Tag.ToString(), "") != 0))
                {
                    MessageBox.Show("CORRECT"); this.Close(); right = true;

                    break;
                }
                if ((rd.Checked == true) && (string.CompareOrdinal(rd.Tag.ToString(), "Ci") != 0))
                { MessageBox.Show("Wrong answer"); this.Close(); break; }
            }
        }
    }
}

