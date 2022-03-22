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
    public partial class Form3 : Form
    {
        DataSet d = new DataSet();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        Label l1 = new Label();
        public Form3()
        {
            InitializeComponent();
            // this.Cursor = new Cursor(GetType(), "gam1232 - Copy - Copy.cur");
            player.SoundLocation = "button-21.wav";
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            d.ReadXml("minesweeperdata.xml");
        }

     

        private void meGlassButton4_Click(object sender, EventArgs e)
        {
            player.Play();
            bool name = false, pass = false, found = false;
            DataTable dt = new DataTable();


            if (string.CompareOrdinal(textBox2.Text.ToString(), textBox3.Text.ToString()) != 0)
            {label4.Text = "Password doesn't match!";
             
                textBox3.Text = "";

            }
            else pass = true;


            foreach (DataRow dr in d.Tables[0].Rows)
                if (string.CompareOrdinal(dr[0].ToString(), textBox1.Text) == 0)
                {label4.Text = "Username already exists!";
                  
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    found = true;
                }

            if (!found) name = true;


            if ((name) && (pass))
            {
                DataRow drr = d.Tables[0].NewRow();
                drr[0] = textBox1.Text;
                Form2.user = textBox1.Text;
                Form4.correct = true;
                drr[1] = Bombtable.pass(textBox2.Text);
                drr[2] = 10;
                d.Tables[0].Rows.Add(drr);

                dt.TableName = textBox1.Text.ToString();
                DataColumn dc = new DataColumn("level", typeof(int));
                dt.Columns.Add(dc);
                dc = new DataColumn("time", typeof(int));
                dt.Columns.Add(dc);
                d.Tables.Add(dt);


                drr = d.Tables[d.Tables.Count - 1].NewRow();
                drr[0] = 1; drr[1] = 0;
                d.Tables[d.Tables.Count - 1].Rows.Add(drr);
                drr = d.Tables[d.Tables.Count - 1].NewRow();
                drr[0] = 2; drr[1] = 0;
                d.Tables[d.Tables.Count - 1].Rows.Add(drr);
                drr = d.Tables[d.Tables.Count - 1].NewRow();
                drr[0] = 3; drr[1] = 0;
                d.Tables[d.Tables.Count - 1].Rows.Add(drr);
                drr = d.Tables[d.Tables.Count - 1].NewRow();
                drr[0] = 4; drr[1] = 0;
                d.Tables[d.Tables.Count - 1].Rows.Add(drr);
                drr = d.Tables[d.Tables.Count - 1].NewRow();
                drr[0] = 5; drr[1] = 0;
                d.Tables[d.Tables.Count - 1].Rows.Add(drr);
                this.Close();



                d.WriteXml("minesweeperdata.xml");
            }
        }
    }
}
