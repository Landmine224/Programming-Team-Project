using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Team_Project_Maze.Walls;

namespace Team_Project_Maze
{
    public enum Walls { space, horizontal, leftUp, rightUp, leftDown, rightDown, vertical, character }
    class Program
    {
        static void StartMenu()
        {
        }
        static void Main(string[] args)
        {
             Maze a = new Maze(10, 10);
            //for (int i = 0; i < a.height; i++)
            //{
            //    for(int j = 0; j < a.width; j++)
            //    {
            //        int test = rnd.Next(0, 3);
            //        a.mazeArea[j, i] = test;
            //    }
            //}
            Player test = new Player(30, 8);
            a.player = test;
            a.Practice();
            a.drawMaze();
            StartMenu();
            ReadKey();

        }
    }
}
