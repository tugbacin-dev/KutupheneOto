# KÜTÜPHANE OTOMASYON SİSTEMİ
Kütüphane otomasyon sistemi, kitap kayıtları, üye işlemleri ve ödünç verme süreçlerini dijital ortamda yönetmeyi sağlayan bir yazılımdır. Bu sistemler, veritabanı entegrasyonu sayesinde manuel iş yükünü azaltarak raporlama ve takip işlemlerini hızlandırır.

---

# 📌PROJE ÖZELLİKLERİ
Giriş ve Yetkilendirme: Yönetici ve personel hesapları için güvenli kullanıcı doğrulaması.

Dinamik Dashboard (Raporlar): İadesi yaklaşan, geciken kitaplar ile popüler kitapların ve aktif üyelerin anlık takibi.

Üye İşlemleri: Kütüphane üyelerinin bilgilerini kaydetme, güncelleme, silme ve detaylı listeleme.

Kitap Yönetimi: Kitapların yazar, sayfa sayısı ve stok adetleriyle birlikte sisteme kaydedilmesi ve yönetilmesi.

Emanet (Ödünç) İşlemleri: Kitapların üyelere ödünç verilmesi, teslim tarihlerinin takibi ve iade durumlarının güncellenmesi.

İstatistiksel Analiz: En çok okunan kitaplar ve en aktif üyeler üzerinden kütüphane kullanım verilerinin görüntülenmesi.

---

# 🛠 Kullanılan Teknolojiler
Programlama Dili: C# (.NET Framework)

Arayüz: Windows Forms (Masaüstü Uygulama Geliştirme)

Veritabanı: MySQL (Verilerin güvenli ve ilişkisel bir yapıda tutulması)

Mimari Yapı: Katmanlı Mimari (DAO - Veri Erişimi, Service - İş Mantığı, UI - Kullanıcı Arayüzü)

Tasarım Yaklaşımı: Modern ve Kullanıcı Dostu Arayüz

---

# 📸 Ekran Görüntüleri

## 🔐 Giriş Sayfası ve Güvenlik

![Giriş Sayfası](https://github.com/user-attachments/assets/80648c78-4741-45ab-a383-8fed09092bd6)

Giriş Sayfası, kütüphane yönetim sistemi kullanıcılarının uygulamaya güvenli bir şekilde erişim sağlamasını ve yetkilerine göre doğru işlemlere yönlendirilmesini sağlar. Kullanıcı, `kullanici_ad` ve `sifre` bilgilerini girdiğinde sistem, `kullanicilar` tablosu üzerinden bir doğrulama yapar. 

Bu kontrol sonucunda, kullanıcının **Yönetici (A)** mi yoksa **Personel (Y)** mi olduğu belirlenir ve sistem kullanıcıyı bu doğrultuda yetkilendirilmiş ana sayfaya otomatik olarak yönlendirir.

---

## 🏠 Ana Menü ve Navigasyon

![Ana Menü](https://github.com/user-attachments/assets/c884f060-9727-4821-948e-bb6debd134c2)

**Ana Menü ve Navigasyon**, kütüphane yönetimindeki tüm temel modüllere hızlı erişim sağlayan merkezi kontrol panelidir. Bu ekran; kitap, üye, ödünç ve raporlama işlemlerini görsel ikonlarla kategorize ederek kullanıcı deneyimini kolaylaştırır. Personel, bu panel üzerinden tüm kütüphane operasyonlarını tek bir noktadan yönetebilir ve modüller arası hızlı geçiş yapabilir.

---

## 📚 Kitap Envanter Yönetimi
![Kitap İşlemleri](https://github.com/user-attachments/assets/3ce135ac-9dfa-4e84-86aa-8f3ca8007693)


Kitap İşlemleri, kütüphanede bulunan tüm kitapların envanter durumunu (stokta, ödünçte, kayıp) görselleştiren ve bu verileri hızlıca yönetmeni sağlayan bir ekrandır. Bu ekran; kitap adlarını, yazarları ve güncel stok bilgilerini düzenli bir tablo yapısıyla sunar. Personel, bu panel üzerinden kitapların durumunu kolayca takip edebilir ve yeni kayıtlar oluşturabilir.

---

## 👥 Üye İşlemleri

![Üye İşlemleri](https://github.com/user-attachments/assets/74e531a8-a7a5-447b-aff6-e5db4ca27121)


**Üye İşlemleri**, kütüphaneye kayıtlı tüm okuyucuların bilgilerini ve üyelik durumlarını merkezi bir yapıda yönetmenizi sağlayan ekrandır. Bu ekran; üye bilgilerini, iletişim detaylarını ve üyelik geçmişini düzenli bir tablo yapısıyla sunar. Personel, bu panel üzerinden yeni üye kayıtlarını kolayca oluşturabilir, mevcut bilgileri güncelleyebilir ve hangi üyenin aktif olduğunu hızlıca takip edebilir.

---

## 📚 Ödünç İşlemleri Modülü

![Ödünç İşlemleri](https://github.com/user-attachments/assets/05a58ecb-a293-4f72-bb4d-38e806d3b1cb)


**Ödünç İşlemleri ekranı**, kayıtlı üyelerin kütüphanedeki kitapları ödünç alma süreçlerinin yönetildiği ve takip edildiği bir modüldür. Bu ekran üzerinden kitap ve üye eşleştirmesi yapılarak konaklama/ödünç süreleri belirlenir ve işlem sonrası veritabanındaki durum bilgileri otomatik olarak güncellenir. Yapılan tüm kayıtlar, iade tarihleri ve güncel durumlarıyla birlikte anlık olarak liste üzerinden izlenebilir.

---

## 📚 🔄 İade İşlemleri Modülü

![İade_İşlemleri](https://github.com/user-attachments/assets/e7ec3131-57a5-4df1-a6e1-ab9ec4de54db)

**İade İşlemleri ekranı**, üyelerin ödünç aldığı kitapları geri teslim etme süreçlerini yöneten modüldür. Kullanıcı, üye ve kitap bilgilerini girerek iade işlemini gerçekleştirir; bu işlem sonucunda veritabanındaki kayıtlar güncellenerek kitabın kütüphaneye geri döndüğü anlık olarak sisteme yansıtılır.

---

## 📊 Raporlama ve İstatistik Modülü

![Raporlama_Modülü](https://github.com/user-attachments/assets/b10ccbf7-b8c1-4dbe-a6f7-b11825b0d620)

Raporlar ekranı, kütüphanedeki hareketliliği genel hatlarıyla izlemeyi sağlayan bir özet panelidir. Bu sayfa sayesinde en çok tercih edilen kitaplar ve en aktif üyeler gibi istatistikler tek bir ekrandan kolayca takip edilebilir. Ayrıca iadesi yaklaşan veya geciken kitapların takibi yapılarak sistemin güncel durumu kontrol altında tutulur.

---
## 🚀 Kurulum ve Kullanım

**Projeyi İndirin:** Kaynak kodları bilgisayarınıza indirin ve Visual Studio ile açın.

**Veritabanı Ayarı:** DatabaseHelper.cs dosyası içerisinden sisteminize uygun bağlantı bilgilerini tanımlayın.

**Çalıştırın:** Uygulamayı başlatın; üye, kitap ve ödünç işlemlerini menülerden yönetmeye başlayın.

**Raporları İzleyin:** Kütüphane genel istatistiklerini raporlar ekranından görüntüleyin

## 🛠️ Proje Yapısı

DAO (Data Access Object): Veritabanı bağlantı ayarları ve temel SQL sorgularının yönetildiği katman.

Domain: Projede kullanılan nesne modellerinin (Üye, Kitap vb.) tanımlandığı bölüm.

Services: İş mantığının yürütüldüğü ve verilerin işlendiği servis katmanı.

UI (User Interface): Kullanıcı etkileşimini sağlayan Windows Forms (AnaForm, OduncForm, IadeForm vb.) arayüzleri

## ✨ Proje Hedefleri

**Kütüphane Süreçlerini Dijitalleştirmek:** Kitap ödünç verme ve iade süreçlerini dijital ortama taşıyarak iş akışını hızlandırmak.

**Kullanıcı Dostu Yönetim:** Karmaşık veritabanı işlemlerini sade bir arayüz üzerinden kolayca yönetebilmek.

**Veriye Dayalı Analiz:** Üye ve kitap hareketlerini raporlayarak kütüphane istatistiklerini anlık olarak takip etmek.

## 📞 İletişim

Herhangi bir sorunuz veya öneriniz varsa lütfen benimle iletişime geçin:

**Ad:** Tuğba
**Soyad:** Cin
**Tel No:** +90 552 845 39 48
**E-posta:** tugbbacin@gmail.com

---

## ▶𝚈𝚘𝚞𝚝𝚞𝚋𝚎 Video

https://youtu.be/p3lXuB0gb9g?si=pTlUxhHP5ucRzRsZ







