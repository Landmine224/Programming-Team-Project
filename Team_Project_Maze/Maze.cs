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
        public int length;
        public int height;
        public Walls[,] mazeArea = { };

        public Maze(int width, int height)
        {
            this.length = 5 * width;
            this.height = height;
            mazeArea = new Walls[this.length, this.height];
        }

        public void drawMaze()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
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
                        case character:
                            Write("");
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
                for (int j = 0; j < length; j++)
                {
                    if (j == 0 && i == 0)
                    {
                        mazeArea[0, 0] = leftUp;
                    }
                    else if (j == length - 1 && i == 0)
                    {
                        mazeArea[(length - 1), 0] = rightUp;
                    }
                    else if (j == length - 1 && i == height - 1)
                    {
                        mazeArea[length - 1, height - 1] = rightDown;
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
                for (int j = 0; j < length; j++)
                {
                    if (i == 0)
                    {
                        mazeArea[j, i] = horizontal;
                    }
                    else if (j == 0)
                    {
                        mazeArea[j, i] = vertical;
                    }
                    else if (j == length - 1)
                    {
                        mazeArea[j, i] = vertical;
                    }
                    else if (i == height - 1)
                    {
                        mazeArea[j, i] = horizontal;
                    }
                    if (j == 0 && i == 0)
                    {
                        mazeArea[0, 0] = leftUp;
                    }
                    else if (j == length - 1 && i == 0)
                    {
                        mazeArea[(length - 1), 0] = rightUp;
                    }
                    else if (j == length - 1 && i == height - 1)
                    {
                        mazeArea[length - 1, height - 1] = rightDown;
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
