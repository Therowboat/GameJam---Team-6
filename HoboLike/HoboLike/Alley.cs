using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Alley : Room
    {
        private static Random rng = new Random();

        public Alley()
        {
            Name = "Alley";
            HasSleepingSpace = false;

            //always explore new alley from alley
            AccessibleRooms.Add(() => new Alley());

            //rng if we get Underpass or AbandonedHouse
            if (rng.NextDouble() < 0.5) // 50% chance
                AccessibleRooms.Add(() => new Underpass());
            if (rng.NextDouble() < 0.2) // 20% chance
                AccessibleRooms.Add(() => new AbandonedHouse());
        }
    }
}
