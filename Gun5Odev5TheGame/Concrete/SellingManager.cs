using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev5TheGame.Abstract;
using Gun5Odev5TheGame.Entities;
using Gun5Odev5TheGame.Concrete;

namespace Gun5Odev5TheGame.Concrete
{
    public class SellingManager : ISellingService
    {
        public void Buy(Item item, Player player)
        {
            Console.WriteLine(player.PlayerName + " now have one " + item.ItemName);
            player.Money = player.Money - item.ItemPrice;
            Console.WriteLine(player.Money + "$ has left");
        }

        public void Sell(Item item, Player player)
        {
            Console.WriteLine(player.PlayerName + " has sold one " + item.ItemName);
            player.Money = player.Money + item.ItemPrice;
            Console.WriteLine("now your money is " + player.Money + "$" );
        }
    }
}
