using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class Program
    {
        var cards = new List<CreditCard>();
        public static void AddCard()
        {
            Console.Write("Enter holder name: ");
            string holderName = Console.ReadLine();
            Console.Write("Enter card number: ");
            int cardNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter expiry month: ");
            byte expiryMonth = byte.Parse(Console.ReadLine());
            Console.Write("Enter expiry year: ");
            byte expiryYear = byte.Parse(Console.ReadLine());
            Console.Write("Enter CVC: ");
            int cvc = int.Parse(Console.ReadLine());

            CreditCard newCard = new CreditCard
            {
                HolderName = holderName,
                CardNumber = cardNumber,
                ExpiryMonth = expiryMonth,
                ExpiryYear = expiryYear,
                Cvc = cvc
            };
            cards.Add(newCard);

            Console.WriteLine("Card added successfully.");
        }
        public static void SearchCard()
        {
            Console.WriteLine("Enter the card number to search");
            int SearchCard = int.Parse(Console.ReadLine());
            foreach (var card in cards)
            {
                if (card.CardNumber == SearchCard)
                {
                    Console.WriteLine(card);

                }
            }
        }

        public static void main DeleteCard()
        {

        }
        public static void main UpdateCard()
        {
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add a new card");
                Console.WriteLine("2. Search a card");
                Console.WriteLine("3. Delete a card");
                Console.WriteLine("4.  Update an existing card");
                Console.WriteLine("5. Exit");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddCard();
                        break;
                    case "2":
                        SearchCard();
                        break;
                    case "3":
                        DeleteCard();
                        break;
                    case "4":
                        UpdateCard();
                        break;
                    case "5":
                        return;
                }
            }
        }
    }
}
