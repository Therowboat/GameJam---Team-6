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
        public int Day { get; private set; } = 1;
        private const int MaxDays = 3;

        public void StartMenu()
        {
            bool mainRunning = true;
            while (mainRunning)
            {
                Console.Clear();
                Console.WriteLine("--Welcome to HoboLike--\n\n[Enter] Start\n[Esc] Escape");
                var key = Console.ReadKey(true).Key;
                Console.Clear();

                switch (key)
                {
                    case ConsoleKey.Enter:
                        Start();
                        break;
                    case ConsoleKey.Escape:
                        mainRunning = false;
                        break;
                }
            }
        }

        public void Start () 
        {
            Console.Clear();
            Console.WriteLine(Descriptions.GetIntroText());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You enter the Alley");
            Player = new Player( new Alley() ); // player starts in alley
            bool isrunning = true;
            while (isrunning && Player.Energy > 0)
            {
                Player.CurrentRoom.Describe();
                Player.CurrentRoom.SetExplored();
                Console.WriteLine("Actions: [E] Explore, [Q] Go Back, [R] Rest, [I] Interact, [Esc] Quit");
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
                        Console.Clear();
                        if (Player.CurrentRoom.HasSleepingSpace)
                        {
                            Console.WriteLine("This seems like a safe place to sleep.");
                        }
                        else
                        {
                            Console.WriteLine("This place feels unsafe to sleep. You might lose energy if you rest here");
                        }

                        Console.Write("Do you wish to rest anyway? (Y/N): ");
                        var restChoice = Console.ReadKey(true).Key;
                        if (restChoice == ConsoleKey.Y)
                        {
                            Rest();
                        }
                        else if (restChoice == ConsoleKey.N)
                        {
                            Console.WriteLine("You decide not to rest for now.");
                        }
                        break;

                    case ConsoleKey.I: // interact
                        if (Player.CurrentRoom.Events.Count == 0)
                        {
                            Console.WriteLine("There's nothing interesting to do here.");
                        }
                        else
                        {
                            Console.WriteLine("Available interactions:");
                            for (int i = 0; i < Player.CurrentRoom.Events.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {Player.CurrentRoom.Events[i].Name}");
                            }

                            Console.WriteLine("Press the number of your choice:");
                            var key2 = Console.ReadKey(true).Key;
                            Console.Clear();

                            int choice = -1;

                            switch (key2)
                            {
                                case ConsoleKey.D1:
                                    choice = 1;
                                    break;
                                case ConsoleKey.D2:
                                    choice = 2;
                                    break;
                                case ConsoleKey.D3:
                                    choice = 3;
                                    break;
                                case ConsoleKey.D4:
                                    choice = 4;
                                    break;
                                case ConsoleKey.D5:
                                    choice = 5;
                                    break;
                            }

                            if (choice >= 1 && choice <= Player.CurrentRoom.Events.Count)
                            {
                                var selected = Player.CurrentRoom.Events[choice - 1];
                                selected.Trigger(Player);
                                Console.WriteLine($"\nEnergy: {Player.Energy}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice.");
                            }
                        }
                        break;

                    case ConsoleKey.Escape: // close game
                        isrunning = false;
                        Console.WriteLine("You quit. Game over.");
                        Day = 1;
                        return;

                    default:
                        Console.WriteLine("Invalid key.");
                        break;
                }
            }
            if (Player.Energy <= 0)
            {
                Console.WriteLine("You have no more energy to continue, you perish! Game over.");
                Day = 1;
            }
        }

        private void Rest()
        {
            bool hasBlockingEvent = Player.CurrentRoom.Events.Any(e => e.BlockActions);
            if (hasBlockingEvent)
            {
                Console.WriteLine("You cannot do that while danger is nearby!");
                return;
            }

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
                Day = 1;
                Console.ReadKey();
                return;
            }
        }
    }
}
