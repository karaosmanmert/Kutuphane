using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kisi
    {
        private int _id;
        private string _ad;
        private string _soyad;

        public Kisi(int id, string ad, string soyad)
        {
            _id = id;
            _ad = ad;
            _soyad = soyad;
        }

        public int Id => _id;
        public string Ad => _ad;
        public string Soyad => _soyad;

        public virtual void Yazdir()
        {
            Console.WriteLine($"Üye ID: {_id}, Ad: {_ad}, Soyad: {_soyad}");
        }
    }
}
