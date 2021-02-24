using System;

namespace Gun4Odev2Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FristName = "ali", LastName = "veli", City = "Ankara" };//defult constructor çalışır.
            Customer customer2 = new Customer(2, "ahmet", "mehmet", "İstanbul");//parametre bekleyen constructor çalışır. ancak bu constructora gelen parametreler için constructor içinde
            //ilgili veriye atama yapılması gereklidir. ancak bu şekilde customer'nin özelliklerine ulaşılabilir. 
        }

        
    }

    class Customer
    {

        //defult constructor
        public Customer()
        {

        }
        
        public Customer(int id, string firstName, string lastName, string city)
        {
            FristName = firstName;
            Id = id;
            LastName = lastName;
            City = city;
            
            Console.WriteLine("yapıcı blok çalıştırıldı.");
        }

        public int Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
