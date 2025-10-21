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
        public void Start () 
        {
            Player = new Player( new Alley() ); // player starts in alley


            bool isrunning = true;
            while (isrunning) 
            {
                Console.WriteLine($"room: {Player.CurrentRoom.Name}");
               
                var input = Console.ReadKey();

                switch (input.Key) 
                {
                    case ConsoleKey.E: // explore
                        Console.Clear();
                        Console.WriteLine("Case E");
                        break;
                    case ConsoleKey.Q: // go back
                        Console.Clear();
                        Console.WriteLine("Case Q");
                        break;
                    case ConsoleKey.R: // rest
                        Console.Clear();
                        break;
                    case ConsoleKey.Escape: // close game
                        Console.Clear();
                        break;

                }
            }
        }
    }
}
