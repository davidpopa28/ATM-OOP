using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class ATM
    {
        private Card Card { get; set; }
        private GoldCard GoldCard { get; set; }
        private PlatinumCard PlatinumCard { get; set; }
        public ATM(PlatinumCard platinumCard)
        {
            PlatinumCard = platinumCard;
        }
        public ATM(GoldCard goldCard)
        {
            GoldCard = goldCard;
        }
        public ATM(Card card)
        {
            Card = card;
        }
        public void WithdrawMoney(Card card, double amount) => Card.Withdraw(amount);
        public void WithdrawMoney(GoldCard goldCard, double amount) => GoldCard.Withdraw(amount);
        public void WithdrawMoney(PlatinumCard platinumCard, double amount) => PlatinumCard.Withdraw(amount);
        public static void ShowBalance(Card card) => Console.WriteLine("Your current amount is " + card.Balance);
        public static void DisplayBillsByCard(Card card) => card.DisplayCurrentBills();

    }
}
