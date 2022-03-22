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
    public partial class Form4 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        DataSet d = new DataSet();
       
        public Form4()
        {
            InitializeComponent();
            player.SoundLocation = "button-21.wav";
            //    this.Cursor = new Cursor(GetType(), "gam1232 - Copy - Copy.cur");
        }
        public static bool correct;
        private void Form4_Load(object sender, EventArgs e)
        {
            d.ReadXml(Application.StartupPath + @"\minesweeperdata.xml");
            label1.Text= "Welcome " + Form2.user.ToString() + ". Kindly sign in.";
            
               
                
        }

        
        

        private void meGlassButton2_Click(object sender, EventArgs e)
        {
            player.Play();
            foreach (DataRow dr in d.Tables[0].Rows)
                if (string.CompareOrdinal(dr[0].ToString(), Form2.user.ToString()) == 0)
                    if (string.CompareOrdinal(dr[1].ToString(),Bombtable.pass(textBox1.Text)) != 0)
                    {

                        label1.Text = "Wrong password";

                    }
                    else
                    {
                        correct = true;


                        Hide();
                        Dispose();
                        // open the start form
                    }
        }
    }
}
