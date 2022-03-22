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
    public partial class Form6 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form6()
        {
            InitializeComponent();
            player.SoundLocation = "button-21.wav";
        }
      
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void meGlassButton1_Click(object sender, EventArgs e)
        {
            bool l1 = false, l2 = false, l3 = false;
            try
            {
                if ((int.Parse(textBox1.Text) >= 9) && (int.Parse(textBox1.Text) <= 30))
                {
                    Form5.number1 = int.Parse(textBox1.Text);
                    l1 = true;

                }

                else textBox1.Text = ""; }
            catch (FormatException ex)
            {
                label4.Text = "Wrong format";
                textBox1.Text = "";
              
            }

            try
            {
                if ((int.Parse(textBox2.Text) >= 9) && (int.Parse(textBox2.Text) <= 24))
                {
                    Form5.number2 = int.Parse(textBox2.Text);
                    l2 = true;
                }
                else textBox2.Text = "";

            }
            catch (FormatException ex)
            {
                label4.Text = "Wrong format";
                textBox2.Text = "";
              
            }
            try
            {
                if ((int.Parse(textBox3.Text) >= 10) && (int.Parse(textBox3.Text) <= 667))
                {
                    Form5.bombs = int.Parse(textBox3.Text);
                    l3 = true;
                }
                else textBox3.Text = "";
            }
            catch (FormatException ex)
            {
                label4.Text = "Wrong format";
                textBox3.Text = "";
           }
            try
            {
                if (int.Parse(textBox3.Text) > ((int.Parse(textBox1.Text) * int.Parse(textBox2.Text)) - 10))
                {
                    label4.Text = "Outside the bounded area";
                    l3 = false;

                    textBox3.Text = "";
                }
            }
            catch (FormatException ex)
            {
                label4.Text = "Wrong format";
                textBox3.Text = "";
           
            }

            if ((!l1) || (!l2) || (!l3))
                {

                    label4.Text = "Outside the bounded area";

                }
                if ((l1) && (l2) && (l3))
                {
                    Form7 f = new Form7();
                    f.Size = new Size(80 + 25 * Form5.number1, 140 + 25 * Form5.number2);
                    f.Show();
                    this.Dispose();
                    //left size proportion
                }
            }
        
        

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Dispose();
            
        }

        
    }
}
