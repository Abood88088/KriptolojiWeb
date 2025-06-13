# 🔐 Kripto Araç Kutusu

**RSA Şifreleme, Çözme, Anahtar Yönetimi ve SHA-256 Hash Hesaplama Uygulaması**

RSA, açık anahtarlı şifreleme algoritmasıdır ve veriyi güvenli şekilde şifrelemek için kullanılır.
Şifre çözme işlemi, yalnızca özel anahtara sahip olan kişi tarafından yapılabilir.
SHA-256, bir metin ya da dosyanın sabit uzunlukta ve eşsiz bir özetini üretir.
Bu yöntemler, veri gizliliğini ve bütünlüğünü korumada temel güvenlik araçlarıdır.

🌐 Canlı Uygulama Linki:
📎 [http://kriptolojiweb.somee.com/](http://kriptokutusu.somee.com/) – Uygulamayı tarayıcınızda deneyin!

![image](https://github.com/user-attachments/assets/baddc637-8507-413e-8bf4-f51c96dc5a66)


## 🌟 Temel Özellikler
| Özellik | Açıklama |
|---------|----------|
| **RSA Şifreleme** | Public key ile metin şifreleme |
| **RSA Çözme** | Private key ile şifre çözme |
| **Anahtar Üretme** | Dinamik RSA anahtar çifti oluşturma |
| **SHA-256 Hash** | Metin ve dosyalar için hash hesaplama |


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
Anahtar yönetimi bölümleri, kullanıcıların yeni anahtar çiftleri oluşturabileceğini ve bu anahtarları şifreleme/çözme işlemlerinde kullanabileceğini gösteriyor. Anahtarların kopyalanabilir olması pratik kullanım kolaylığı sağlıyor.

### 4. SHA-256 Hash
**Test Senaryosu**:  
![image](https://github.com/user-attachments/assets/2c879ce2-84e4-4a1f-8ba9-0ce0833d0da2)   ![image](https://github.com/user-attachments/assets/106c207c-b3f7-4e63-845c-e80370be3309)

**A) Metin Hashleme**
- **Girdi**: kriptoloji123
- **Hash Sonucu**: 32f69...11f22 (64 karakter hex)
- *✅ Doğrulama: Online SHA-256 tool ile aynı sonuç alındı.*

![image](https://github.com/user-attachments/assets/52c63287-7bc9-4cb9-a028-87a5c8a8e93e)   ![image](https://github.com/user-attachments/assets/cc076920-09c4-4b50-b894-8b25cbbcf53d)

**B) Dosya Hashleme**
- **Test Dosyası**: example.txt (İçerik: TEST123)
- **Hash Sonucu**: 56A70...D629F008
- *✅ Doğrulama: Online SHA-256 File tool ile aynı sonuç alındı.*
   
## 🛠️ Teknoloji Yığını
### Backend
- **ASP.NET Core MVC** (v9.0)
- **C#** (RSA ve SHA-256 algoritmaları için)
- **Entity Framework Core** 

### Frontend
- **HTML5**, **CSS3**, **JavaScript** (Arayüz işlemleri)
- **Bootstrap** (Opsiyonel, responsive tasarım için)

