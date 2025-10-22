using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class CombatEvent : IEvent
    {
        public string Name => "Fight a Rat";
        public bool IsCompleted { get; private set; } = false;
        public bool BlockActions => !IsCompleted; //blocks until its finished

        public void Trigger(Player player)
        {
            if (IsCompleted)
            {
                Console.WriteLine("The area is quiet. You've already dealt with the foe.");
                return;
            }

            Console.WriteLine(Descriptions.GetRatAscii());
            Console.WriteLine("Vicious rat attacks you!");

            Random rng = new Random();
            bool win = rng.NextDouble() < 0.6; //60% chance win

            if (win)
            {
                Console.WriteLine("You managed to scare off the rat!");
                player.Energy -= 1;
                Console.WriteLine("You can now rummage safely here.");
            }
            else
            {
                Console.WriteLine("The vile creature got the better of you. You loose energy!");
                player.Energy -= 3;
            }

            IsCompleted = true;
        }
    }
}
