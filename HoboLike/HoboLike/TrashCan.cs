using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Trashcan
    {
        private static readonly Item[] _loot =
        {

            new Consumable("Consumable 01", 5),
            new Consumable("Consumable 02", 10),
            new Consumable("Consumable 03", 15),
            new Consumable("Consumable 04", 20),
            new Consumable("Consumable 05", 25),
            new Consumable("Consumable 06", 30),
            new Consumable("Consumable 07", 35),
            new Consumable("Consumable 08", 40),
            new Consumable("Consumable 09", 45),
            new Consumable("Consumable 10", 50),

            new Equipment("Equipment 11"),
            new Equipment("Equipment 12"),
            new Equipment("Equipment 13"),
            new Equipment("Equipment 14"),
            new Equipment("Equipment 15"),
            new Equipment("Equipment 16"),
            new Equipment("Equipment 17"),
            new Equipment("Equipment 18"),
            new Equipment("Equipment 19"),
            new Equipment("Equipment 20"),
        };


        // Read-only array of all possible items
        public static IReadOnlyList<Item> LootTable => Array.AsReadOnly(_loot);

        // Get 4 random items (duplicates allowed)
        public static IReadOnlyList<Item> GetRandomLoot()
        {
            var rng = new Random();
            var chosen = new Item[4];

            for (int i = 0; i < chosen.Length; i++)
            {
                int index = rng.Next(_loot.Length);
                chosen[i] = _loot[index];
            }

            return Array.AsReadOnly(chosen);
        }

    }
}
