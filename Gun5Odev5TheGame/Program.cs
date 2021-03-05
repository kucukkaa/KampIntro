using System;
using Gun5Odev5TheGame.Abstract;
using Gun5Odev5TheGame.Adapters;
using Gun5Odev5TheGame.Concrete;
using Gun5Odev5TheGame.Entities;

namespace Gun5Odev5TheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.NationalityId = "50155561840";
            player1.FirstName = "Alierk";
            player1.LastName = "Küçük";
            player1.BirthDate = new DateTime(1986, 03, 05);
            player1.PlayerName = "meSSiaS";
            player1.Money = 150;

            Item item1 = new Item();
            item1.ItemName = "Armor";
            item1.ItemPrice = 100;



            SellingManager sellingManager = new SellingManager();
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Save(player1);
            //playerManager.Update("MESSIAS", player1);
            //playerManager.Delete(player1);
            sellingManager.Buy(item1, player1);
            sellingManager.Sell(item1, player1);
            BaseDiscountManager discountManager = new DiscountManager();
            discountManager.MakeDiscount(0.50, item1);
            BaseDiscountManager discountManager1 = new BirthDayDiscountManager(player1, new DiscountAdapter());
            discountManager1.MakeDiscount(0.75, item1);
            sellingManager.Buy(item1, player1);
            ItemDiscount itemDiscount = new ItemDiscount();
            itemDiscount.DiscountName = "Yeni Yıl";
            itemDiscount.DiscountRate = 0.75;
            itemDiscount.item = item1;
            BaseDiscountManager itemDiscountManager = new ItemDiscountManager();
            itemDiscountManager.MakeDiscount(itemDiscount.DiscountRate, itemDiscount.item);
            







        }
    }
}
