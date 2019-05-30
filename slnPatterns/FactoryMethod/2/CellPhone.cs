using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._2
{
    public abstract class CellPhone
    {
        public abstract int Ram { get; set; }
        public abstract int Hdd { get; set; }

        public abstract void PlayVideo(string video);
        public abstract void DialNumber(string number);
    }
}
