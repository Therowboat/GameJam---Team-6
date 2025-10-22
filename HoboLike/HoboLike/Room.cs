using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public abstract class Room
    {
        public string Description { get; protected set; }
        public string Name { get; protected set; }
        public bool HasSleepingSpace { get; protected set; }
        public bool Explored { get; private set; }

        //list of functions that create accessible rooms
        //public List<Func<Room>> AccessibleRooms { get; protected set; } = new List<Func<Room>>();

        //List of rooms ready to explore
        public List<Room> AccessibleRooms { get; protected set; } = new List<Room>();

        public List<IEvent> Events { get; protected set; } = new List<IEvent>();

        public void Describe()
        {
            Console.WriteLine(Description);
        }

        public void HasSlept()
        {
            HasSleepingSpace = false;
        }

        public virtual void AddAccessibleRooms() { }

        public void SetExplored()
        {
            Explored = true;
        }
    }
}
