using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Odunc
    {
        private Kitap _kitap;
        private Kisi _kisi;
        private DateTime _alisTarihi;
        private DateTime _iadeTarihi;

        // Sadece kitap ve kişi alacak, tarihleri otomatik atayacak
        public Odunc(Kitap kitap, Kisi kisi)
        {
            _kitap = kitap;
            _kisi = kisi;
            _alisTarihi = DateTime.Today;
            _iadeTarihi = _alisTarihi.AddDays(14);
        }

        public void Tarih()
        {
            Console.WriteLine(
                $"Kitap Adı: {_kitap.KitapAdi}, " +
                $"Üye ID: {_kisi.Id}, " +
                $"Alış Tarihi: {_alisTarihi:dd.MM.yyyy}, " +
                $"İade Tarihi: {_iadeTarihi:dd.MM.yyyy}");
        }

        public void Iade()
        {
            Console.WriteLine(
                $"Kitap Adı: {_kitap.KitapAdi}, " +
                $"Üye ID: {_kisi.Id}, " +
                $"İade Tarihi: {_iadeTarihi:dd.MM.yyyy}");
        }

        public DateTime BitisTarih() => _iadeTarihi;
    }
}
