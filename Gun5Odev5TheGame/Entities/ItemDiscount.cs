using System;
using System.Collections.Generic;
using System.Text;


namespace Gun5Odev5TheGame.Entities
{
    public class ItemDiscount
    {
        public string DiscountName { get; set; }
        public double DiscountRate { get; set; }
        public Item item { get; set; }
    }
}
