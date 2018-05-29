using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Team_Project_Maze.Cell;

namespace Team_Project_Maze
{
    public enum Direction { TOP, BOTTOM, LEFT, RIGHT };
    class Maze
    {
        public int length;
        public int height;
        public Cell[,] maze = { };
        public Player player = new Player(0, 0);
        public int[,] mazeSetUp = { };

        public Maze()
        {
            mazeSetUp = new int[49, 10];
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
                        case CROSS:
                            Write("┼");
                            break;
                        case VERTRIGHT:
                            Write("├");
                            break;
                        case VERTLEFT:
                            Write("┤");
                            break;
                        case HORDOWN:
                            Write("┬");
                            break;
                        case HORUP:
                            Write("┴");
                            break;
                    }
                WriteLine("");
            }
        }

        public void SetLengthAndHeight()
        //Sets the length and height variables to the dimensions of the maze
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
                        mazeSetUp[j, i] = 1;
                    }
                    else if (j == 0)
                    {
                        mazeSetUp[j, i] = 1;
                    }
                    else if (j == length - 1)
                    {
                        mazeSetUp[j, i] = 1;
                    }else if (i == height - 1)
                    {
                        mazeSetUp[j, i] = 1;
                    }
                    SetWalls();
                }
            }
            TestIfWall();
        }
        public void TestIfWall()
        //Tests if the location the player is trying to move to is a wall and if it is moves them back to the previous location
        {
            Cell[] wall = new Cell[] { HORIZONTAL, TOPLEFT, TOPRIGHT, BOTTOMLEFT, BOTTOMRIGHT, VERTICAL, HORDOWN, HORUP, VERTLEFT, VERTRIGHT };
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
        //Will test what type of wall to place in each location and then place it
        {
            maze = new Cell[49, 10];
            length = 49;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    List<Direction> border = new List<Direction>();
                    if (mazeSetUp[j, i] == 1)
                    {
                        if (j == 0 && i == 0)
                        {
                            maze[j, i] = TOPLEFT;
                        }
                        else if (j == length - 1 && i == 0)
                        {
                            maze[j, i] = TOPRIGHT;
                        }
                        else if (j == 0 && i == height - 1)
                        {
                            maze[j, i] = BOTTOMLEFT;
                        }
                        else if (j == length - 1 && i == height - 1)
                        {
                            maze[j, i] = BOTTOMRIGHT;
                        }
                        else if (j == 0)
                        {
                            if (mazeSetUp[j, i - 1] == 1)
                            {
                                if (mazeSetUp[j, i + 1] == 1)
                                {
                                    if (mazeSetUp[j + 1, i] == 1)
                                    {
                                        maze[j, i] = VERTLEFT;
                                    }
                                    else
                                    {
                                        maze[j, i] = VERTICAL;
                                    }
                                }
                                else if (mazeSetUp[j + 1, i] == 1)
                                {
                                    maze[j, i] = BOTTOMLEFT;
                                }
                            }
                            else if (mazeSetUp[j, i + 1] == 1 && mazeSetUp[j + 1, i] == 1)
                            {
                                maze[j, i] = TOPLEFT;
                            }
                        }
                    }
                    else
                    {
                        maze[j, i] = SPACE;
                    }
                }
            }
        }
    }
}