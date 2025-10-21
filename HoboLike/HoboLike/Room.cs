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

        //list of functions that create accessible rooms
        public List<Func<Room>> AccessibleRooms { get; protected set; } = new List<Func<Room>>();

        public virtual void Describe()
        {
            Console.WriteLine($"This is a {Name}."); //virtual if we wanna override in subclass
        }
    }
}
