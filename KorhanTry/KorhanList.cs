using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorhanTry
{
     class KorhanList<T>
    {
        T[] elemanlar;
        public KorhanList()
        {
            elemanlar = new T[0]; //class'ımızı newlediğimzide burası otomatik olarak çalışacak ..
                                  //biz burada dizimizin şu an sıfır elemanlı olduğunu gösterdik..
        }
        public void Ekle(T eleman) // T tipinde string,integer olabilir mesela, eleman ekle dedik..
        {
            T[] GeciciDizi = elemanlar; // T tipinde geçici dizi oluşturduk ve bu dizinin de elemanlar dizisine  eşit olduğunu söyledik artık elemanlar dizisini tutan bir dizimiz var..(ödünç verdik)
            elemanlar = new T[elemanlar.Length + 1];   // elemanlar dizimize dinamik olarak 1  veri kadar artıracak şekilde tasaladık..
            for (int i = 0; i < GeciciDizi.Length; i++)
            {
                elemanlar[i] = GeciciDizi[i]; //elemanlar dizimizin i elemanı geçici dizimizin i elemanına eşit olduğunu söyledik.. yani elemanları geri aldık(ödün. verdiklerimizi geri aldık)
            }
            elemanlar[elemanlar.Length - 1] = eleman; // elemanlar dizimizin son elemanı add ile eklediğimiz yeni "eleman" olduğunu nihayetinde söylemiş olduk..
            Console.WriteLine(elemanlar[elemanlar.Length-1]); // elemanlar dizimize son eklenen elemanı yazdırdık buradaki metodu artık program cs de kullabiliriz..
        }
    }
}
