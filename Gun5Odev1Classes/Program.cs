namespace Gun5Odev1Classes
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "ali";
            customer1.LastName = "veli";
            customer1.City = "ankara";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "istanbul",
                FirstName = "ahmet",
                LastName = "mehmet"
            };




        }
    }
}
