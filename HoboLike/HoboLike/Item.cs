using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public abstract class Item
    {
        public string ItemName { get; private set; }
        protected Item(string itemName)
        {
            ItemName = itemName;
        }

    }
}
