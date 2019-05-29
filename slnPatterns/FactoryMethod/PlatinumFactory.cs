using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PlatinumFactory : CardFactory
    {
        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard();
        }
    }
}
