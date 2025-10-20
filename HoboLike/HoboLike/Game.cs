using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Game
    {
        public Player player;

        public void Start () 
        {
            player = new Player ();
            //RoomController = new RoomController();

            bool isrunning = true;
            while (isrunning) 
            {
               
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
