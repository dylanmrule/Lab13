using System;
using System.Collections.Generic;
using System.Text;

namespace Breakout_Lab13
{
    class Randy:Player
    {
        public Random r { get; set; }

        public Randy()
        {
            r = new Random();
        }

        public override RPS GetRPS()
        {
            int pick = r.Next(0, 3);
            RPS output = (RPS)pick;
            return output;
        }
    }
}
