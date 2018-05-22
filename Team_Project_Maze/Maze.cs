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
        public Walls[,] maze = { };
        public Player player = new Player(0, 0);
        public int[,] mazeSetUp = { };

        public Maze()
        {
        }

        public void DrawMaze()
        //Draws the maze on the console
        {
            Clear();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                    switch (maze[j, i])
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
                            Write(player.character);
                            break;
                    }
                WriteLine("");
            }
        }

        public void SetLengthAndHeight()
        //Gets the length and height of the maze
        {
            length = maze.GetLength(0);
            height = maze.GetLength(1);
        }


        public void Tutorial()
        //The tutorial for the player
        {
            maze = new Walls[50, 10];
            SetLengthAndHeight();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0)
                    {
                        maze[j, i] = horizontal;
                    }
                    else if (j == 0)
                    {
                        maze[j, i] = vertical;
                    }
                    else if (j == length - 1)
                    {
                        maze[j, i] = vertical;
                    }
                    else if (i == height - 1)
                    {
                        maze[j, i] = horizontal;
                    }
                    if (j == 0 && i == 0)
                    {
                        maze[0, 0] = leftUp;
                    }
                    else if (j == length - 1 && i == 0)
                    {
                        maze[(length - 1), 0] = rightUp;
                    }
                    else if (j == length - 1 && i == height - 1)
                    {
                        maze[length - 1, height - 1] = rightDown;
                    }
                    else if (j == 0 && i == height - 1)
                    {
                        maze[0, height - 1] = leftDown;
                    }
                    if (i == height - 1 && j == length - 1)
                    {
                        maze[player.x, player.y] = character;
                    }
                }
            }
        }

        public void Practice()
        //For testing purposes only
        {
            maze = new Walls[50, 10];
            SetLengthAndHeight();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0)
                    {
                        maze[j, i] = horizontal;
                    }
                    else if (j == 0)
                    {
                        maze[j, i] = vertical;
                    }
                    else if (j == length - 1)
                    {
                        maze[j, i] = vertical;
                    }
                    else if (i == height - 1)
                    {
                        maze[j, i] = horizontal;
                    }
                    if (j == 0 && i == 0)
                    {
                        maze[0, 0] = leftUp;
                    }
                    else if (j == length - 1 && i == 0)
                    {
                        maze[(length - 1), 0] = rightUp;
                    }
                    else if (j == length - 1 && i == height - 1)
                    {
                        maze[length - 1, height - 1] = rightDown;
                    }
                    else if (j == 0 && i == height - 1)
                    {
                        maze[0, height - 1] = leftDown;
                    }
                    if (i == height - 1 && j == length - 1)
                    {
                        maze[player.x, player.y] = character;
                    }
                }
            }
        }

        //public void SetWalls()
        //{
        //    for(int i = 0; i < height; )
        //}
    }
}