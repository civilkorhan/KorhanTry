using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
     class Customer   //classlar fonksiyon-metot- operasyon tutar veya özellik- properties tutar..
                             //burada özellik tutuyor..
    {
        public int Id { get; set; }  // set bloğu özelliğin karşısına yazdırılan durumda çalışır.. get ise eşitlik bulunmayıp yanıt istendiğinde çalışır..
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
