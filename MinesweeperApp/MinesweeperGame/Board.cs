using MinesweeperApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperApp.MinesweeperGame
{
   public  class Board
    {
        //size of the board 
       public int Size { get; set; }

        //the grid 2d array
        public CellModel[,] TheGrid { get; set; }

        // A percentage of cells that will be set to "live" status
        int Difficulty;

        // a constructor for the size of the grid 
        public Board(int size, int diff)
        {
            //size of the 2d array defined by size
            Size = size;
            Difficulty = diff;
            //initialize the new 2d grid
            TheGrid = new CellModel[Size, Size];
            // fill the 2d array
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TheGrid[i, j] = new CellModel(i, j);
                }
            }
        }

      
        public void SetupLiveNeighbors()
        {
            // use the for loop to place bombs. 
            Random r = new Random();
            for (int i = 0; i < this.Difficulty; i++)
            {
               
               int row = r.Next(this.Size);
                int column = r.Next(this.Size);
            if(isThisSquareSafe(row,column))
                TheGrid[row,column].isLive = true;
                
            }
        }
        public void floodFill(int row, int col)
        {


            
            if (isThisSquareSafe(row + 1, col))
                floodFill(row + 1, col);
            if (isThisSquareSafe(row - 1, col))
                floodFill(row - 1, col);
            if (isThisSquareSafe(row, col + 1))
                floodFill(row, col + 1);
            if (isThisSquareSafe(row, col - 1))
                floodFill(row, col - 1);

        }

        // A method to the elements do not go out of bounds/outside the grid
        public bool isThisSquareSafe( int row, int col)
        {
            if (row >=0 && row < Size && col >=0 && col < Size)
            return true;
            else
            {
                return false;
            }
        }
        //  method to calculate the live neighbors for every cell on the grid
        //A  cell should have between 0 and 8 live neighbors.
        //If a cell itself is "live",then you can set the neighbor count to 9.
        public void CalculateLiveNeighbors()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                   
                {
                    if (isThisSquareSafe(i - 1, j - 1))
                    
                        if (TheGrid[i - 1, j - 1].isLive == true)
                             TheGrid[i, j].theNumberOfNeighbors++;
                    if (isThisSquareSafe(i - 1, j))
                        if (TheGrid[i - 1, j].isLive == true)
                             TheGrid[i, j].theNumberOfNeighbors++;
                    if (isThisSquareSafe(i - 1, j+1))
                        if (TheGrid[i-1, j+1].isLive == true)
                             TheGrid[i, j].theNumberOfNeighbors++;
                    if (isThisSquareSafe(i, j+1))
                        if (TheGrid[i, j+1].isLive == true)
                             TheGrid[i, j].theNumberOfNeighbors++;
                    if (isThisSquareSafe(i + 1, j+1))
                        if (TheGrid[i+1,j+1].isLive == true)
                             TheGrid[i, j].theNumberOfNeighbors++;
                    if (isThisSquareSafe(i + 1, j))
                        if (TheGrid[i+1,j].isLive == true)
                             TheGrid[i, j].theNumberOfNeighbors++;
                    if (isThisSquareSafe(i, j-1))
                        if (TheGrid[i, j - 1].isLive == true)
                            TheGrid[i, j].theNumberOfNeighbors++;
                    if (isThisSquareSafe(i + 1, j+1))
                        if (TheGrid[i + 1, j + 1].isLive == true)
                            TheGrid[i, j].theNumberOfNeighbors++;


                    










                }
               
                
            }
            
        }
        
    }
}
