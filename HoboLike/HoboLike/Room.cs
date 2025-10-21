using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public abstract class Room
    {
        public string Name { get; protected set; }
        public bool HasSleepingSpace { get; protected set; }

        public virtual void Describe()
        {
            Console.WriteLine($"You are in {Name}."); //virtual if we wanna override in subclass
        }
    }
}
