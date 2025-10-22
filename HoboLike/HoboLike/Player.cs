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
        private Room? lastRoom; //track last location
        public bool IsAlive => Energy > 0;

        public Player(Room startRoom)
        {
            CurrentRoom = startRoom;
        }

        public void Explore()
        {
            if (CurrentRoom.Name == "Alley")
            {
                var options = CurrentRoom.AccessibleRooms;
                if (!CurrentRoom.AccessibleRooms.Contains(lastRoom))
                    {
                        CurrentRoom.AddAccessibleRooms();
                    }
                Console.WriteLine("\nWhere do you want to explore?");

                for (int i = 0; i < options.Count; i++)
                {
                    Room roomOption = options[i];

                    string exploredStatus = "";
                    if (roomOption.Explored == true)
                    { 
                        exploredStatus = "[Already explored]";
                    }

                    Console.WriteLine($"{i + 1}. {roomOption.Name} {exploredStatus}");
                }
                Console.Write("> ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= options.Count)
                {
                    lastRoom = CurrentRoom;
                    Room newRoom = options[choice - 1];

                    CurrentRoom = newRoom;
                    Energy -= 2; //explore energy cost

                    Console.Clear();
                    Console.WriteLine($"You enter the {newRoom.Name}");
                    Console.WriteLine($"Energy left: {Energy}");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        public void GoBack() 
        {
            if (lastRoom == null)
            {
                Console.WriteLine("No previous room to go back to.");
                return;
            }
            Room tempRoom = CurrentRoom;
            CurrentRoom = lastRoom;
            lastRoom = tempRoom;
            Console.Clear();
            Console.WriteLine($"You return to {CurrentRoom.Name} (no energy cost).");
            //CurrentRoom.Describe();
        }
    }
}
