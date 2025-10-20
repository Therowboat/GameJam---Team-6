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
            bool isrunning = true;
            while (isrunning) 
            {
               
                var input = Console.ReadKey();

                switch (input.Key) 
                {
                    case ConsoleKey.Q:
                        Console.Clear();
                        Console.WriteLine("Case 1");
                            break;
                    case ConsoleKey.W:
                        
                        break;
                    case ConsoleKey.E:
                        
                        break;
                    case ConsoleKey.R:
                        isrunning = false;
                        break;

                }
            }
        }
    }
}
