# Promosyon Takip Uygulaması

Bu proje, mağazaların potansiyel müşterilerini ve bu müşterilere sunulan promosyonları takip etmelerini sağlayan bir **masaüstü uygulamasıdır**. Mağaza yetkilileri, sisteme giriş yaparak müşteri bilgilerini kaydedebilir ve onlara rastgele seçilen promosyon kodları atayabilirler.

## Proje Bileşenleri

- **promosyonTakip.core.BusinessLogicService:** İş mantığı katmanını içerir. Müşteri, promosyon ve mağaza işlemleri bu katmanda yönetilir.
- **promosyonTakip.core.entities:** Veritabanı tablolarına karşılık gelen varlık (entity) sınıflarını tanımlar.
- **promosyonTakip.core.Database:** Veritabanı bağlantısını ve temel CRUD (Create, Read, Update, Delete) işlemlerini yöneten sınıfları içerir. **Microsoft SQL Server** kullanılmaktadır.

## Veritabanı Kurulumu

Projenin çalışması için bir Microsoft SQL Server veritabanı gereklidir. Sağlanan SQL betiğini kullanarak veritabanını ve tabloları oluşturabilirsiniz.

1.  Microsoft SQL Server Management Studio'yu açın.
2.  `create database promosyonSepeti` komutunu çalıştırarak veritabanını oluşturun.
3.  Sağlanan SQL betiğinde yer alan `create table` ve `insert into` komutlarını sırasıyla çalıştırarak tabloları ve başlangıç verilerini oluşturun.
4.  Eğer sunucu adınız (`ABDULLAH\SQLEXPRESS01`) farklıysa, `promosyonTakip.core.Database` sınıfındaki `conncetionStringOlustur()` metodunu kendi sunucu adınızla güncelleyin.

## Uygulamanın Derlenmesi ve Çalıştırılması

1.  Projeyi bir IDE'ye (örneğin Visual Studio) yükleyin.
2.  Tüm bağımlılıkların (örneğin `System.Data.SqlClient`) yüklü olduğundan emin olun.
3.  Projenin "Solution Explorer" bölümünde yer alan tüm bağımlılıkları kontrol edin. Eksik varsa, NuGet paket yöneticisi aracılığıyla kurun.

## Kullanıcı Bilgileri

Sisteme giriş yapabileceğiniz mağaza kullanıcıları aşağıdadır:

| Kullanıcı Adı | Şifre |
| :--- | :--- |
| abdullah | 1 |
| ali | 1 |
| murat | 1 |

Bu bilgilerle uygulamaya giriş yapabilirsiniz.


