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
   
   
    public partial class Form2 : Form
    {     public static string user;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        DataSet d = new DataSet();
        public Form2()
        {
            InitializeComponent();
            // this.Cursor = new Cursor(GetType(), "gam1232 - Copy - Copy.cur");
            player.SoundLocation = "button-21.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Hide();
            Dispose();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {d.ReadXml("minesweeperdata.xml");
            for (int i = 1; i < d.Tables.Count; i++)
               listBox1.Items.Add(d.Tables[i].TableName.ToString());
       
        }

      

        private void meGlassButton1_Click(object sender, EventArgs e)
        {
            player.Play();
            Form3 f = new Form3();
            f.Show();
            Hide();
            Dispose();

        }

        private void meGlassButton2_Click(object sender, EventArgs e)
        {
            player.Play();
            try
            {
                user = listBox1.Items[listBox1.SelectedIndex].ToString();
                Form4 f = new Form4();
                f.ShowDialog();
                Hide();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Choose player!");
            }
        }
    }
}
