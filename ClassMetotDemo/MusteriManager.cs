using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)

        
	    {
            Console.WriteLine("Musteri eklendi : " + musteri.Ad + " " + musteri.Soyad);
        }       
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi : " + musteri.Ad + " " + musteri.Soyad);
        }
        public void MusteriListeleme(Musteri musteri)
            
        {
                Console.WriteLine("Ad Soyad : " + musteri.Ad + " " + musteri.Soyad);
                Console.WriteLine("Yas : " + musteri.Yas);
        }
    }
}
