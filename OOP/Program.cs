
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please state your name: ");
            string nameEntry = Console.ReadLine()!;
            Console.WriteLine("What card do you want?");
            Console.WriteLine("For Standard press 1");
            Console.WriteLine("For Gold press 2");
            Console.WriteLine("For Platinum press 3");
            string cardEntry = Console.ReadLine()!;
            if(cardEntry == "1") { Card card = new(nameEntry); }
            else if (cardEntry == "1") { GoldCard card = new(nameEntry); }
            else if (cardEntry == "1") { PlatinumCard card = new(nameEntry); }
            else { Console.WriteLine("?????????"); }
            //bogdan ciora
            Console.WriteLine("To insert the card press 1");
            string enter = Console.ReadLine();
            if(enter == "1")
            {
                Console.WriteLine("Enter PIN"); //PIN is 1234
                string pinEntry = Console.ReadLine()!;
                if(pinEntry != "1234")
                {
                    Console.WriteLine("Wrong PIN! The police are on their way");
                    return;
                }

            }
            else
            {
                Console.WriteLine("??????????????????");
            }
        }
    }
}
