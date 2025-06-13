# 🔐 Kripto Araç Kutusu

🔑 RSA & SHA-256 Tabanlı Basit ve Güvenli Kriptografi Uygulaması

RSA, açık anahtarlı şifreleme algoritmasıdır ve veriyi güvenli şekilde şifrelemek için kullanılır.
Şifre çözme işlemi, yalnızca özel anahtara sahip olan kişi tarafından yapılabilir.
SHA-256, bir metin ya da dosyanın sabit uzunlukta ve eşsiz bir özetini üretir.
Bu yöntemler, veri gizliliğini ve bütünlüğünü korumada temel güvenlik araçlarıdır.

🌐 Canlı Uygulama Linki:
📎 [http://kriptokutusu.somee.com/](http://kriptokutusu.somee.com/) – Uygulamayı tarayıcınızda deneyin!

![image](https://github.com/user-attachments/assets/baddc637-8507-413e-8bf4-f51c96dc5a66)


# 🌟 Temel Özellikler

Bu sistem, RSA algoritmasıyla metin şifreleme (public key) ve çözme (private key) işlemlerini gerçekleştiriyor. Kullanıcılar kolayca yeni RSA anahtar çiftleri oluşturabiliyor ve bu anahtarlarla güvenli veri aktarımı yapabiliyor. Ayrıca, hem metinler hem de dosyalar için SHA-256 hash hesaplama özelliği sunuyor. Tüm bu işlemler, veri güvenliği ve bütünlüğünü sağlamak için kullanılıyor.


## 🖼️  Detaylı Ekran Görüntüleri ve Testler

### 1. RSA Şifreleme
![image](https://github.com/user-attachments/assets/2cba2120-7248-4ba4-99bb-a4150f09e046)   ![image](https://github.com/user-attachments/assets/43b49664-3741-4400-af6d-972446e73ab7)

Bu görsellerde RSA şifreleme süreci örnekleniyor. İlk görselde 'Merhaba Dünya!' metni, verilen public key kullanılarak şifreleniyor. İkinci görselde ise kullanıcı tarafından girilen 'Şifrelenecek metin...', yine bir public key ile işlenerek şifrelenmiş hale getiriliyor. Her iki örnek de asimetrik şifrelemenin temel işleyişini sergiliyor.

### 2. RSA Şifre Çözme
![image](https://github.com/user-attachments/assets/dc739896-011c-460c-85f3-38ea0a1e21ad)   ![image](https://github.com/user-attachments/assets/ef4123f5-bce1-4ed0-a37a-140b6338d8d2)

Bu görsellerde RSA şifre çözme işlemi adım adım gösteriliyor. İlk görselde, şifrelenmiş metin ve private key kullanılarak çözme işlemi başlatılıyor. İkinci görselde ise 'Merhaba Dünya!' gibi bir metnin, doğru private key ile şifresinin çözüldüğü ve orijinal içeriğin elde edildiği görülüyor. Bu örnekler, RSA'nın şifreleme ve çözme süreçlerinin nasıl çalıştığını net bir şekilde sergiliyor.

### 3. Anahtar Yönetimi
![image](https://github.com/user-attachments/assets/098cbf2a-a909-4661-a05c-c918d6768c59)   ![image](https://github.com/user-attachments/assets/afbb5cf5-8246-439a-9d9a-aab0dee6832d)

Bu görseller RSA şifreleme sistemindeki anahtar yönetim sürecini gösteriyor. İlk görselde Base64 formatında örnek public/private anahtar çifti ve şifreleme-çözme arayüzü bulunuyor. İkinci görselde ise 'YENİ ANAHTAR OLUŞTUR' butonuyla dinamik olarak yeni RSA anahtar çiftleri üretilebildiği ve bu anahtarların şifreleme işlemlerinde kullanılabileceği görülüyor.
Her iki örnekte de ---BEGIN--- ve ---END--- tag'leri arasında gösterilen anahtarlar, asimetrik şifrelemenin temel bileşenlerini oluşturuyor. Public key şifreleme, private key ise çözme işlemi için kullanılıyor.

### 4. SHA-256 Hash
**A) Metin Hashleme**
![image](https://github.com/user-attachments/assets/6a8933f0-2d20-4776-be49-aa72caad5f07)   ![image](https://github.com/user-attachments/assets/1cdf97cd-cd21-4229-acd8-ae5b23ded2ab)

Bu görseller SHA-256 hash algoritmasının kullanımını gösteriyor. İlk görselde 'Merhaba Dünya!' metninin hash değerini hesaplamak için arayüz görülürken, ikinci görselde hesaplanmış örnek bir SHA-256 hash değeri (64 karakterlik hexadecimal bir dize) sunuluyor. SHA-256, tek yönlü bir şifreleme fonksiyonu olup girilen metin veya dosyalardan benzersiz 256-bit hash değerleri üretir.

**B) Dosya Hashleme**
![image](https://github.com/user-attachments/assets/21a5455e-3c23-479e-8915-d0ab02811712)   ![image](https://github.com/user-attachments/assets/66fcb076-c598-404e-b3ce-27603e2370e4)

Bu görseller, SHA-256 algoritması kullanarak dosyaların hash değerlerinin nasıl hesaplandığını gösteriyor. İlk görselde kullanıcının hash'ini hesaplamak istediği dosyayı seçebileceği bir dosya tarayıcı arayüzü bulunuyor. Kullanıcılar PDF, DOCX gibi çeşitli dosya türlerini seçebiliyor. İkinci görselde ise 'deneme.pdf' dosyası için hesaplanmış gerçek bir SHA-256 hash örneği görülüyor: '9E3FBF...5BAEE4'. Bu 64 karakterlik hexadecimal hash kodu, dosyanın dijital parmak izi gibi çalışarak dosya bütünlüğünü doğrulamaya yarıyor. SHA-256 dosya hashleme özellikle yazılım dağıtımlarında, dijital sertifikalarda ve güvenli dosya transferlerinde sıkça kullanılıyor.


## 🛠️ Teknoloji Yığını
### Backend
- **ASP.NET Core MVC** (v9.0)
- **C#** (System.Security.Cryptography kütüphanesi)
- **RSA Anahtar Boyutu**: 2048-bit
- **SHA-256** Implementasyonu

### Frontend
- **Bootstrap 5** (Responsive tasarım)
- **JavaScript** (Dosya işlemleri ve UI etkileşimleri)
- **Clipboard API** (Kopyala butonları için)

## ⚙️ Kurulum

Projeyi yerel ortamınızda çalıştırmak için:

```bash
git clone https://github.com/Abood88088/KriptolojiWeb.git
cd KriptolojiWeb
dotnet restore
dotnet run 
```

## 🚀 Uygulamanın Çalıştırılması

Kurulum tamamlandıktan sonra, `dotnet run` komutu ile uygulamayı başlatın ve tarayıcınızdan `https://localhost:5001` adresine giderek deneyebilirsiniz.


## 👨‍💻 Geliştirici
**ABDUL RAHMAN KHANOUM**

<!-- Burada boş satır -->
