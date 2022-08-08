using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Add4(23,34,55,81,93));
            Console.WriteLine(Çarpma(23,42,74));  //metota aşırı yükleme overloading yaptık..
            Console.WriteLine(Çarpma(89, 45));
            int number1 = 20;
            int number2 = 100;

            Console.WriteLine(number1); //20 yazar..
            int result2=Add3( ref number1, number2); //130 yazar metotda number1 30'a atandı
            Console.WriteLine(result2); //130 yazar..
            Console.WriteLine(number1); //30 yazar.. burada önce metodu çalıştırdık..
            Add();   //metodumuzu çağırdık..
            Add();
            int result= Add2(45, 18);
            Console.WriteLine(result);
            Console.Read();       // Don't repeat yourself ..
        }
        static void Add()   //metodumuzun adı Add ..
        {
            Console.WriteLine("Added!");    //metodumuzun yağacapı işlemler süslü parantez içine yazılır..
                                            // metodu değiştirmek artık daha kolay tek bir yerde değişiklik yaptığımızda metodu çağırdığımız yerler de değişecek..

        }
        //void yerine ne tipte bir veri döndürmek istiyorsak onu yazabiliriz..
        static int Add2(int number1,int  number2)
        {
            var result= number1 + number2; //burada işlem yapıp sonucunu döndürdük..
          return result;  // return kullanacaksak voidi int yapmalıyız..


            
        }
        static int Add3( ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;

        }
        static int Çarpma(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Çarpma(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        //params parametrelerin son parametresi olmalı..
        static int Add4(params int[] numbers)  //params keyword'ü ile istediğimzi kadar parametre ekleyebiliriz..
        {
            return numbers.Sum(); //Sum hazır bir metotdur dizilerdeki değerlerin hepsini topla demektir..

        }
    }
}
