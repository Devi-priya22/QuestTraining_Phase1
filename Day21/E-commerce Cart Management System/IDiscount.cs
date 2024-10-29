using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagemntSystem
{
        internal interface IDiscount
        {
           decimal ApplyDiscount(decimal total);
        }

        public class PercentageDiscount : IDiscount
        {
            private decimal _percentage;

            public PercentageDiscount(decimal discountPercentage)
            {
                _percentage = discountPercentage;
            }

            public decimal ApplyDiscount(decimal total)
            {
                return total - (total * _percentage / 100);
            }
        }

        public class FlatDiscount : IDiscount
        {
            private decimal _flatAmount;

            public FlatDiscount(decimal discountAmount)
            {
                _flatAmount = discountAmount;
            }

            public decimal ApplyDiscount(decimal total)
            {
                return total - _flatAmount;
            }
        }

    

}

