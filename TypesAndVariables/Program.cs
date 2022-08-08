using System;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENGİN DEMİROĞ Hocamızın youtube derslerinden aldığım notlardır..
            //condition=şart demektir..
            decimal number6 = 10.4m; //kullanımı için M veya m harfi kullanılır..
            double number5 = 10.4; //ondalıklı sayıları yazdırmada kullanılır.. 64 bit lik yer kaplar
            char character = 'A';
            bool condition = true; //tuttuğu değer true veya false'dur.. if gibi karşılakştırma bloklarında kullanılır..
            byte number4 = 34; //0-255 arasındaki tam sayıları tutabilir..
            short number3 = 24434; //16 bit yer kaplar..
            int number1 = 4353535;  //veri tipimiz integer veri ismimiz number1..
                                    //int değer tipinin sınırı vardır 2147483648'dir..
            long number2 = 280449334; //long veri tipimiz int değişkeninin 2 katı kadar alan kaplar.. 
                                      //int 32 bit,long 64 bit yer kaplar..
                                      //amacımız bellekte minimum alan kaplamak..
            var number7 = 10;  //artık var değişkenin bir int olduğunu söyledik..
            number7 = 'A'; //bu durumu yazdırırsak char değişkeninin önüne integer koymuş oluruz ve bize 65 değerini verir..
            Console.WriteLine("Number 1 is: {0}", number1);  //süslü parantezin içindeki sıfır virgülden sonraki ilk değeri temsil eder.Sıralamalar sıfırdan başlar..
            Console.WriteLine("Number 2 is: {0}", number2);
            Console.WriteLine("Character is: {0}",(int)character); // A kelimesinin klavyede hangi sayıya denk geldiğini yazdırdık..
            Console.WriteLine("Character is: {0}", character);
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Friday); //yine sayısala dönüştürdük friday değerinin karşılığını..
            Console.ReadLine();  //amaç konsol ekranının kapanmaması..
            //8 bit 1 byte yer kaplar..
            // verimizi ekrana yazdırmak için "" çift tırnak metin yazacağımız zaman kullanılır virgülden sonra veri ismimizi yazmalıyız..
            // int için long ne ise double için de decimal o dur..
            //decimali daha hassasiyetli durumalarda kullanılır örneğin döviz kuru için kullabiliriz ..
        }

    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday  //sıralama otomatik olarak sıfırdan başlar ama başlangıç değerini biz atayabiliriz..

    }
}
