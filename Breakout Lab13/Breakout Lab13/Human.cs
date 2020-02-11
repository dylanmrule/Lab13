using System;
using System.Collections.Generic;
using System.Text;

namespace Breakout_Lab13
{
    class Human:Player
    {
        public Human()
        {
            Console.WriteLine("Please enter your name:");
            Name = Console.ReadLine();
        }
        public override RPS GetRPS()
        {
            Console.WriteLine("Please select Rock, Paper, or Scissors");
            string input = Console.ReadLine().ToLower().Trim();
            if (input == RPS.paper.ToString())
            {
                return RPS.paper;
            }
            else if (input == RPS.rock.ToString())
            {
                return RPS.rock;
            }
            else if (input == RPS.scissors.ToString())
            {
                return RPS.scissors;
            }
            else
            {
                Console.WriteLine("I didn't understand. Let's try again.");
                return GetRPS();
            } 
                
        }
    }
}
