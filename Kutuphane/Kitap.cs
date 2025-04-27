using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kitap
    {
        private string _kitapAdi;
        private string _yazar;
        private string _isbn;

        public Kitap(string kitapAdi, string yazar, string isbn)
        {
            _kitapAdi = kitapAdi;
            _yazar = yazar;
            _isbn = isbn;
        }

        public string KitapAdi
        {
            get => _kitapAdi;
            set => _kitapAdi = value;
        }

        public string Yazar
        {
            get => _yazar;
            set => _yazar = value;
        }

        public string Isbn => _isbn;

        public void Yazdir()
        {
            Console.WriteLine($"Kitap Adı: {_kitapAdi}, Yazar: {_yazar}, ISBN: {_isbn}");
        }
    }
}
