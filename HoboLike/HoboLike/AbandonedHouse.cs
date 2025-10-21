using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class AbandonedHouse : Room
    {
        public AbandonedHouse()
        {
            Name = "Abandoned House";
            HasSleepingSpace = true;
        }

        public override void Describe()
        {
            Console.WriteLine(Descriptions.GetAbandonedHouseDescription());
        }
    }
}
