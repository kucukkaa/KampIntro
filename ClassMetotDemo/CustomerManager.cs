using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Id: " + customer.Id +
            "\nMüşteri TC Kimlik No: " + customer.TCKN +
            "\nMüşteri Adı: " + customer.CustomerName +
            "\nMüşteri Soyadı: " + customer.CustomerSurname +
            "\nMüşteri Hesap No: " + customer.CAccountNumber +
            "\nMüşteri Hesap Bakiyesi: " + customer.CustomerBalance +
            "\nMüşteri Address: " + customer.CustomerAddress +
            "\nMüşteri Telefon No: " + customer.CustomerTelephone +
            "\nşeklinde kaydı yapılmıştır." +
            "\n -------------------------------------------------------------"
            );
        }

        public void ShowCustomer(int Id, Customer[] customerList)
        {
            Console.WriteLine(Id + " numaraları müşteriye ait bilgiler aşağıdadır: \n" +
            "Müşteri Adı: " + customerList[Id - 1].CustomerName +
            "\nMüşteri Soyadı: " + customerList[Id - 1].CustomerSurname +
            "\nMüşteri TC Kimlik No: " + customerList[Id - 1].TCKN +
            "\nMüşteri Hesap No: " + customerList[Id - 1].CAccountNumber +
            "\nMüşteri Hesap Bakiyesi: " + customerList[Id - 1].CustomerBalance +
            "\nMüşteri Address: " + customerList[Id - 1].CustomerAddress +
            "\nMüşteri Telefon No: " + customerList[Id - 1].CustomerTelephone +
            "\n -------------------------------------------------------------"
                );
        }

        public void ShowAllCustomers(Customer[] customerList)
        {
            foreach (var item in customerList)
            {
                if (item != null)
                {
                    Console.WriteLine("Müşteri Id: " + item.Id +
                    "\nMüşteri TC Kimlik No: " + item.TCKN +
                    "\nMüşteri Adı: " + item.CustomerName +
                    "\nMüşteri Soyadı: " + item.CustomerSurname +
                    "\nMüşteri Hesap No: " + item.CAccountNumber +
                    "\nMüşteri Hesap Bakiyesi: " + item.CustomerBalance +
                    "\nMüşteri Address: " + item.CustomerAddress +
                    "\nMüşteri Telefon No: " + item.CustomerTelephone +
                    "\n -------------------------------------------------------------");
                }
                else
                {
                    continue;
                }
                
            }
        }

        public void DeleteCustomer(int Id, ref Customer[] customerList)
        {
            Array.Clear(customerList, Id - 1, 1);

            Console.WriteLine(Id+ "id'li kullanıcı silinmiştir. Yeni Müşteri listesi: ");
            
            ShowAllCustomers(customerList);
        }
    }
}
