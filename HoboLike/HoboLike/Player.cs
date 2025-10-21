using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Player
    {
        public int Energy { get; set; } = 10; //start energy
        public Room CurrentRoom { get; private set; }
        private Queue<Room> recentRooms = new Queue<Room>();
        public bool IsAlive => Energy > 0;

        public Player(Room startRoom)
        {
            CurrentRoom = startRoom;
        }

        public void Explore()
        {
            var options = CurrentRoom.AccessibleRooms;
            Console.WriteLine("\nWhere do you want to explore?");

            for (int i = 0; i < options.Count; i++)
            {
                Room roomOption = options[i]();
                Console.WriteLine($"{i + 1}. {roomOption.Name}");
            }
            Console.Write("> ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= options.Count)
            {
                Room newRoom = options[choice - 1]();

                CurrentRoom = newRoom;
                Energy -= 2; //explore energy cost

                Console.Clear();
                Console.WriteLine($"You enter the {newRoom.Name}");
                newRoom.Describe();
                Console.WriteLine($"Energy left: {Energy}");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        public void GoBack() 
        {
            // TODO: needs implementation
        }

        // adds rooms to queue so we can use GoBack()
        public void AddToRecentRooms(Room room)
        {
            // TODO: needs implementation
        }
    }
}
