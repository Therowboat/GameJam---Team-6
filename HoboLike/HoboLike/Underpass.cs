using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Underpass : Room
    {
        private static Random rng = new Random();

        public Underpass()
        {
            Name = "Underpass";
            HasSleepingSpace = false;
            Description = Descriptions.GetUnderpassDescription();

            //maybe sleep
            if (rng.NextDouble() < 0.4)
                HasSleepingSpace = true;

            //combat event
            if (rng.NextDouble() < 0.4)
                Events.Add(new CombatEvent()); // rat combat

            //room events
            if (rng.NextDouble() < 0.4)
                Events.Add(new RummageEvent()); // always trashcan event
        }
    }
}
