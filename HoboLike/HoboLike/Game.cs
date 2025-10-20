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
        public Player Player { get; }
        public void Start () 
        {
            Alley room = new Alley();
            Player player = new Player(room);


            bool isrunning = true;
            while (isrunning) 
            {
                Console.WriteLine($"room: {room.name}");
               
                var input = Console.ReadKey();

                switch (input.Key) 
                {
                    case ConsoleKey.Q:
                        Console.Clear();
                        Console.WriteLine("Case Q");
                            break;
                    case ConsoleKey.W:
                        Console.Clear();
                        Console.WriteLine("Case W");
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        Console.WriteLine("Case E");
                        break;
                    case ConsoleKey.R:
                        Console.Clear();
                        isrunning = false;
                        break;

                }
            }
        }
    }
}
