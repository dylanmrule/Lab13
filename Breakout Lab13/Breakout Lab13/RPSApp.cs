using System;
using System.Collections.Generic;
using System.Text;

namespace Breakout_Lab13
{
    class RPSApp
    {
        Player Player1 { get; set; }
        Player Player2 { get; set; }

        int win = 0, lose = 0, draw = 0;

        public RPSApp()
        {
            Player1 = new Human();
            CvC();
            while (true)
            {

                Console.WriteLine("Please select an opponent: Rocky or Randy");
                string input = Console.ReadLine().ToLower().Trim();
                if (input == "rocky")
                {
                    Player2 = new Rocky();
                    break;
                }
                else if (input == "randy")
                {
                    Player2 = new Randy();
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't undertand that. Let's try again.");
                    continue;
                }
            }

            Play();
        }

        public void Play()
        {
            Console.WriteLine("User's turn");
            RPS p1throw = Player1.GetRPS();
            Console.WriteLine("You have chosen: " + p1throw);

            Console.WriteLine("Opponent's turn");
            RPS p2throw = Player2.GetRPS();
            Console.WriteLine(p2throw);


            if (p1throw == p2throw)
            {
                Console.WriteLine("Draw");
                draw++;
            }
            else if (p1throw == RPS.rock && p2throw == RPS.scissors)
            {
                Console.WriteLine("You win!");
                win++;
            }
            else if (p1throw == RPS.paper && p2throw == RPS.rock)
            {
                Console.WriteLine("You win!");
                win++;
            }
            else if (p1throw == RPS.scissors && p2throw == RPS.paper)
            {
                Console.WriteLine("You win!");
                win++;
            }
            else if (p1throw == RPS.rock && p2throw == RPS.paper)
            {
                Console.WriteLine("You lose.");
                lose++;
            }
            else if (p1throw == RPS.paper && p2throw == RPS.scissors)
            {
                Console.WriteLine("You lose.");
                lose++;
            }
            else if (p1throw == RPS.scissors && p2throw == RPS.rock)
            {
                Console.WriteLine("You lose.");
            }






            while (true)
            {
                Console.WriteLine("Would you like to play again? y/n");
                string input = Console.ReadLine().ToLower().Trim();

                if (input == "y")
                {
                    Play();
                    break;
                }
                else if (input == "n")
                {

                    Console.WriteLine("Wins: " + win);
                    Console.WriteLine("Losses: " + lose);
                    Console.WriteLine("Draws: " + draw);
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
                else
                {
                    Console.WriteLine("I didn't understand that. Let's try again.");
                    continue;
                }
            }

        }

        public void CvC()
        {
            Console.WriteLine("Would you like to play as Randy or Rocky? y/n");
            string response = Console.ReadLine().ToLower().Trim();


            while (response == "y")
            {
                Console.WriteLine("Select a player. Type Randy or Rocky.");
                string playerName = Console.ReadLine();
                if (playerName == "randy")
                {
                    Player1 = new Randy();
                    break;
                }
                else if (playerName == "rocky")
                {
                    Player1 = new Rocky();
                    break;
                }
                else
                {
                    Console.WriteLine("I didn't understand that. Please try again.");
                    continue;
                }
            }
                while (response == "n")
                {
                break;
                }
                   

            

        }

    }
}


