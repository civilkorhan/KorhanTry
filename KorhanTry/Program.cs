using System;

namespace KorhanTry
{
     class Program
    {
        static void Main(string[] args)
        {
            KorhanList<int> loto= new KorhanList<int>(); //listemizin kullanımı bu şekilde  burada class olanlar yeşil-turkuaz renkte yazılır..
                                                         //kullanım tipi classımızı yazdık tipimizi girdik nesnemizi yazdık (burada loto örneğin) yeni alan oluşturduk class ismimizi ve veri tipimizi tekrar yazdık..
            loto.Ekle(45);   // loto nesnemize 45 sayısını ekledik..
                            //Listeleme aslında bir array'i yani bir diziyi kontrol eder.Bizim buradaki nesnemiz olan loto bir dizi durumunda..
        }
    }
}
