using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Maze
{
    class Player
    {
        char character = '웃';
        char death = '☠';
        int x;
        int y;
        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Movement(int direction)
        {
           char move = Console.ReadKey().KeyChar;
            if (move == 'a')
            {
                return x--;
            }
            else if (move == 's')
            {
                return y--;
            }
            else if (move == 'd')
            {
                return x++;
            }
            else if (move == 'w')
            {
                return y++;
            }
            else
            {
                return x;
            }

        }
    }
}
