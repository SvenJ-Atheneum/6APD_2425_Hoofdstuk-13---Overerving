using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Ballspel
{
    class PlayerBall : Ball
    {
        public PlayerBall(int xin, int yin, int vxin, int vyin) : base(xin, yin, vxin, vyin)
        {
            drawChar = 'X';
            drawColor = ConsoleColor.Green;
        }

        public void ChangeVelocity(ConsoleKeyInfo richting)
        {
            switch (richting.Key)
            {
                case ConsoleKey.UpArrow:
                    vy--;
                    break;
                case ConsoleKey.DownArrow:
                    vy++;
                    break;
                case ConsoleKey.LeftArrow:
                    vx--;
                    break;
                case ConsoleKey.RightArrow:
                    vx++;
                    break;
                default:
                    break;
            }
        }
    }
}
