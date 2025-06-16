using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3_Ballspel
{
    class ChaseBall:Ball
    {
        private int delay = 3;
        private int turn = 0;
        public ChaseBall(int xin, int yin) : base(xin, yin, 0, 0)
        {
            drawChar = '*';
            drawColor = ConsoleColor.Red;
        }
        public void GiveChase(Ball target)
        {
            
            if (target != null && turn%delay==0)
            {
                if (target.X < this.X)
                {
                    this.X--;
                }
                else if (target.X > this.X)
                {
                    this.X++;
                }
                if (target.Y < this.Y)
                {
                    this.Y--;
                }
                else if (target.Y > this.Y)
                {
                    this.Y++;
                }
            }
            turn = turn % delay;
            turn++;
        }

    }
}
