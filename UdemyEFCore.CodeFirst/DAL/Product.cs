using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.CodeFirst.DAL
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public int Barcode { get; set; }
    }

    //Migration console komutları add migration ve isim veriyorsun
    //add-migration isim veriyorsun sonra
    //bunu güncellemek için update-database diyorsun.
    //silmek için remove-migration son oluşturulanı siler
    //ortadaki migrationu silmek için önce onun üstündeki migrationa gel odnan sonra silme yap en saglık sistem bu 
    // update-migration migrationun ismi ondan sonra remove yapmamız gerekiyor.
    //script migration sql kodlarını veriyor yani migration da yaptıgımız butun kodları tekrardan sql e cevırıyor 
    //bunun sayesinde sql kodlarını görüp sql üzerinde bilgi sahibi olmamızı saglıyor
}
