using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    public class Underpass : Room
    {
        private static Random rng = new Random();

        public Underpass()
        {
            Name = "Underpass";
            HasSleepingSpace = true;
        }

        public override void Describe()
        {
            string[] DescriptionArray = Descriptions.AlleyDescriptions;
            Console.WriteLine(DescriptionArray[(rng.Next(DescriptionArray.Length))]);
        }
    }
}
