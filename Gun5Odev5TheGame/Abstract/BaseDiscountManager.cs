using Gun5Odev5TheGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5TheGame.Abstract
{
    public abstract class BaseDiscountManager : IDiscountService
    {
        public virtual void MakeDiscount(double discountRate, Item item)
        {
            if (discountRate == 0 || (discountRate <1 && discountRate > 0))
            {
                item.ItemPrice = item.ItemPrice * discountRate;
                Console.WriteLine("new price of " + item.ItemName +": " + item.ItemPrice);
            }
            else
            {
                Console.WriteLine("discount rate must be between 0 - 1");
            }

        }
    }
}
