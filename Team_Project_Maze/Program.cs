using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Team_Project_Maze.Cell;

namespace Team_Project_Maze
{
    public enum Cell { SPACE, HORIZONTAL, TOPLEFT, TOPRIGHT, BOTTOMLEFT, BOTTOMRIGHT, VERTICAL, CHARACTER, CROSS, VERTLEFT, VERTRIGHT, HORDOWN, HORUP }
    class Program
    {
        static void StartMenu()
        //Extremely basic start menu
        {
            WriteLine("Press anything to start the Maze.");
            WriteLine("Press and hold the escape key to quit the game at anytime.");
            ReadKey();
        }
        static void Main(string[] args)
        {
            StartMenu();
            Maze a = new Maze();
            Player test = new Player(2, 1);
            do
            {
                while (!KeyAvailable)
                {
                    a.player = test;
                    a.Practice();
                    a.DrawMaze();
                    a.player.Movement();
                }
            } while (ReadKey(true).Key != ConsoleKey.Escape);
        }
        static void GameOver()
        //Extremely basic gameover screen
        {
            WriteLine("Gameover");
            ReadKey();
        }
    }
}
