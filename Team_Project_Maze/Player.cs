using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Maze
{
    class Player
    {
        public char character = '웃';
        public char death = '☠';
        public int x;
        public int y;
        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Movement()
        {
            char move = Console.ReadKey().KeyChar;
            switch (move)
            {
                case 'a':
                    x = x - 2;
                    return x;
                case 'd':
                    x = x + 2;
                    return x;
                case 's':
                    return y++;
                case 'w':
                    return y--;
                default:
                    return x;
            }
            //{

            //    if (move == 'a')
            //    {
            //        return x--;
            //    }
            //    else if (move == 's')
            //    {
            //        return y--;
            //    }
            //    else if (move == 'd')
            //    {
            //        return x++;
            //    }
            //    else if (move == 'w')
            //    {
            //        return y++;
            //    }
            //    else
            //    {
            //        return x;
            //    }

            //}
        }
    }
}
