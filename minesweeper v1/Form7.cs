using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper_v1
{
    

    public partial class Form7 : Form
    {public static int count ;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer playerb = new System.Media.SoundPlayer();
        
        System.Media.SoundPlayer playerl = new System.Media.SoundPlayer();
        System.Media.SoundPlayer playerfl = new System.Media.SoundPlayer();
        Panel p = new Panel();
       public static Button[,] b;
        Label hin = new Label();
        Label lives = new Label();
        PictureBox pic = new PictureBox();
        Button hint = new Button();
        public static string time;
        public static bool win = false;
        int hint7 = Form8.hints8;
        public Form7()
        {
            this.Size = new Size(120 + 25 * Form5.number1, 180 + 25 * Form5.number2);
            InitializeComponent();
            player.SoundLocation = "button-21.wav";
            playerb.SoundLocation = "Bomb_Exploding-Sound_Explorer-68256487.wav";
            playerl.SoundLocation = "button-21.wav";
           
            playerfl.SoundLocation = "button-22.wav";
            p.Left = 30;
            p.Top = 80;
            p.Size = new Size(25 * Form5.number1, 25 * Form5.number2);
            this.Controls.Add(p);
            label1.Text = Form5.bombs.ToString();
            label2.Text = "0";
            b = new Button[Form5.number1, Form5.number2];
            if (Form5.adv)
            {
                hint = new Button();
                hint.Size = new Size(35, 35);
                hint.Left = label2.Left + label2.Width;
                hint.Top = label2.Top-5;
                hint.Text = "Hints";
                this.Controls.Add(hint);

                hin.Size = new Size(label1.Width, label1.Height);
                hin.Left = hint.Left + hint.Width;
                hin.Top = label2.Top;
               if(hint7<0) hin.Text ="0";
                else hin.Text = hint7.ToString();
                this.Controls.Add(hin);
                hint.Click += new EventHandler(help);
                    } }
        private void flag(object sender, MouseEventArgs e)
        {
            playerfl.Play();
            if (int.Parse(label1.Text) <= 0) return;
            Button b = (Button)sender;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {if (b.BackgroundImage == null)
                {
                     b.BackgroundImage = Image.FromFile("Actions-flag-blue-icon.jpg");
                    label1.Text = (int.Parse(label1.Text) - 1).ToString();
                }
                else
                {
                    b.BackgroundImage = null;
                    label1.Text = (int.Parse(label1.Text) + 1).ToString();
                }
            }
            timer1.Enabled = true;
        }

        private void buttonclick(object sender, EventArgs e)

        {
            player.Play();

            if (int.Parse(label1.Text) != 0)
            {
                timer1.Enabled = true;
                Button b1 = (Button)sender;
                b1.FlatStyle = FlatStyle.Popup;
                b1.BackColor = Color.Gray;
                if (string.CompareOrdinal(b1.Tag.ToString(), "*") == 0)
                {
                    if (Form5.adv)
                    {
                        if (Form8.lives > 0) { b1.Enabled = false;
                            lives.Text = (--Form8.lives).ToString();
                            b1.BackgroundImage = Image.FromFile("unnamed.png");
                            label1.Text = (int.Parse(label1.Text) - 1).ToString();
                            this.Controls.Add(lives); }
                        if (Form8.lives == 0)
                        {
                            time = label4.Text + ":" + label3.Text + label2.Text;
                             timer1.Enabled = false;   win = false;
                            foreach (Button be in p.Controls.OfType<Button>())
                            {
                                if ((string.CompareOrdinal(be.Tag.ToString(), "0") != 0) && (string.CompareOrdinal(be.Tag.ToString(), "*") != 0))
                                    be.Text = be.Tag.ToString();
                                else if ((string.CompareOrdinal(be.Tag.ToString(), "*") == 0) && (be.BackgroundImage == null))
                                { be.BackgroundImage = Image.FromFile("unnamed.png"); playerb.Play();  }
                                be.FlatStyle = FlatStyle.Popup;
                                be.BackColor = Color.Gold;
                                be.Enabled = true;
                                //form10 winning or losing showing time and score , new game. return to menu map there is in xml writing if lost
                            }
                           
                            p.Enabled = false;
                            Form10 f = new Form10();
                            timer1.Enabled = false;
                            f.ShowDialog();
                            Hide();
                           
                        }
                    }

                    if (!Form5.adv)
                    {
                        win = false;
                        time = label4.Text + ":" + label3.Text + label2.Text;
                       timer1.Enabled = false;
                        foreach (Button be in p.Controls.OfType<Button>())
                        {
                            if ((string.CompareOrdinal(be.Tag.ToString(), "0") != 0) && (string.CompareOrdinal(be.Tag.ToString(), "*") != 0))
                                be.Text = be.Tag.ToString();
                            else if ((string.CompareOrdinal(be.Tag.ToString(), "*") == 0) && (be.BackgroundImage == null))
                            { be.BackgroundImage = Image.FromFile("unnamed.png"); playerb.Play(); }
                                be.FlatStyle = FlatStyle.Popup;
                            be.BackColor = Color.Gray;

                            //form10 winning or losing showing time and score , new game. return to menu map there is in xml writing if lost
                        }

                        p.Enabled = false;
                        Form10 f = new Form10();
                        f.ShowDialog();
                        Hide();

                    }
                }
            
                if ((string.CompareOrdinal(b1.Tag.ToString(), "0") != 0) && (string.CompareOrdinal(b1.Text.ToString(), "") == 0))
                    b1.Text = b1.Tag.ToString();

                else if (string.CompareOrdinal(b1.Tag.ToString(), "0") == 0)
                {
                    int x = ((b1.Left) / 25), y = ((b1.Top) / 25);

                    Reveal(b, x, y);
                }
            }
            if (int.Parse(label1.Text) == 0)
                foreach (Button be in p.Controls.OfType<Button>())
                    if ((string.CompareOrdinal(be.Tag.ToString(), "*") == 0) && (be.BackgroundImage != null))
                    {
                        Form10 f = new Form10();
                        f.ShowDialog();
                        win = false; timer1.Enabled = false;
                    }
                    else { win = true; Form10 f = new Form10();
                        f.ShowDialog();Hide(); timer1.Enabled = false; break; }

        }
        public static void Reveal(Button[,] br, int x, int y)
        {
            if ((string.CompareOrdinal(br[x, y].Tag.ToString(), "0") != 0) && (string.CompareOrdinal(br[x, y].Tag.ToString(), "*") != 0))
            {
                br[x, y].Text = br[x, y].Tag.ToString(); br[x, y].FlatStyle = FlatStyle.Popup; br[x, y].BackColor = Color.Gray;
                return;
            }
            if (string.CompareOrdinal(br[x, y].Tag.ToString(), "0") == 0)
            {
                br[x, y].FlatStyle = FlatStyle.Popup;
                br[x,y].BackColor = Color.Gray;
                br[x, y].Tag = "";
                if (x == 0)
                {
                    if (y == 0)
                    {
                        Reveal(br, 1, 0);
                        Reveal(br, 1, 1);
                        Reveal(br, 0, 1);
                    }
                    if (y == Form5.number2 - 1)
                    {

                        Reveal(br, 0, Form5.number2 - 2);
                        Reveal(br, 1, Form5.number2 - 2);
                        Reveal(br, 1, Form5.number2 - 1);
                    }
                }
                if (x == Form5.number1 - 1)
                {
                    if (y == 0)
                    {

                        Reveal(br, Form5.number1 - 2, 0);
                        Reveal(br, Form5.number1 - 2, 1);
                        Reveal(br, Form5.number1-1, 1);
                    }
                    if (y == Form5.number2 - 1)
                    {

                        Reveal(br, Form5.number1-1, Form5.number2-1);
                        Reveal(br, Form5.number1 - 2, Form5.number2-1);
                        Reveal(br, Form5.number1 - 2, Form5.number2 - 2);
                    }
                }
                if ((x != 0) && (x != Form5.number1 - 1))
                {
                    if (y == 0)
                    {

                        Reveal(br, x - 1, 0);
                        Reveal(br, x - 1, 0);
                        Reveal(br, x, 1);
                        Reveal(br, x + 1, 1);
                        Reveal(br, x + 1, 0);
                    }
                    if (y == Form5.number2 - 1)
                    {

                        Reveal(br, x - 1, Form5.number2 - 1);
                        Reveal(br, x - 1, Form5.number2 - 1);
                        Reveal(br, x, Form5.number2 - 2);
                        Reveal(br, x + 1, Form5.number2 - 2);
                        Reveal(br, x + 1, Form5.number2 - 1);
                    }
                }
                if ((y != 0) && (y != Form5.number2 - 1))
                {
                    if (x == 0)
                    {

                        Reveal(br, 0, y - 1);
                        Reveal(br, 0, y - 1);
                        Reveal(br, 1, y);
                        Reveal(br, 1, y + 1);
                        Reveal(br, 0, y + 1); ;
                    }
                    if (x == Form5.number1 - 1)
                    {

                        Reveal(br, Form5.number1 - 1, y - 1);
                        Reveal(br, Form5.number1 - 1, y - 1);
                        Reveal(br, Form5.number1 - 2, y);
                        Reveal(br, Form5.number1 - 2, y + 1);
                        Reveal(br, Form5.number1 - 1, y + 1);
                    }
                }
                if ((x != 0) && (x != Form5.number1 - 1) && (y != 0) && (y != Form5.number2 - 1))
                {

                    Reveal(br, x + 1, y - 1);
                    Reveal(br, x, y - 1);
                    Reveal(br, x - 1, y - 1);
                    Reveal(br, x, y + 1);
                    Reveal(br, x + 1, y + 1);
                    Reveal(br, x - 1, y + 1);
                    Reveal(br, x - 1, y);
                    Reveal(br, x + 1, y);
                }
            }
        }



        private void Form7_Load(object sender, EventArgs e)
        {
            if (Form5.adv)
            { lives.Size = new Size(label1.Width, label1.Height);
                lives.Top = label1.Top;
                lives.Left = (label1.Left + label1.Width + label2.Left) / 2;
                lives.Text = Form8.lives.ToString();
                this.Controls.Add(lives);

                pic.Size = new Size(label1.Width, label1.Height);
                pic.Left = lives.Left - pic.Width;
                pic.Top = label1.Top;
                pic.ImageLocation = "animated-heart.gif";
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pic);

                if (Form5.adv)
                {
                    hint = new Button();
                    hint.Size = new Size(35, 35);
                    hint.Left = label2.Left + label2.Width;
                    hint.Top = label2.Top-5;
                    hint.Text = "Hints";
                    this.Controls.Add(hint);

                    hin.Size = new Size(label1.Width, label1.Height);
                    hin.Left = hint.Left + hint.Width;
                    hin.Top = label2.Top;
                    if (hint7 < 0) hin.Text = "0";
                    else hin.Text = hint7.ToString();
                    this.Controls.Add(hin);
                    hint.Click += new EventHandler(help);

                }


            }

            string[,] map;
            map = Bombtable.Map(Form5.bombs, Form5.number1, Form5.number2);

            for (int i = 0; i < Form5.number1; i++)
                for (int j = 0; j < Form5.number2; j++)
                {//if (string.CompareOrdinal(b[j].Text.ToString(), "*") == 0)
                 //     b[i,j].Image = Image.FromFile("mine2.ico");
                    b[i, j] = new Button();
                    b[i, j].Size = new Size(25, 25);
                    b[i, j].Top =  j * 25;
                    b[i, j].Left =   i * 25;
                    b[i, j].BackColor = Color.Gold;
                    b[i, j].Tag = map[i, j];
                    b[i, j].ForeColor = Color.Black;
                   
                    p.Controls.Add(b[i, j]);

                    //if (string.CompareOrdinal(map[i,j].ToString(),"0")==0)
                    //b[j].Click+=
                    // else


                    b[i, j].Click += new EventHandler(buttonclick);


                    b[i, j].MouseDown += new MouseEventHandler(flag);
                }


        }
        private void help(object sender, EventArgs e)
        {  --hint7;
            if (hint7 >= 0)

            {
                hin.Text = hint7.ToString();
                this.Controls.Add(hin);
                foreach (Button b1 in p.Controls.OfType<Button>())
                    if ((b1.BackgroundImage == null) && (string.CompareOrdinal(b1.Tag.ToString(), "*") == 0))
                    {
                        b1.BackColor = Color.Aqua;
                        p.Controls.Add(b1); break;
                    }
            }
            if (hint7 < 0)
            { hin.Text = "0";
                this.Controls.Add(hin);
                Form9 meth = new Form9();
                //Thread t = new Thread(new ThreadStart(meth));
                Form9 f = new Form9();
                f.ShowDialog();
                
                foreach (Button b1 in p.Controls.OfType<Button>())
                if ((b1.Image == null) && (string.CompareOrdinal(b1.Tag.ToString(), "*") == 0) && (Form9.right))
                {
                    b1.BackColor = Color.Aqua;
                    p.Controls.Add(b1);
                        break;}
            } }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = (1 + int.Parse(label2.Text)).ToString();
            
            if (string.CompareOrdinal(label2.Text, "10") == 0)
            {
                label3.Text = (1 + int.Parse(label3.Text)).ToString();
                label2.Text = "0";
            }
            if (string.CompareOrdinal(label3.Text, "6") == 0)
            {
                label4.Visible = true;
                label5.Visible = true;
                label3.Text = "0";
                label4.Text = label4.Text = (1 + int.Parse(label4.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(count.ToString());
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Dispose();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?\nAll improuvement will be lost.","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {this.Dispose();
                Form8.lives = 3;
                hin.Text = Form8.hints8.ToString();
                this.Controls.Add(hin);
                Form7 f = new Form7();
                f.Show();
            }
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Dispose();
        }
    }
    }

