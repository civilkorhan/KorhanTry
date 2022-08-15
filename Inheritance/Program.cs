using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Student{FirstName="Şevval"},
                new Person { FirstName = "Furkan" },
                new Teacher{FirstName="Korhan" },
                //new Manager{FirstName="Yeşim" } //manager classını inherite etmediğim için dizinin içinde kullanamadım yani onun referasnsını alamadım..
            };
            foreach (Person person in persons)
            {

                Console.WriteLine(person.LastName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
    class Student:Person //inherite ederken yalnız bir class bir ebeveyn kullanabiliriz..
                         //ama inteface de implamente ederken birçok interface kullanabiliriz..
    {
        public string City { get; set; }  // student'ın kendine özel properties'i..

    }
    class Teacher:Person
    {


    }
    class Manager
    {

        public string FirstName { get; set; }
    }
}
