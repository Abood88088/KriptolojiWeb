# 🔐 Kripto Araç Kutusu

**RSA Şifreleme, Çözme, Anahtar Yönetimi ve SHA-256 Hash Hesaplama Uygulaması**

🌐 Canlı Uygulama Linki:
📎 http://kriptolojiweb.somee.com/ – Uygulamayı tarayıcınızda deneyin!

![image](https://github.com/user-attachments/assets/109bbd21-9cc1-41c0-8441-a7c81e8d82fc)


## 🌟 Temel Özellikler
| Özellik | Açıklama |
|---------|----------|
| **RSA Şifreleme** | Public key ile metin şifreleme |
| **RSA Çözme** | Private key ile şifre çözme |
| **Anahtar Üretme** | Dinamik RSA anahtar çifti oluşturma |
| **SHA-256 Hash** | Metin ve dosyalar için hash hesaplama |


## 🖼️  Detaylı Ekran Görüntüleri ve Testler

### 1. RSA Şifreleme
![image](https://github.com/user-attachments/assets/31f65da6-c308-43ca-a5cc-11e477579145)   ![image](https://github.com/user-attachments/assets/a3aebf6b-e1bf-4837-b386-5dc1ca651156)

**Test Senaryosu**:  
- **Düz Metin**: `Merhaba Dünya!`  
- **Public Key**: Otomatik oluşturulan anahtar kullanıldı  
- **Sonuç**: `Şifrelenmiş Metin: hkwz9FUa6eOPidaCng...` (Base64 formatında)
- *✅ Doğrulama: Aynı public/private key çiftiyle çözülebilir.*

### 2. RSA Şifre Çözme
![image](https://github.com/user-attachments/assets/c2f536dc-ade2-446b-9da5-bb5d9ee621c4)   ![image](https://github.com/user-attachments/assets/bf25486c-ad6e-460f-8565-6492f309defb)

**Test Senaryosu**:  
- **Şifreli Metin**: Yukarıdaki şifrelenmiş çıktı  
- **Private Key**: Anahtar üretme bölümündeki eşleşen private key  
- **Sonuç**: `Çözülmüş Metin: Merhaba Dünya!`
- *✅ Doğrulama: Orijinal metinle eşleşiyor.*

### 3. Anahtar Yönetimi
![image](https://github.com/user-attachments/assets/2840b45c-a139-478c-8459-209e8ec01841)   ![image](https://github.com/user-attachments/assets/e03ba2d6-d81b-4ad4-8c61-d3bf13400687)

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
![image](https://github.com/user-attachments/assets/2c879ce2-84e4-4a1f-8ba9-0ce0833d0da2)   ![image](https://github.com/user-attachments/assets/106c207c-b3f7-4e63-845c-e80370be3309)

**A) Metin Hashleme**
- **Girdi**: kriptoloji123
- **Hash Sonucu**: a32f69...11f22 (64 karakter hex)
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

