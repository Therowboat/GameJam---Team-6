using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public interface IEvent
    {
        string Name { get; }
        bool IsCompleted { get; } //checks if it has been done
        bool BlockActions { get; } //blocks other interactions if there is combat
        void Trigger(Player player);
    }
}
