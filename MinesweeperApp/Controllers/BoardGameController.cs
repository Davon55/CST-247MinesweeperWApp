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
        static Board board = new Board(72, 7);
        public IActionResult Index()
        {
            for(int i = 0; i < board.Size; i++ )
            {

            }
            return View("Index", board);
        }
        //Handle button click
        public IActionResult HandleButtonClick(string mine)
        {
            int buttonNumber = Int32.Parse(mine);

            foreach (CellModel c in board.TheGrid)
            {
                if(mine.Equals(c.isVisited == true))
                {
                    
                }
            }
            return View("Index", board);
        }
    }
}
