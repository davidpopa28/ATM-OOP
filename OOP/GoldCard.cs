using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class GoldCard : Card
    {
        public GoldCard(string cardOwner) : base(cardOwner)
        {
            Pin = "1234";
        }
        public override void Withdraw(double amount)
        {
            Balance -= (amount + 1 / 100 * amount);
            Console.WriteLine("Please pick up the $" + amount + "!");
        }
    }
}
