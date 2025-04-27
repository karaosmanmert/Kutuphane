Senaryo: Bir kütüphane sisteminde üye kaydı, kitap kaydı, ödünç kitap verme ve iade alma işlemlerini simüle eden konsol tabanlı uygulama.
Kapsam:
•	Yeni genel üye (Kisi) ve öğrenci üye (OgrenciKisi) kaydı
•	Kitap bilgisi tanımlama (Kitap)
•	Ödünç verme işlemi (Odunc)

Sınıf ve Nesne (Class & Object): Kisi, OgrenciKisi, Kitap, Odunc sınıfları.
Tüm sınıflardaki alanlar (_id, _ad, _kitapAdi, _iadeTarihi vb.) private olarak tanımlandı.
OgrenciKisi sınıfı, Kisi sınıfından türetildi.
override ile Yazdir() metodu genişletilerek öğrenciye özgü ek bilgi (sınıf seviyesi) eklendi.

Uygulama başlatıldığında konsolda ana menü görüntülenir.
Kullanıcı seçim yapar ve ilgili işlemi gerçekleştiren metoda yönlendirilir.
Örneğin "3. Kitap ödünç ver" seçildiğinde:
•	Mevcut üyeler listelenir,
•	Seçilen üyenin ID’si ile Kisi nesnesi alınır,
•	Kitaplar listelenir,
•	Seçilen kitap numarası ile Kitap nesnesi alınır,
•	Odunc nesnesi oluşturulur, listelere eklenir ve ödünç bilgisi ekrana yazdırılır.
 
"4. Kitap iade al" seçildiğinde mevcut ödünç işlemleri listelenir, kullanıcı iade edilecek satırı seçer ve işlem listeden silinerek iade bildirimi gösterilir.
 

