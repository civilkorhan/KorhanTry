using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal()

            };
            foreach (var customerDal in customerDals)
            {
              customerDal.Update();

            }









            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Address = "Ankara", FirstName = "Korhan", LastName = "DALMAZ", Id = 1 });
        }
    }
    //interface yapısı gereği diğer sınıflara yol gösterici rehberlik edicidir..
    //interface bir class ın özelliklerini sağlayan beyandır..
    interface IPerson    //interfaceler soyut 
    {
        int Id { get; set; }  //tamamen metodun imzası yazılır.. public kısmını attık..
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer : IPerson        //classlar somuttur 
                                    //IPerson'ın içindekiler artık customer ve student da kullanılabilir..
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }  // yukarıdaki özellikler implemenete edilenlerdi ama bu customer sınıfına ait ayrı bir özellik..
    }
    class student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; } // yukarıdaki özellikler implemenete edilenlerdi ama bu student  sınıfına ait ayrı bir özellik..
    }
    class PersonManager
    {
        public void Add(IPerson person) // Bu durumda Iperson'ı inheritide eden classlar parantez içine yazılabilir spesifik bir class yazmaaktan kurtarır..
        {
            Console.WriteLine(person.FirstName);

        }
    }
}
