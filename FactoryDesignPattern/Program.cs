using FactoryDesignPattern.Cards;

namespace FactoryDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICreditCard cardDetails = new GoldCard();
            Console.WriteLine(cardDetails.GetCardType());

            cardDetails = new PlatinumCard();
            Console.WriteLine(cardDetails.GetCardType()); 

            cardDetails = new TitaniumCard();
            Console.WriteLine(cardDetails.GetCardType());

            Console.ReadKey();
        }
    }
}