using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagemntSystem
{
    internal class Cart
    {
        private List<CartItem> items = new List<CartItem>();
        private List<IDiscount> discounts = new List<IDiscount>();

        public void AddItem(CartItem item)
        {
            items.Add(item);
        }

        public void UpdateItemQuantity(string itemName, int quantity)
        {
            foreach (var item in items)
            {
                if (item.Name == itemName)
                {
                    item.Quantity = quantity;
                    return;
                }
            }
        }

        public void RemoveItem(string itemName)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Name == itemName)
                {
                    items.RemoveAt(i);
                    break;
                }
            }
        }

        public void AddDiscount(IDiscount discount)
        {
            discounts.Add(discount);
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.Price * item.Quantity;
            }

            foreach (var discount in discounts)
            {
                total = discount.ApplyDiscount(total);
            }
            return total;
        }
    }

}

