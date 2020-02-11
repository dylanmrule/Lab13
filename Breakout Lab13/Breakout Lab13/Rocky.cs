using System;
using System.Collections.Generic;
using System.Text;

namespace Breakout_Lab13
{
    class Rocky:Player
    {
        public Rocky()
        {
            Name = "Rocky";
        }
        public override RPS GetRPS()
        {
            return RPS.rock;
        }
    }
}
