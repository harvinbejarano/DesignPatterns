using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._2
{
    public class Iphone : CellPhone
    {
        public override int Ram { get ; set ; }
        public override int Hdd { get ; set ; }

        public override void DialNumber(string number)
        {
            Console.WriteLine("Iphone Dialing number: " + number);
        }

        public override void PlayVideo(string video)
        {
            Console.WriteLine("Iphone Playing video: " + video);
        }
    }
}
