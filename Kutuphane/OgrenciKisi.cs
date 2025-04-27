using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class OgrenciKisi : Kisi
    {
        private string _sinif;

        public OgrenciKisi(int id, string ad, string soyad, string sinif)
            : base(id, ad, soyad)
        {
            _sinif = sinif;
        }

        public string Sinif
        {
            get => _sinif;
            set => _sinif = value;
        }

        public override void Yazdir()
        {
            Console.WriteLine(
                $"Üye ID: {Id}, Ad: {Ad}, Soyad: {Soyad}, Sınıf: {_sinif}");
        }
    }
}
