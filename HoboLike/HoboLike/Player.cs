using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Player
    {
        public int Energy { get; set; }
        public Room CurrentRoom { get; }
        
        public Player(Room room)
        {
            CurrentRoom = room;
            Energy = 100;
        }

        public void Explore()
        {

        }

        public void GoBack() 
        {

        }
    }
}
