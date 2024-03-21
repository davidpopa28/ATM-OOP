namespace OOP
{
    internal class Card
    {
        public string CardOwner { get; private set; }
        protected string Pin { get; set; }
        public double Balance { get; set; }
        public List<Bill> Bills = new()
        {
            new Bill { CompanyName = "Nokia", Cost = 20},
            new Bill { CompanyName = "Vodafone", Cost= 100 },
            new Bill {CompanyName = "Netflix", Cost = 100}
        };
        public Card(string cardOwner)
        {
            Pin = "1234";
            CardOwner = cardOwner;
        }
        public virtual void Withdraw(double amount)
        {
            Balance -= (amount + 5 / 100 * amount);
            Console.WriteLine("Please pick up the $" + amount + "!");
        }
        public void DisplayCurrentBills()
        {
            for (int i = 0; i < Bills.Count; i++)
            {
                Console.WriteLine($"{i}.Bill from {Bills[i].CompanyName} that costs {Bills[i].Cost}");
            }
        }
    }
}
