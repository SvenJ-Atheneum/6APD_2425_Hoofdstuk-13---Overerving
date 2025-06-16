using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Ballspel
{
    class EasyPlayerBall:PlayerBall
    {
        public EasyPlayerBall(int xin, int yin, int vxin, int vyin) : base(xin, yin, 0, 0) { }
        public override void ChangeVelocity(ConsoleKeyInfo richting)
        {
            switch (richting.Key)
            {
                case ConsoleKey.UpArrow:
                    this.Y--;
                    break;
                case ConsoleKey.DownArrow:
                    this.Y++;
                    break;
                case ConsoleKey.LeftArrow:
                    this.X--;
                    break;
                case ConsoleKey.RightArrow:
                    this.X++;
                    break;
                default:
                    break;
            }
        }
    }
}
