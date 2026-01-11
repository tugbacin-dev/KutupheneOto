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
![Kitap İşlemleri](https://github.com/user-attachments/assets/8d46c597-34eb-4866-b5e6-a084671c1fa3)

Kitap İşlemleri, kütüphanede bulunan tüm kitapların envanter durumunu (stokta, ödünçte, kayıp) görselleştiren ve bu verileri hızlıca yönetmeni sağlayan bir ekrandır. Bu ekran; kitap adlarını, yazarları ve güncel stok bilgilerini düzenli bir tablo yapısıyla sunar. Personel, bu panel üzerinden kitapların durumunu kolayca takip edebilir ve yeni kayıtlar oluşturabilir.

---

## 👥 Üye İşlemleri

![Üye İşlemleri](https://github.com/user-attachments/assets/cb47b011-1533-4836-ab1c-cace4c50f4a8)
)

**Üye İşlemleri**, kütüphaneye kayıtlı tüm okuyucuların bilgilerini ve üyelik durumlarını merkezi bir yapıda yönetmenizi sağlayan ekrandır. Bu ekran; üye bilgilerini, iletişim detaylarını ve üyelik geçmişini düzenli bir tablo yapısıyla sunar. Personel, bu panel üzerinden yeni üye kayıtlarını kolayca oluşturabilir, mevcut bilgileri güncelleyebilir ve hangi üyenin aktif olduğunu hızlıca takip edebilir.






