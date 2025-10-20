using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Consumable : Item
    {
        public int Energy { get; }
        public Consumable(string itemName, int energy) : base(itemName)
        {
            Energy = energy;
        }
    }
}
