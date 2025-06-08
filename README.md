# 🔐 Kripto Araç Kutusu

**RSA Şifreleme, Çözme, Anahtar Yönetimi ve SHA-256 Hash Hesaplama Uygulaması**

![image](https://github.com/user-attachments/assets/4f305235-0e34-4616-a6dd-ade44d8703dd)


## 🌟 Temel Özellikler
| Özellik | Açıklama |
|---------|----------|
| **RSA Şifreleme** | Public key ile metin şifreleme |
| **RSA Çözme** | Private key ile şifre çözme |
| **Anahtar Üretme** | Dinamik RSA anahtar çifti oluşturma |
| **SHA-256 Hash** | Metin ve dosyalar için hash hesaplama |


## 🖼️  Detaylı Ekran Görüntüleri ve Testler

### 1. RSA Şifreleme
![image](https://github.com/user-attachments/assets/16e125d2-89fa-463e-95d3-764fcd810184)   ![image](https://github.com/user-attachments/assets/854d97ae-3574-4206-842a-f329504b4558)

**Test Senaryosu**:  
- **Düz Metin**: `Merhaba Dünya!`  
- **Public Key**: Otomatik oluşturulan anahtar kullanıldı  
- **Sonuç**: `Şifrelenmiş Metin: hkwz9FUa6eOPidaCng...` (Base64 formatında)
- *✅ Doğrulama: Aynı public/private key çiftiyle çözülebilir.*

### 2. RSA Şifre Çözme
![image](https://github.com/user-attachments/assets/b68b3a16-ce6b-4f74-84af-c45935955337)   ![image](https://github.com/user-attachments/assets/e6b8e959-5f45-4a2e-ae7b-be218b8256e5)

**Test Senaryosu**:  
- **Şifreli Metin**: Yukarıdaki şifrelenmiş çıktı  
- **Private Key**: Anahtar üretme bölümündeki eşleşen private key  
- **Sonuç**: `Çözülmüş Metin: Merhaba Dünya!`
- *✅ Doğrulama: Orijinal metinle eşleşiyor.*

### 3. Anahtar Yönetimi
![image](https://github.com/user-attachments/assets/9d7404b4-a6c6-41fb-8be5-2a4b4467d54c)   ![image](https://github.com/user-attachments/assets/21e35c3a-0cc6-48b2-bafd-a5868c745cc1)

**Test Senaryosu**:  
- **Buton**: "Yeni Anahtar Oluştur"  
- **Üretilen Çıktı**:  
  ```text
  -----BEGIN PUBLIC KEY-----
  MIIBIjANBgkqhkiG9w0BAQEF...
  -----END PUBLIC KEY-----
  
  -----BEGIN PRIVATE KEY-----
  MIIEvAIBADANBgkqhkiG...
  -----END PRIVATE KEY-----
- *✅ Doğrulama: Üretilen anahtarlar RSA şifreleme/çözmede çalışıyor.*

### 4. SHA-256 Hash
**Test Senaryosu**:  
![image](https://github.com/user-attachments/assets/24cc9efe-721c-48db-88ef-2680813f05c4)   ![image](https://github.com/user-attachments/assets/42790f5c-3def-429b-851d-4bdcc9ad0854)

**A) Metin Hashleme**
- **Girdi**: kriptoloji123
- **Hash Sonucu**: a32f69...11f22 (64 karakter hex)
- *✅ Doğrulama: Online SHA-256 tool ile aynı sonuç alındı.*

![image](https://github.com/user-attachments/assets/587fe1ab-f257-40f1-b24d-c8d176ce2fab)   ![image](https://github.com/user-attachments/assets/e3709322-cac5-4cc8-9cab-bfae84e6f68d)

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

