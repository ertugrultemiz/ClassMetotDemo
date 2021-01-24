using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ertugrul";
            musteri1.Soyad = "Temiz";
            musteri1.Yas = 23;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Arzu";
            musteri2.Soyad = "Karakomur";
            musteri2.Yas = 20;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ahmet";
            musteri3.Soyad = "Yilmaz";
            musteri3.Yas = 52;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkleme(musteri1);
            musterimanager.MusteriEkleme(musteri2);
            musterimanager.MusteriEkleme(musteri3);

            musterimanager.MusteriSilme(musteri1);
            musterimanager.MusteriSilme(musteri2);
            musterimanager.MusteriSilme(musteri3);

            musterimanager.MusteriListeleme(musteri1);
            musterimanager.MusteriListeleme(musteri2);
            musterimanager.MusteriListeleme(musteri3);
        }
    }
}
