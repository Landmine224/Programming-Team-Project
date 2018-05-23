using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Team_Project_Maze.Cell;

namespace Team_Project_Maze
{
    public enum Cell { SPACE, HORIZONTAL, TOPLEFT, TOPRIGHT, BOTTOMLEFT, BOTTOMRIGHT, VERTICAL, CHARACTER }
    class Program
    {
        static void StartMenu()
        {
        }
        static void Main(string[] args)
        {
            StartMenu();
            Maze a = new Maze();
            Player test = new Player(2, 2);
            WriteLine("Press ESC to stop");
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
    }
}
