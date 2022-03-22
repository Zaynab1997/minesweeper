using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Diagnostics;
namespace minesweeper_v1
{ 
    public partial class Form10 : Form
    { DataSet d = new DataSet();

        int time1 = 0;
        
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        //if time is heigher
        public Form10()
        { 
            InitializeComponent();
            player.SoundLocation = "button-21.wav";
            label3.Text = Form7.time;
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            Form8.lives = 3;
            f.Show();
            this.Dispose();

        }

    

        private void Form10_Load(object sender, EventArgs e)
        {
            label4.Text = (time1*100).ToString();
            d.ReadXml("minesweeperdata.xml");
            if (!Form5.adv)
            {
                meGlassButton3.Enabled = false;
                meGlassButton3.BackColor = Color.Gold;
            }
            label3.Text = Form7.time;
           
                label5.Text = Form2.user;
                if (Form7.win)
                {
                    label6.Text = "Congratulations,you won!";
                   meGlassButton2.Text = "Play Mini game";
                    pictureBox1.Image = Image.FromFile("ba-awesome-colorful-fireworks-animated-gif-image-s.gif");
                
                }
                else
                {
                    meGlassButton2.Text = "Try another game";
                    label6.Text = "Hard luck";
                    meGlassButton3.Enabled = false;
                }
           



        }

        private void button2_Click(object sender, EventArgs e)
        {if ((Form5.adv) && (Form7.win))
                {
                    foreach (DataRow dr1 in d.Tables[Form2.user].Rows)
                        if (string.CompareOrdinal(dr1[0].ToString(), Form8.level.ToString()) == 0)
                        {if (int.Parse(dr1[1].ToString())<time1)
                            dr1[1] = time1;
                            d.Tables[Form2.user].Rows.Add(dr1);
                        }


                
                    d.WriteXml("minesweeperdata.xml");
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p = Process.Start(@"BattleShipAlgorithm\BattleShipAlgorithm\bin\Debug\BattleShipAlgorithm.exe");
        }

        private void meGlassButton1_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            Form8.lives = 3;
            f.Show();
            this.Dispose();

        }

        private void meGlassButton3_Click(object sender, EventArgs e)
        {

            
                if ((Form5.adv) && (Form7.win))
                {
                try
                {
                    foreach (DataRow dr1 in d.Tables[Form2.user].Rows)
                        if (string.CompareOrdinal(dr1[0].ToString(), Form8.level.ToString()) == 0)
                        {
                            dr1[1] = (int.Parse(Form7.time[0].ToString()) * 60) + int.Parse(Form7.time[2].ToString());
                            d.Tables[Form2.user].Rows.Add(dr1);
                        }
                    this.Dispose();
                }catch(NullReferenceException ex) { Form8 f = new Form8(); f.Show();Dispose(); }
                        }

            d.WriteXml("minesweeperdata.xml");
        }

        private void meGlassButton2_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p = Process.Start(@"BattleShipAlgorithm\BattleShipAlgorithm\bin\Debug\BattleShipAlgorithm.exe");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
