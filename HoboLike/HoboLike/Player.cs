using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Player
    {
        public int Energy { get; private set; }
        public Room CurrentRoom { get; private set; }
        private Queue<Room> recentRooms = new Queue<Room>();
        public bool IsAlive => Energy > 0;

        public Player(Room startRoom)
        {
            CurrentRoom = startRoom;
            Energy = 10; // start energy
        }

        public void Explore()
        {
            if (Energy > 0)
            {
                Console.WriteLine("Too tired");
            }
        }

        public void GoBack() 
        {

        }
    }
}
