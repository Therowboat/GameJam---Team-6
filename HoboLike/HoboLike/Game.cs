using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Game
    {
        public Player Player { get; private set; }
        public int Day { get; private set; } = 0;
        private const int MaxDays = 3;

        public void Start () 
        {
            Console.WriteLine(Descriptions.GetIntroText());
            Console.ReadKey();
            Console.WriteLine("You enter the Alley");
            Player = new Player( new Alley() ); // player starts in alley
            bool isrunning = true;
            while (isrunning && Player.Energy > 0)
            {
                Player.CurrentRoom.Describe();
                Console.WriteLine("Actions: [E] Explore, [Q] Go Back, [R] Rest, [Esc] Quit");
                Console.Write("Choice: ");
               
                var key = Console.ReadKey(true).Key;
                Console.Clear();

                switch (key) 
                {
                    case ConsoleKey.E: // explore
                        Player.Explore();
                        break;
                    case ConsoleKey.Q: // go back
                        Player.GoBack();
                        break;
                    case ConsoleKey.R: // rest
                        Rest();
                        break;
                    case ConsoleKey.Escape: // close game
                        isrunning = false;
                        Console.WriteLine("You quit. Game over.");
                        break;
                    default:
                        Console.WriteLine("Invalid key.");
                        break;
                }
            }
            if (Player.Energy <= 0)
            {
                Console.WriteLine("You have no more energy to continue, you perish! Game over.");
            }
        }

        private void Rest()
        {
            if (Player.CurrentRoom.HasSleepingSpace)
            {
                Console.WriteLine("You rest safely and regain some energy.");
                Player.Energy += 4;
            }
            else
            {
                Console.WriteLine("You try to rest, but it's unsafe. You loose some energy.");
                Player.Energy -= 4;
            }

            //day advances
            Day++;
            Player.CurrentRoom.HasSlept();
            Console.WriteLine($"\nNew day begins... Day {Day}!");
            Console.WriteLine($"Energy left: {Player.Energy}");

            if (Day > MaxDays && Player.IsAlive)
            {
                Console.Clear();
                Console.WriteLine("You've survived three days!");
                Console.WriteLine("Your friend found you a couch to crash on.");
                Environment.Exit(0);
            }
        }
    }
}
