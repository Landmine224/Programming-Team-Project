using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Team_Project_Maze.Cell;

namespace Team_Project_Maze
{
    class Maze
    {
        public int length;
        public int height;
        public Cell[,] maze = { };
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
                        case SPACE:
                            Write(" ");
                            break;
                        case HORIZONTAL:
                            Write("─");
                            break;
                        case TOPLEFT:
                            Write("┌");
                            break;
                        case TOPRIGHT:
                            Write("┐");
                            break;
                        case BOTTOMLEFT:
                            Write("└");
                            break;
                        case BOTTOMRIGHT:
                            Write("┘");
                            break;
                        case VERTICAL:
                            Write("│");
                            break;
                        case CHARACTER:
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
            maze = new Cell[49, 10];
            SetLengthAndHeight();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0)
                    {
                        maze[j, i] = HORIZONTAL;
                    }
                    else if (j == 0)
                    {
                        maze[j, i] = VERTICAL;
                    }
                    else if (j == length - 1)
                    {
                        maze[j, i] = VERTICAL;
                    }
                    else if (i == height - 1)
                    {
                        maze[j, i] = HORIZONTAL;
                    }
                    if (j == 0 && i == 0)
                    {
                        maze[0, 0] = TOPLEFT;
                    }
                    else if (j == length - 1 && i == 0)
                    {
                        maze[(length - 1), 0] = TOPRIGHT;
                    }
                    else if (j == length - 1 && i == height - 1)
                    {
                        maze[length - 1, height - 1] = BOTTOMRIGHT;
                    }
                    else if (j == 0 && i == height - 1)
                    {
                        maze[0, height - 1] = BOTTOMLEFT;
                    }
                    if (i == height - 1 && j == length - 1)
                    {
                        maze[player.x, player.y] = CHARACTER;
                    }
                }
            }
        }

        public void Practice()
        //For testing purposes only
        {
            maze = new Cell[49, 10];
            SetLengthAndHeight();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0)
                    {
                        maze[j, i] = HORIZONTAL;
                    }
                    else if (j == 0)
                    {
                        maze[j, i] = VERTICAL;
                    }
                    else if (j == length - 1)
                    {
                        maze[j, i] = VERTICAL;
                    }
                    else if (i == height - 1)
                    {
                        maze[j, i] = HORIZONTAL;
                    }
                    if (j == 0 && i == 0)
                    {
                        maze[0, 0] = TOPLEFT;
                    }
                    else if (j == length - 1 && i == 0)
                    {
                        maze[(length - 1), 0] = TOPRIGHT;
                    }
                    else if (j == length - 1 && i == height - 1)
                    {
                        maze[length - 1, height - 1] = BOTTOMRIGHT;
                    }
                    else if (j == 0 && i == height - 1)
                    {
                        maze[0, height - 1] = BOTTOMLEFT;
                    }
                   
                }
            }
            TestIfWall();
        }
        public void TestIfWall()
        {
            Cell[] wall = new Cell[] { HORIZONTAL, TOPLEFT, TOPRIGHT, BOTTOMLEFT, BOTTOMRIGHT, VERTICAL };
            if (wall.Contains(maze[player.x, player.y]))
            {
                player.x = player.previous[0];
                player.y = player.previous[1];
                maze[player.x, player.y] = CHARACTER;
            }
            else
            {
                maze[player.x, player.y] = CHARACTER;
            }
        }

        public void SetWalls()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                }
            }
        }
    }
}