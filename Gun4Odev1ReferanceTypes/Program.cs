using System;

namespace Gun4Odev1ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Ali";

            //person  = base sınıf

            Customer customer1 = new Customer();
            customer1.Name = "Veli";
            customer1.CreditCardNumber = "1234567890";

            // customer1 = person1; olmaz

            //ancak burada Customer sınıfı aynı zamanda Person olduğu için
            // bir bir Person Customer'a eşitlenebilir. 

            person1 = customer1;

            Console.WriteLine(person1.Name); //Person sınıfı içerisindeki bir özelliğe direk ulaşılabilir. buranın çıktısı = Veli 
            Console.WriteLine(((Customer)person1).CreditCardNumber); //ancak Customer sınıfından olan özelliğe boxing yapılmadan ulaşılamaz. 
            //burada parantez içindeki alanda yapılan işleme boxing denir.


        }

        class Person
        {
            public string Name { get; set; }
        }

        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }
    }
}
