using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Player
    {
        private int energy = 10; //start energy
        public int Energy 
        { 
            get => energy;
            set
            {
                energy = Math.Min(value, 20); //energy can't exceed 20
            }
        }
        public Room CurrentRoom { get; private set; }
        private Room? lastRoom; //track last location
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
            Console.WriteLine("Press number of your choice:");
            var key2 = Console.ReadKey(true).Key;
            Console.Clear();
            int choice = -1;

            switch (key2)
            {
                case ConsoleKey.D1:
                    choice = 1;
                    break;
                case ConsoleKey.D2:
                    choice = 2;
                    break;
                case ConsoleKey.D3:
                    choice = 3;
                    break;
                case ConsoleKey.D4:
                    choice = 4;
                    break;
                case ConsoleKey.D5:
                    choice = 5;
                    break;
            }

            if (choice >= 1 && choice <= options.Count)
            {
                lastRoom = CurrentRoom;
                Room newRoom = options[choice - 1]();

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
