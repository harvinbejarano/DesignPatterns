using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod._2
{
    public class IphoneFactory : CellPhoneFactory
    {
        public override CellPhone GetCellPhone()
        {
            return new Iphone();
        }
    }
}
