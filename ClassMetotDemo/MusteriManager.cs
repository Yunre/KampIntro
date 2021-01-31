using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MuEkle(Musteri musteri)
        {
            Console.WriteLine("#"+ musteri.Id + " Id'li Müşteri başarıyla eklendi.");
            //
        }

        public void MuKaldır(Musteri musteri)
        {
            Console.WriteLine("#" + musteri.Id + " Id'li Müşteri başarıyla kaldırıldı.");
        }
    }
}
