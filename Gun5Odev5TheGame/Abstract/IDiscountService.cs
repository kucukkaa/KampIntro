using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev5TheGame.Entities;

namespace Gun5Odev5TheGame.Abstract
{
    interface IDiscountService
    {
        void MakeDiscount(double discountRate, Item item);
    }
}
