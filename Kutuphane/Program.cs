using System;
using System.Collections.Generic;

namespace Kutuphane
{
    class Program
    {
        // Listeler sınıfın içinde tanımlandı
        static List<Kisi> kisiler = new List<Kisi>();
        static List<Kitap> kitaplar = new List<Kitap>();
        static List<Odunc> oduncList = new List<Odunc>();

        static void Main(string[] args)
        {
            // Örnek veriler
            kisiler.Add(new OgrenciKisi(1, "Ali", "Yılmaz", "10A"));
            kitaplar.Add(new Kitap("C# Programlama", "Ahmet Yılmaz", "1234567890"));

            bool calisiyor = true;
            while (calisiyor)
            {
                Console.Clear();
                Console.WriteLine("===== KÜTÜPHANE SİSTEMİ =====");
                Console.WriteLine("1. Yeni kişi kaydı");
                Console.WriteLine("2. Yeni öğrenci kaydı");
                Console.WriteLine("3. Kitap ödünç ver");
                Console.WriteLine("4. Kitap iade al");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminiz: ");

                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        KayitKisi();
                        break;
                    case "2":
                        KayitOgrenci();
                        break;
                    case "3":
                        OduncVer();
                        break;
                    case "4":
                        IadeAl();
                        break;
                    case "5":
                        calisiyor = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, tekrar deneyin.");
                        Pause();
                        break;
                }
            }
        }

        static void KayitKisi()
        {
            Console.Clear();
            Console.WriteLine("=== Yeni Kişi Kaydı ===");
            Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
            Console.Write("Ad: "); string ad = Console.ReadLine();
            Console.Write("Soyad: "); string soyad = Console.ReadLine();

            kisiler.Add(new Kisi(id, ad, soyad));
            Console.WriteLine("Kişi başarıyla eklendi.");
            Pause();
        }

        static void KayitOgrenci()
        {
            Console.Clear();
            Console.WriteLine("=== Yeni Öğrenci Kaydı ===");
            Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
            Console.Write("Ad: "); string ad = Console.ReadLine();
            Console.Write("Soyad: "); string soyad = Console.ReadLine();
            Console.Write("Sınıf: "); string sinif = Console.ReadLine();

            kisiler.Add(new OgrenciKisi(id, ad, soyad, sinif));
            Console.WriteLine("Öğrenci başarıyla eklendi.");
            Pause();
        }

        static void OduncVer()
        {
            Console.Clear();
            Console.WriteLine("=== Kitap Ödünç Ver ===");
            if (kitaplar.Count == 0 || kisiler.Count == 0)
            {
                Console.WriteLine("Önce kitap ve üye kaydı yapmalısınız.");
                Pause();
                return;
            }

            Console.WriteLine("Üyeler:");
            foreach (var k in kisiler)
                k.Yazdir();
            Console.Write("Ödünç vereceğiniz üye ID: ");
            int uid = int.Parse(Console.ReadLine());
            var kisi = kisiler.Find(k => k.Id == uid);
            if (kisi == null)
            {
                Console.WriteLine("Üye bulunamadı.");
                Pause();
                return;
            }

            Console.WriteLine("\nKitaplar:");
            for (int i = 0; i < kitaplar.Count; i++)
                Console.WriteLine($"{i + 1}. {kitaplar[i].KitapAdi} by {kitaplar[i].Yazar}");
            Console.Write("Seçmek istediğiniz kitap numarası: ");
            int kitapNo = int.Parse(Console.ReadLine()) - 1;
            if (kitapNo < 0 || kitapNo >= kitaplar.Count)
            {
                Console.WriteLine("Geçersiz kitap seçimi.");
                Pause();
                return;
            }

            var kitap = kitaplar[kitapNo];
            var odunc = new Odunc(kitap, kisi);
            oduncList.Add(odunc);

            Console.WriteLine("\nÖdünç verme başarılı:");
            odunc.Tarih();
            Pause();
        }

        static void IadeAl()
        {
            Console.Clear();
            Console.WriteLine("=== Kitap İade Al ===");
            if (oduncList.Count == 0)
            {
                Console.WriteLine("Henüz ödünç verilmiş kitap yok.");
                Pause();
                return;
            }

            for (int i = 0; i < oduncList.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                oduncList[i].Tarih();
            }
            Console.Write("İade alınacak işlem numarası: ");
            int no = int.Parse(Console.ReadLine()) - 1;
            if (no < 0 || no >= oduncList.Count)
            {
                Console.WriteLine("Geçersiz seçim.");
                Pause();
                return;
            }

            var secilen = oduncList[no];
            Console.WriteLine("\nİade alındı:");
            secilen.Iade();
            oduncList.RemoveAt(no);
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
