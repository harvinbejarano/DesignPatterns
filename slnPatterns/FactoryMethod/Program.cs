using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.Write("Enter the card type you would like to visit: (titanium/platinum)");
            string car = Console.ReadLine();

            switch (car.ToLower())
            {
                case "titanium":
                    factory = new TitaniumFactory();
                    break;
                case "platinum":
                    factory = new PlatinumFactory();
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("Credit Card: " +creditCard.CardType);
            Console.ReadLine();
        }
    }
}
