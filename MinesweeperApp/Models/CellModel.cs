using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperApp.Models
{
   public class CellModel
    {
       public int row { get; set; }

       public int column { get; set; }
       
       public int theNumberOfNeighbors { get; set; }
       public bool isVisited { get; set; }

       public bool isLive { get; set; }

        public CellModel( int x , int y)
        {
            row = x;
            column = y;
        }

        public CellModel()
        {
            row = -1;
            column = -1;
            isVisited = false;
            isLive = false;
            theNumberOfNeighbors = 0;
        }
    }
}
