using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Underpass : Room
    {
        public Underpass()
        {
            Name = "Underpass";
            HasSleepingSpace = true;
        }

        public override void Describe()
        {
            Console.WriteLine("Hej");
        }
    }
}
