
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new("dude");
            ATM atm = new ATM(card);
            Console.Write("Please state your name: ");
            string nameEntry = Console.ReadLine()!;
            Console.WriteLine("What card do you want?");
            Console.WriteLine("For Standard press 1");
            Console.WriteLine("For Gold press 2");
            Console.WriteLine("For Platinum press 3");
            string cardEntry = Console.ReadLine()!;
            if (cardEntry == "1") { card = new Card(nameEntry); atm = new(card); }
            else if (cardEntry == "2") { card = new GoldCard(nameEntry); atm = new(card); }
            else if (cardEntry == "3") { card = new PlatinumCard(nameEntry); atm = new(card); }
            else { Console.WriteLine("?????????"); }
            Console.WriteLine("To insert the card press 1");
            string enter = Console.ReadLine();
            if (enter == "1")
            {
                Console.WriteLine("Enter PIN"); //PIN is 1234
                string pinEntry = Console.ReadLine()!;
                if (pinEntry != "1234")
                {
                    Console.WriteLine("Wrong PIN! The police are on their way");
                    return;
                }
                while (true)
                {
                    Console.WriteLine("To withdraw money press 1");
                    Console.WriteLine("To deposit money press 2");
                    Console.WriteLine("To pay bills press 3");
                    Console.WriteLine("To show balance press 4");
                    string optionEntry = Console.ReadLine()!;
                    if (optionEntry == "1")
                    {
                        Console.Write("Please specify the amount you want to withdraw: ");
                        string withdrawEntry = Console.ReadLine()!;
                        double amount;
                        if (!double.TryParse(withdrawEntry, out amount))
                        {
                            Console.WriteLine("Please enter only numbers");
                            return;
                        }
                        atm.WithdrawMoney(card, amount);
                    }
                    else if (optionEntry == "2")
                    {
                        Console.WriteLine();
                        Console.Write("Enter the amount you want to deposit: ");
                        string depositEntry = Console.ReadLine()!;
                        double amount;
                        if (!double.TryParse(depositEntry, out amount))
                        {
                            Console.WriteLine("Enter only numbers");
                            return;
                        }
                        card.DepositMoney(amount);
                    }
                    else if (optionEntry == "3") 
                    {
                        ATM.DisplayBillsByCard(card);
                        bool bills = true;
                        while (bills)
                        {
                            card.PayForBills();
                            Console.Write("To exit enter 0: ");
                            if(int.Parse(Console.ReadLine()) == 0)
                            {
                                bills = false;
                            }
                        }
                    }
                    else if (optionEntry == "4") 
                    {
                        ATM.ShowBalance(card);
                    }
                    else { Console.WriteLine("bro??"); return; }
                }
            }
            else
            {
                Console.WriteLine("???????????");
            }
        }
    }
}
