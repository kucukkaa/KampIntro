using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev5TheGame.Entities;

namespace Gun5Odev5TheGame.Abstract
{
    interface ISellingService
    {
        void Buy(Item item, Player player);
        void Sell(Item item, Player player);
    }
}
