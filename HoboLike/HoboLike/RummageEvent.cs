using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class RummageEvent : IEvent
    {
        public string Name => "Rummage Trashcan";
        public bool IsCompleted { get; private set; } = false;
        public bool BlockActions => false;

        public void Trigger(Player player)
        {
            if (player.CurrentRoom.Events.Any(e => e.BlockActions))
            {
                Console.WriteLine("You cannot do that while danger is nearby!");
                return;
            }

            if (IsCompleted)
            {
                Console.WriteLine("You've already rummaged here. Nothing left to find.");
                return;
            }

            Console.WriteLine("You begin to rummage through the trash...");

            Random rng = new Random();
            double roll = rng.NextDouble();

            if (roll < 0.3) //30% chance
            {
                Console.WriteLine("You found nothing useful...");
                player.Energy -= 1;
            }
            else if (roll < 0.9) //60% chance
            {
                Console.WriteLine("You found some snacks!\nThe taste is questionable.. You regain some energy.");
                player.Energy += 3;
            }
            else //10% chance
            {
                Console.WriteLine("You found something you thought was edible.\nIt was not! You loose some energy.");
                player.Energy -= 2;
            }

            IsCompleted = true;
        }
    }
}
