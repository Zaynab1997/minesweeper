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
    public partial class Form1 : Form
    { DataSet d = new DataSet();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            //this.Cursor = new Cursor(GetType(), "gam1232 - Copy - Copy.cur");
            player.SoundLocation = "button-21.wav";

        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            Form0 f = new Form0();
            f.Show();
            Hide();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        { //d.ReadXml(@"C:\Users\HP\Documents\Visual Studio 2015\Projects\minesweeper v1\minesweeper v1\bin\Debug\minesweeperdata.xml");
           // if (d.Tables[0].Rows.Count == 1) MessageBox.Show("Kindly register first");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.ReadXml(Application.StartupPath + @"\minesweeperdata.xml");

            if (d.Tables[0].Rows.Count == 1) MessageBox.Show("Kindly register first");
            Form5 y = new Form5();
            y.Show();
            Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void meGlassButton1_Click(object sender, EventArgs e)
        {
            d.ReadXml(Application.StartupPath + @"\minesweeperdata.xml");

            if (d.Tables[0].Rows.Count == 1) MessageBox.Show("Kindly register first");
            player.Play();
            Form5 y = new Form5();
            y.Show();
            Hide();
        }

        private void meGlassButton3_Click(object sender, EventArgs e)
        {player.Play();
            var result = MessageBox.Show("Are you sure?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Application.Exit();
            
        }

        private void meGlassButton2_Click(object sender, EventArgs e)
        {
            player.Play();
            Form2 f = new Form2();
            f.ShowDialog();

        }

        private void meGlassButton4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void meGlassButton4_Click(object sender, EventArgs e)
        {

            Form0 f = new Form0();
            f.Show();
            Hide();
        }

        private void meGlassButton4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
