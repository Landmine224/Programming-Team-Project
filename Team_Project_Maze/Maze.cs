using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Team_Project_Maze.Walls;

namespace Team_Project_Maze
{
    class Maze
    {
        public int width;
        public int height;
        public Walls[,] mazeArea = { };

        public Maze(int width, int height)
        {
            this.width = 5 * width;
            this.height = height;
            mazeArea = new Walls[this.width, this.height];
        }

        public void drawMaze()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    switch (mazeArea[j, i])
                    {
                        case space:
                            Write(" ");
                            break;
                        case horizontal:
                            Write("─");
                            break;
                        case leftUp:
                            Write("┌");
                            break;
                        case rightUp:
                            Write("┐");
                            break;
                        case leftDown:
                            Write("└");
                            break;
                        case rightDown:
                            Write("┘");
                            break;
                        case vertical:
                            Write("│");
                            break;

                    }
                WriteLine("");
            }
        }
        public void Tutorial()
        {
            mazeArea = new Walls[50, 10];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 && i == 0)
                    {
                        mazeArea[0, 0] = leftUp;
                    }
                    else if (j == width - 1 && i == 0)
                    {
                        mazeArea[(width - 1), 0] = rightUp;
                    }
                    else if (j == width - 1 && i == height - 1)
                    {
                        mazeArea[width - 1, height - 1] = rightDown;
                    }
                    else if (j == 0 && i == height - 1)
                    {
                        mazeArea[0, height - 1] = leftDown;
                    }
                }
            }
        }

        public void Practice()
        {
            mazeArea = new Walls[50, 10];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 && i == 0)
                    {
                        mazeArea[0, 0] = leftUp;
                    }
                    else if (j == width - 1 && i == 0)
                    {
                        mazeArea[(width - 1), 0] = rightUp;
                    }
                    else if (j == width - 1 && i == height - 1)
                    {
                        mazeArea[width - 1, height - 1] = rightDown;
                    }
                    else if (j == 0 && i == height - 1)
                    {
                        mazeArea[0, height - 1] = leftDown;
                    }
                }
            }
        }
    }
}
