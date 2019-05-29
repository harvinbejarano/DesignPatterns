using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class CreditCard
    {
        public abstract string CardType { get; set; }
        public abstract decimal CreditLimit { get; set; }
    }
}
