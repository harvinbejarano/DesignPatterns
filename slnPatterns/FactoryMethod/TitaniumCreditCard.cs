using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TitaniumCreditCard : CreditCard
    {
        public override string CardType { get;set ; }

        public override decimal CreditLimit { get ; set ; }

        public TitaniumCreditCard()
        {
            CardType = "titanium";  
        }
    }
}
