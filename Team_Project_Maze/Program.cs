using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Team_Project_Maze
{
    class Program
    {
        static void StartMenu()
        {
            WriteLine("┌─┐");
            WriteLine("│ │");
            WriteLine("│ │");
        }
        static void Main(string[] args)
        {
            Maze a = new Maze(10, 10);
            WriteLine(a.mazeArea[0, 0]);
            StartMenu();
            ReadKey();
        }
    }
}
