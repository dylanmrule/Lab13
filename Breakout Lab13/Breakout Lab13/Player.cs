using System;
using System.Collections.Generic;
using System.Text;

namespace Breakout_Lab13
{
    abstract class Player
    {
        public string Name { get; set; }
        
        public virtual RPS GetRPS()
        {
            throw new NotImplementedException();
        }
    }

    public enum RPS
    {
        rock,
        paper,
        scissors
    }


}
