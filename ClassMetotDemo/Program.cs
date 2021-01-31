using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir bankada müsteri takibi yapmak istiyoruz * Ekleme - Silme - Listeleme

            Musteri musteri1 = new Musteri();
            musteri1.Id = 10000001;
            musteri1.KimlikNo = "12345678901";
            musteri1.Adi = "Ahmet";
            musteri1.SoyAdi = "Şahin";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 10000002;
            musteri2.KimlikNo = "96325874109";
            musteri2.Adi = "Mehmet";
            musteri2.SoyAdi = "Kaya";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 10000003;
            musteri3.KimlikNo = "13579024681";
            musteri3.Adi = "Ayşe";
            musteri3.SoyAdi = "Kartal";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 10000004;
            musteri4.KimlikNo = "36987410253";
            musteri4.Adi = "Fatma";
            musteri4.SoyAdi = "Yılmaz";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            Console.WriteLine("MÜŞTERİLERİMİZ");
            Console.WriteLine(" ");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşterinin:");
                Console.WriteLine("Adı: " + musteri.Adi);
                Console.WriteLine("Soyadı: " + musteri.SoyAdi);
                Console.WriteLine("Müşteri Kodu: " + "#"+ musteri.Id);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("Liste bitti.");


            Console.WriteLine("--------------");
            Console.WriteLine("Musteri Ekleme");
            Console.WriteLine("--------------");

            MusteriManager musteriManager0 = new MusteriManager();
            musteriManager0.MuEkle(musteri1);
            musteriManager0.MuEkle(musteri3);


            Console.WriteLine("----------------");
            Console.WriteLine("Musteri Kaldırma");
            Console.WriteLine("----------------");

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.MuKaldır(musteri2);
            musteriManager1.MuKaldır(musteri4);






        }
    }
}
