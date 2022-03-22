using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleShipAlgorithm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
    
        
        List<Label> PSelectedTiles = new List<Label>();
        Label[,] PTiles = new Label[8, 8];
        Label[,] OTile = new Label[8, 8];
        Queue<int> XAlgoQueue = new Queue<int>();
        Queue<int> YAlgoQueue = new Queue<int>();
        bool[,] Otiles = new bool[8, 8];
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            cbShip.Enabled = false;
            cbX.Enabled = false;
            cbY.Enabled = false;
            #region AllocatingTiles
            PTiles[0,0]=Ptile00;
            PTiles[0, 1] = Ptile01;
            PTiles[0, 2] = Ptile02;
            PTiles[0,3]= Ptile03;
            PTiles[0, 4] = Ptile04;
            PTiles[0, 5] = Ptile05;
            PTiles[0, 6] = Ptile06;
            PTiles[0, 7] = Ptile07;
            PTiles[1, 0] = Ptile10;
            PTiles[1, 1] = Ptile11;
            PTiles[1, 2] = Ptile12;
            PTiles[1, 3] = Ptile13;
            PTiles[1, 4] = Ptile14;
            PTiles[1, 5] = Ptile15;
            PTiles[1, 6] = Ptile16;
            PTiles[1, 7] = Ptile17;
            PTiles[2, 0] = Ptile20;
            PTiles[2, 1] = Ptile21;
            PTiles[2, 2] = Ptile22;
            PTiles[2, 3] = Ptile23;
            PTiles[2, 4] = Ptile24;
            PTiles[2, 5] = Ptile25;
            PTiles[2, 6] = Ptile26;
            PTiles[2, 7] = Ptile27;
            PTiles[3,0] = Ptile30;
            PTiles[3,1]=Ptile31;
            PTiles[3,2]=Ptile32;
            PTiles[3,3]=Ptile33;
            PTiles[3,4]=Ptile34;
            PTiles[3,5]=Ptile35;
            PTiles[3,6]=Ptile36;
            PTiles[3, 7]=Ptile37;
            PTiles[4,0]=Ptile40;
            PTiles[4, 1] = Ptile41;
            PTiles[4,2]=Ptile42;
            PTiles[4,3]=Ptile43;
            PTiles[4,4]=Ptile44;
            PTiles[4,5]=Ptile45;
            PTiles[4,6]=Ptile46;
            PTiles[4,7]=Ptile47;
            PTiles[5,0]=Ptile50;
            PTiles[5,1]=Ptile51;
            PTiles[5,2]=Ptile52;
            PTiles[5,3]=Ptile53;
            PTiles[5,4]=Ptile54;
            PTiles[5,5]=Ptile55;
            PTiles[5,6]=Ptile56;
            PTiles[5, 7] = Ptile57;
            PTiles[6,0]=Ptile60;
            PTiles[6,1]=Ptile61;
            PTiles[6,2]=Ptile62; 
            PTiles[6,3]=Ptile63;
            PTiles[6,4]=Ptile64;
            PTiles[6,5]=Ptile65;
            PTiles[6, 6] = Ptile66;
            PTiles[6,7]=Ptile67;
            PTiles[7, 0] = Ptile70;
            PTiles[7, 1] = Ptile71;
            PTiles[7, 2] = Ptile72;
            PTiles[7, 3] = Ptile73;
            PTiles[7, 4] = Ptile74;
            PTiles[7, 5] = Ptile75;
            PTiles[7, 6] = Ptile76;
            PTiles[7, 7] = Ptile77;
            #endregion
            #region AllocatingTiles
            
            OTile[0, 0] = Otile00;
            OTile[0, 1] = Otile01;
            OTile[0, 2] = Otile02;
            OTile[0, 3] = Otile03;
            OTile[0, 4] = Otile04;
            OTile[0, 5] = Otile05;
            OTile[0, 6] = Otile06;
            OTile[0, 7] = Otile07;
            OTile[1, 0] = Otile10;
            OTile[1, 1] = Otile11;
            OTile[1, 2] = Otile12;
            OTile[1, 3] = Otile13;
            OTile[1, 4] = Otile14;
            OTile[1, 5] = Otile15;
            OTile[1, 6] = Otile16;
            OTile[1, 7] = Otile17;
            OTile[2, 0] = Otile20;
            OTile[2, 1] = Otile21;
            OTile[2, 2] = Otile22;
            OTile[2, 3] = Otile23;
            OTile[2, 4] = Otile24;
            OTile[2, 5] = Otile25;
            OTile[2, 6] = Otile26;
            OTile[2, 7] = Otile27;
            OTile[3, 0] = Otile30;
            OTile[3, 1] = Otile31;
            OTile[3, 2] = Otile32;
            OTile[3, 3] = Otile33;
            OTile[3, 4] = Otile34;
            OTile[3, 5] = Otile35;
            OTile[3, 6] = Otile36;
            OTile[3, 7] = Otile37;
            OTile[4, 0] = Otile40;
            OTile[4, 1] = Otile41;
            OTile[4, 2] = Otile42;
            OTile[4, 3] = Otile43;
            OTile[4, 4] = Otile44;
            OTile[4, 5] = Otile45;
            OTile[4, 6] = Otile46;
            OTile[4, 7] = Otile47;
            OTile[5, 0] = Otile50;
            OTile[5, 1] = Otile51;
            OTile[5, 2] = Otile52;
            OTile[5, 3] = Otile53;
            OTile[5, 4] = Otile54;
            OTile[5, 5] = Otile55;
            OTile[5, 6] = Otile56;
            OTile[5, 7] = Otile57;
            OTile[6, 0] = Otile60;
            OTile[6, 1] = Otile61;
            OTile[6, 2] = Otile62;
            OTile[6, 3] = Otile63;
            OTile[6, 4] = Otile64;
            OTile[6, 5] = Otile65;
            OTile[6, 6] = Otile66;
            OTile[6, 7] = Otile67;
            OTile[7, 0] = Otile70;
            OTile[7, 1] = Otile71;
            OTile[7, 2] = Otile72;
            OTile[7, 3] = Otile73;
            OTile[7, 4] = Otile74;
            OTile[7, 5] = Otile75;
            OTile[7, 6] = Otile76;
            OTile[7, 7] = Otile77;
            #endregion
        }

        private void cbDirecetion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbShip.Enabled = true;
          
        }

        private void cbShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbX.Enabled = true;
            cbY.Enabled = true;
           
            btPlaceShip.Enabled = true;

        }

        private void btPlaceShip_Click(object sender, EventArgs e)
        {
            if (cbX.Text == "" || cbY.Text == "")
            {
                MessageBox.Show("Kindly Show select Axes and then Click on place Ship");
            }
            else
            {
             
                int X = Convert.ToInt32(cbX.Text);
                int Y = Convert.ToInt32(cbY.Text);
                string Direction = cbDirecetion.Text;
                string Ship = cbShip.Text;
                bool Checking = BattleShipClass.CheckPosition(X, Y, Direction, Ship);
                if (Checking == false)
                {
                    MessageBox.Show("Ship is out of Board Please Try Again");
                }
               
                else if (Checking == true)
                {
                    try
                    {
                        if (Direction == "Horizontal")
                        {
                            #region Ship
                            if (Ship == "2-Tile Ship")
                            {
                                cbShip.Items.Remove("2-Tile Ship");
if (PTiles[X, Y].BackColor != Color.Brown) PTiles[X, Y].BackColor = Color.Brown;


 if (PTiles[X + 1, Y].BackColor != Color.Brown) PTiles[X + 1, Y].BackColor = Color.Brown;

                            }
                            else if (Ship == "3-Tile Ship")
                            {
                                cbShip.Items.Remove("3-Tile Ship");
 if(PTiles[X, Y].BackColor != Color.Brown) PTiles[X, Y].BackColor = Color.Brown;


if (PTiles[X + 1, Y].BackColor != Color.Brown) PTiles[X + 1, Y].BackColor = Color.Brown;

if (PTiles[X + 2, Y].BackColor != Color.Brown) PTiles[X + 2, Y].BackColor = Color.Brown;

                            }
                            else if (Ship == "4-Tile Ship")
                            {
                                cbShip.Items.Remove("4-Tile Ship");
if (PTiles[X, Y].BackColor != Color.Brown) PTiles[X, Y].BackColor = Color.Brown;


if (PTiles[X + 1, Y].BackColor != Color.Brown) PTiles[X + 1, Y].BackColor = Color.Brown;

if (PTiles[X + 2, Y].BackColor != Color.Brown) PTiles[X + 2, Y].BackColor = Color.Brown;

 if (PTiles[X + 3, Y].BackColor != Color.Brown) PTiles[X + 3, Y].BackColor = Color.Brown;

                            }
                            #endregion
                        }
                        else if (Direction == "Vertical")
                        {
                            #region Ship
                            if (Ship == "2-Tile Ship")
                            {
                                cbShip.Items.Remove("2-Tile Ship");
                                PTiles[X, Y].BackColor = Color.Brown;


                                PTiles[X, Y + 1].BackColor = Color.Brown;

                            }
                            else if (Ship == "3-Tile Ship")
                            {
                                cbShip.Items.Remove("3-Tile Ship");
                                PTiles[X, Y].BackColor = Color.Brown;


                                PTiles[X, Y + 1].BackColor = Color.Brown;

                                PTiles[X, Y + 2].BackColor = Color.Brown;

                            }
                            else if (Ship == "4-Tile Ship")
                            {
                                cbShip.Items.Remove("4-Tile Ship");
                                PTiles[X, Y].BackColor = Color.Brown;


                                PTiles[X, Y + 1].BackColor = Color.Brown;

                                PTiles[X, Y + 2].BackColor = Color.Brown;

                                PTiles[X, Y + 3].BackColor = Color.Brown;

                            }
                            #endregion
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ship is out of Board Please Try Again");
                    }
                }
                    
                if (cbShip.Items.Count == 0)
                {
                    btPlaceShip.Enabled = false;
                    panel1.Visible = false;
                    label1.Visible = false;
                    btStart.Enabled = true;
                }
               
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Otiles[4, 5] = true;
            Otiles[3, 5] = true;
            Otiles[2, 5] = true;
            Otiles[4, 7] = true;
            Otiles[4, 7] = true;
            Otiles[7, 1] = true;
            Otiles[7, 2] = true;
            Otiles[7, 3] = true;
            Otiles[7, 4] = true;
            cbHitX.Enabled = true;
            cbHitY.Enabled = true;
            btHit.Enabled = true;


        }

        private void btHit_Click(object sender, EventArgs e)
        {
            Random RndX = new Random();
            Random RndY = new Random();
            int X=Convert.ToInt32(cbHitX.Text);
            int Y=Convert.ToInt32(cbHitY.Text);
            if (cbHitX.Text != "" && cbHitY.Text != "")
            {
                if (Otiles[X , Y ] == true)
                {
                    Otiles[X , Y ] = false;
                    OTile[X, Y].BackColor = Color.Green;
                   // MessageBox.Show("You Hit the Ship");
                    
                }
                else if (Otiles[X , Y ] != true)
                {
                    if (OTile[X, Y].BackColor != Color.Green && OTile[X, Y].BackColor != Color.Red)
                    {
                       // MessageBox.Show("You Missed");
                        OTile[X, Y].BackColor = Color.Red;
                    }
                    else if (OTile[X, Y].BackColor == Color.Green || OTile[X, Y].BackColor == Color.Red)
                    {
                        MessageBox.Show("Already Hit Please Try Choosing Other Position");
                        return;
                    }
                }
                int OHitX = RndX.Next(0, 7);
                int OHitY = RndY.Next(0, 7);

                if (XAlgoQueue.Count==0 && YAlgoQueue.Count==0)
                {
                    #region IF
                    if (PTiles[OHitX, OHitY].BackColor == Color.Brown)
                    {
                        PTiles[OHitX, OHitY].BackColor = Color.Green;
                       // MessageBox.Show("PC Hit");
                        #region IFElseIF
                        if (OHitX == 0 && OHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(1);
                            #endregion
                        }
                        else if (OHitX == 1 && OHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (OHitX == 2 && OHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (OHitX == 3 && OHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (OHitX == 4 && OHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (OHitX == 5 && OHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (OHitX == 6 && OHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (OHitX == 7 && OHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(1);
                            #endregion
                        }
                        else if (OHitX == 7 && OHitY == 1)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(2);
                            #endregion

                        }
                        else if (OHitX == 7 && OHitY == 2)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(3);
                            #endregion
                        }
                        else if (OHitX == 7 && OHitY == 3)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(4);
                            #endregion
                        }
                        else if (OHitX == 7 && OHitY == 4)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(5);
                            #endregion
                        }
                        else if (OHitX == 7 && OHitY == 5)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(6);
                            #endregion
                        }
                        else if (OHitX == 7 && OHitY == 6)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (OHitX == 7 && OHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(7);

                            #endregion
                        }
                        else if (OHitX == 6 && OHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(7);

                            #endregion

                        }
                        else if (OHitX == 5 && OHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (OHitX == 4 && OHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (OHitX == 3 && OHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (OHitX == 2 && OHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (OHitX == 1 && OHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (OHitX == 0 && OHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(6);


                            #endregion
                        }
                        else if (OHitX == 0 && OHitY == 6)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (OHitX == 0 && OHitY == 5)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(6);
                            #endregion
                        }
                        else if (OHitX == 0 && OHitY == 4)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(5);
                            #endregion
                        }
                        else if (OHitX == 0 && OHitY == 3)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(4);
                            #endregion
                        }
                        else if (OHitX == 0 && OHitY == 2)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(3);
                            #endregion
                        }
                        else if (OHitX == 0 && OHitY == 1)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(2);
                            #endregion
                        }
                        else if (OHitX == 0 && OHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(1);
                            #endregion
                        }
                        #endregion
                        #region Else
                        else
                        {
                            XAlgoQueue.Enqueue(OHitX - 1); YAlgoQueue.Enqueue(OHitY - 1);
                            XAlgoQueue.Enqueue(OHitX ); YAlgoQueue.Enqueue(OHitY - 1);
                            XAlgoQueue.Enqueue(OHitX + 1); YAlgoQueue.Enqueue(OHitY - 1);
                            XAlgoQueue.Enqueue(OHitX + 1); YAlgoQueue.Enqueue(OHitY );
                            XAlgoQueue.Enqueue(OHitX + 1); YAlgoQueue.Enqueue(OHitY + 1);
                            XAlgoQueue.Enqueue(OHitX); YAlgoQueue.Enqueue(OHitY + 1);
                            XAlgoQueue.Enqueue(OHitX - 1); YAlgoQueue.Enqueue(OHitY + 1);
                            XAlgoQueue.Enqueue(OHitX - 1); YAlgoQueue.Enqueue(OHitY);

                         

                        }
                        #endregion
                    }
                    else
                    {
                        if (PTiles[OHitX, OHitY].BackColor != Color.Brown && PTiles[OHitX, OHitY].BackColor != Color.Green)
                        {
                            PTiles[OHitX, OHitY].BackColor = Color.Red;
                            //MessageBox.Show("PC Missed Ohit " + OHitX + "" + OHitY);
                        }
                    }
                    #endregion
                }
                else if (XAlgoQueue.Count !=0 && YAlgoQueue.Count!=0)
                {
                    goto IFGreen;
                IFGreen:

                    int ForHitX = XAlgoQueue.Dequeue();
                    int ForHitY = YAlgoQueue.Dequeue();
                    #region IF
                    if (PTiles[ForHitX, ForHitY].BackColor == Color.Brown)
                    {
                        PTiles[ForHitX, ForHitY].BackColor = Color.Green;
                       // MessageBox.Show("PC Hit");
                      
                        #region IFElseIF
                        if (ForHitX == 0 && ForHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(1);
                            #endregion
                        }
                        else if (ForHitX == 1 && ForHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (ForHitX == 2 && ForHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (ForHitX == 3 && ForHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (ForHitX == 4 && ForHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (ForHitX == 5 && ForHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (ForHitX == 6 && ForHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(0);
                            #endregion
                        }
                        else if (ForHitX == 7 && ForHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(1);
                            #endregion
                        }
                        else if (ForHitX == 7 && ForHitY == 1)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(2);
                            #endregion

                        }
                        else if (ForHitX == 7 && ForHitY == 2)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(3);
                            #endregion
                        }
                        else if (ForHitX == 7 && ForHitY == 3)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(4);
                            #endregion
                        }
                        else if (ForHitX == 7 && ForHitY == 4)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(5);
                            #endregion
                        }
                        else if (ForHitX == 7 && ForHitY == 5)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(6);
                            #endregion
                        }
                        else if (ForHitX == 7 && ForHitY == 6)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (ForHitX == 7 && ForHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(7);

                            #endregion
                        }
                        else if (ForHitX == 6 && ForHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(7); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(7);

                            #endregion

                        }
                        else if (ForHitX == 5 && ForHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(6); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (ForHitX == 4 && ForHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(5); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (ForHitX == 3 && ForHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(4); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (ForHitX == 2 && ForHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(3); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (ForHitX == 1 && ForHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(2); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (ForHitX == 0 && ForHitY == 7)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(6);


                            #endregion
                        }
                        else if (ForHitX == 0 && ForHitY == 6)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(7);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(7);
                            #endregion
                        }
                        else if (ForHitX == 0 && ForHitY == 5)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(6);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(6);
                            #endregion
                        }
                        else if (ForHitX == 0 && ForHitY == 4)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(5);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(5);
                            #endregion
                        }
                        else if (ForHitX == 0 && ForHitY == 3)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(4);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(4);
                            #endregion
                        }
                        else if (ForHitX == 0 && ForHitY == 2)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(3);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(3);
                            #endregion
                        }
                        else if (ForHitX == 0 && ForHitY == 1)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(2);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(2);
                            #endregion
                        }
                        else if (ForHitX == 0 && ForHitY == 0)
                        {
                            #region Queue
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(0);
                            XAlgoQueue.Enqueue(1); YAlgoQueue.Enqueue(1);
                            XAlgoQueue.Enqueue(0); YAlgoQueue.Enqueue(1);
                            #endregion
                        }
                        #endregion
                        #region Else
                        else
                        {
                            XAlgoQueue.Enqueue(ForHitX); YAlgoQueue.Enqueue(ForHitY - 1);
                            XAlgoQueue.Enqueue(ForHitX + 1); YAlgoQueue.Enqueue(ForHitY - 1);
                            XAlgoQueue.Enqueue(ForHitX); YAlgoQueue.Enqueue(ForHitY);
                            XAlgoQueue.Enqueue(ForHitX + 1); YAlgoQueue.Enqueue(ForHitY + 1);
                            XAlgoQueue.Enqueue(ForHitX); YAlgoQueue.Enqueue(ForHitY + 1);
                            XAlgoQueue.Enqueue(ForHitX - 1); YAlgoQueue.Enqueue(ForHitY + 1);
                            XAlgoQueue.Enqueue(ForHitX - 1); YAlgoQueue.Enqueue(ForHitY);
                            XAlgoQueue.Enqueue(ForHitX - 1); YAlgoQueue.Enqueue(ForHitY - 1);

                        }
                        #endregion
                    }
                    else
                    {
                        if (PTiles[ForHitX, ForHitY].BackColor != Color.Green && PTiles[ForHitX, ForHitY].BackColor != Color.Brown)
                        {
                            PTiles[ForHitX, ForHitY].BackColor = Color.Red;
                          //  MessageBox.Show("PC Missed forhit" + ForHitX + " " + ForHitY);
                        }
                        else if (PTiles[ForHitX, ForHitY].BackColor == Color.Green)
                        {
                            goto IFGreen;
                        }
                    }
                    #endregion
                }

            }
            else 
            {
                MessageBox.Show("Kindly Select Hitting Position");
            }

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
