using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();  //önce class'ın kullanımına örnek verdik özelliklerini program cs de kullandık..
            customer.Id = 1;
            customer.FirstName = "Korhan";
            customer.LastName = "Dalmaz";
        }
    }
}
