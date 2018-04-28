using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Team_Project_Maze
{
    class Maze
    {
        public int width;
        public int height;
        public int[,] mazeArea = { };

        public Maze(int width, int height)
        {
            this.width = width;
            this.height = height;
            mazeArea = new int[5 * this.width, this.height];
        }

        public void drawMaze()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    switch (mazeArea[i, j])
                    {
                        case 0:
                            Write(" ");
                            break;
                        case 1:
                            Write("─");
                            break;
                        case 2:
                            Write("┌");
                            break;
                        case 3:
                            Write("┐");
                            break;
                        case 4:
                            Write("└");
                            break;
                        case 5:
                            Write("┘");
                            break;
                        case 6:
                            Write("│");
                            break;

                    }
            }
        }
    }
}
