using System;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Work();
            Robot robot = new Robot();
            robot.Work();
            Console.ReadLine();
        }
    }
    interface IWork
    {
        void Work();
        

    }
    interface IEat
    {
        void Eat();

    }
    interface ISalary
    {

        void GetSalary();
    }
    class Manager : IWork, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Çalıştı!");
        }
    }
    class Worker : IEat, ISalary, IWork
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot Çalıştı!");
        }
    }


}
