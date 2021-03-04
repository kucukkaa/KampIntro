using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev5TheGame.Abstract;
using Gun5Odev5TheGame.Entities;

namespace Gun5Odev5TheGame.Adapters
{
    public class DiscountAdapter : IDiscountCheckService
    {
        public bool IsBirthDay(Player player)
        {
            if ((player.BirthDate.Day == DateTime.Now.Day) && (player.BirthDate.Month == DateTime.Now.Month))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
