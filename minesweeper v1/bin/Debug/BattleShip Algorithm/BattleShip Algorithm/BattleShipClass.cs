using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipAlgorithm
{
    class BattleShipClass
    {
        public static bool CheckPosition(int X, int Y,string Direction,string Ship)
        {
            bool Both=true;
            if (Direction == "Horizontal")
            {
                #region Ship
                if (Ship == "2-Tile Ship")
                {
                    #region IF
                    if (X == 0 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 1 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 2 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 3 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 4 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 7)
                    {
                        Both = false;
                    }
                    #endregion
                }
                else if (Ship == "3-Tile Ship")
                {
                    #region IF1
                    if (X == 0 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 1 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 2 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 3 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 4 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 6)
                    {
                        Both = false;
                    }
                    #endregion
                    #region IF2
                    if (X == 0 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 1 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 2 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 3 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 4 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 7)
                    {
                        Both = false;
                    }
                    #endregion
                    
                }
                else if (Ship == "4-Tile Ship")
                {
                    #region IF1
                    if (X == 0 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 1 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 2 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 3 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 4 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 5)
                    {
                        Both = false;
                    }
                    #endregion
                    #region IF2
                    if (X == 0 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 1 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 2 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 3 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 4 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 6)
                    {
                        Both = false;
                    }
                    #endregion
                    #region IF3
                    if (X == 0 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 1 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 2 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 3 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 4 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 7)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 7)
                    {
                        Both = false;
                    }
                    #endregion
                }
                #endregion
            }
            else if (Direction == "Vertical")
            {
                #region Ship
                if (Ship == "2-Tile Ship")
                {
                    #region IF
                    if (X == 7 && Y == 0)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 1)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 2)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 3)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 4)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 7)
                    {
                        Both = false;
                    }
                    #endregion
                }
                else if (Ship == "3-Tile Ship")
                {
                    #region IF1
                    if (X == 7 && Y == 0)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 1)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 2)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 3)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 4)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 7)
                    {
                        Both = false;
                    }
                    #endregion
                    #region IF2
                    if (X == 7 && Y == 0)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 1)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 2)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 3)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 4)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 7)
                    {
                        Both = false;
                    }
                    #endregion

                }
                else if (Ship == "4-Tile Ship")
                {
                    #region IF1
                    if (X == 5 && Y == 0)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 1)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 2)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 3)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 4)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 5 && Y == 7)
                    {
                        Both = false;
                    }
                    #endregion
                    #region IF2
                    if (X == 6 && Y == 0)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 1)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 2)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 3)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 4)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 6 && Y == 7)
                    {
                        Both = false;
                    }
                    #endregion
                    #region IF3
                    if (X == 7 && Y == 0)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 1)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 2)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 3)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 4)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 5)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 6)
                    {
                        Both = false;
                    }
                    if (X == 7 && Y == 7)
                    {
                        Both = false;
                    }
                    #endregion
                }
                #endregion
            }
            return Both;
        }
    }
}
