using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    class TavlaZari
    {
        /// <summary>
        /// Zarin alabileceği maksimum değer degiskeni
        /// </summary>
        int makZarDegeri;

        //rastgele sayı uretme
        Random rnd = new Random();

        /// <summary>
        /// Zarin alabilecegi maksimum değeri giriniz
        /// </summary>
        /// <param name="makZarDegeri"></param>
        //constructor
        public TavlaZari(int makZarDegeri)
        {
            this.makZarDegeri = makZarDegeri; // gelen degiskenle class daki degiskeni ayırır
        }

        /// <summary>
        /// Rastgale bir sayı icin zar at
        /// </summary>
        /// <returns></returns>
        public int ZarAt()
        {
            // 1 ile 8+1 arasında sayı üretecek,yani 1,2,3,4,5,6,7,8
            return rnd.Next(1,makZarDegeri+1);
        }

    }
}
