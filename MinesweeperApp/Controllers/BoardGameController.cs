using Microsoft.AspNetCore.Mvc;
using MinesweeperApp.MinesweeperGame;
using MinesweeperApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperApp.Controllers
{
    public class BoardGameController : Controller
    {
        CellModel cell = new CellModel();
        static Board board = new ListBoard(72, 7);
        Random random = new Random();
       
        public IActionResult Index()
        {
            //empty the board when it loads 
            board = new Board(72, 7);
            
            for(int i = 0; i < board.Size; i++ )
            {
                board.SetupLiveNeighbors();

                board.floodFill(cell.row, cell.column);
            }
            return View("Index", board);
        }
        //Handle button click
        public IActionResult HandleButtonClick(string mine)
        {
            //convert string to int 
            int buttonNumber = int.Parse(mine);

            
            return View("Index", board);
        }
    }
}
