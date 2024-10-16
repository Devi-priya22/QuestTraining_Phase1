using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class CreditCardManager
    {
        private List<CreditCard> creditCards = new List<CreditCard>
        public void Add(CreditCard card)
        {
        foreach (var item in creditCards)
            {
                if (item.CardNumber == card.CardNumber)
                {
                    Console.WriteLine("Card already exists");
                    return;
                }
            }

            creditCards.Add(card);
            Console.WriteLine("Added successfully");
        }
        public void Search(string cardNumber)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    Console.WriteLine(card);
                }
            }
        }
        public void Update(string cardNumber, string cardHolderName, string expiry, int securityCode)
        {
            var card = GetCardByNumber(cardNumber);
            if (card == null)
            {
                Console.WriteLine("Card not found");
                return;
            }

            card.Expiry = expiry;
            card.CardHolderName = cardHolderName;
            card.SecurityCode = securityCode;
            Console.WriteLine("Updated successfully");
        }
        public void Delete(string cardNumber)
        {
            var card = GetCardByNumber(cardNumber);
            if (card == null)
            {
                Console.WriteLine("Card not found");
                return;
            }

            creditCards.Remove(card);
            Console.WriteLine("Deleted successfully");
        }
        private CreditCard GetCardByNumber(string cardNumber)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    return card;
                }
            }
            return null;
        }
    }
}
