using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev5TheGame.Abstract;
using Gun5Odev5TheGame.Entities;

namespace Gun5Odev5TheGame.Concrete
{
    class BirthDayDiscountManager : BaseDiscountManager
    {
        Player _tempPlayer;
        IDiscountCheckService _discountCheckService;
        public BirthDayDiscountManager(Player player, IDiscountCheckService discountCheckService)
        {
            _discountCheckService = discountCheckService;
            _tempPlayer = player;
        }
        public override void MakeDiscount(double discountRate, Item item)
        {
            if (_discountCheckService.IsBirthDay(_tempPlayer))
            {
                discountRate = discountRate + 0.05;
                item.ItemPrice = item.ItemPrice * discountRate;
                Console.WriteLine("your dicount rate has been increased because its your birthday");
            }
            else
            {
                Console.WriteLine("unluckly its not you birthday today");
            }
        }
    }
}
