using Microsoft.AspNetCore.Mvc;
using KriptolojiWeb.Helpers;

namespace KriptolojiWeb.Controllers
{
    public class CryptoController : Controller
    {
        private static RsaHelper _rsa = new RsaHelper();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.PublicKey = _rsa.PublicKeyPem;
            ViewBag.PrivateKey = _rsa.PrivateKeyPem;
            return View();
        }

        [HttpPost]
        public IActionResult GenerateNewKeys()
        {
            _rsa = new RsaHelper();
            ViewBag.PublicKey = _rsa.PublicKeyPem;
            ViewBag.PrivateKey = _rsa.PrivateKeyPem;
            ViewBag.Message = "✅ Yeni anahtarlar başarıyla oluşturuldu.";
            return View("Index");
        }

        [HttpPost]
        public IActionResult Encrypt(string plainText, string publicKey)
        {
            var encrypted = _rsa.Encrypt(plainText, publicKey);

            ViewBag.UserProvidedPublicKey = publicKey;

            ViewBag.PublicKey = _rsa.PublicKeyPem;
            ViewBag.PrivateKey = _rsa.PrivateKeyPem;

            if (encrypted == null)
            {
                ViewBag.Message = "❌ Şifreleme başarısız oldu. Lütfen geçerli bir Public Key ve metin giriniz.";
            }
            else
            {
                ViewBag.Encrypted = encrypted;
                ViewBag.Message = "✅ Şifreleme başarılı.";
            }
            return View("Index");
        }

        [HttpPost]
        public IActionResult Decrypt(string encryptedText, string privateKey)
        {
            var decrypted = _rsa.Decrypt(encryptedText, privateKey);

            ViewBag.PublicKey = _rsa.PublicKeyPem;
            ViewBag.PrivateKey = privateKey;

            if (decrypted == null)
            {
                ViewBag.Message = "❌ Şifre çözme başarısız oldu. Lütfen geçerli bir Private Key ve şifreli metin giriniz.";
            }
            else
            {
                ViewBag.Decrypted = decrypted;
                ViewBag.Message = "✅ Şifre çözme başarılı.";
            }
            return View("Index");
        }

        [HttpPost]
        public IActionResult Hash(string inputText)
        {
            var hash = Sha256Helper.ComputeHash(inputText);
            ViewBag.Hash = hash;
            ViewBag.PublicKey = _rsa.PublicKeyPem;
            ViewBag.PrivateKey = _rsa.PrivateKeyPem;
            ViewBag.Message = "✅ Hash hesaplama başarılı.";
            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> HashFile(IFormFile uploadedFile)
        {
            if (uploadedFile == null || uploadedFile.Length == 0)
            {
                ViewBag.Message = "❌ Geçerli bir dosya seçilmedi.";
                ViewBag.PublicKey = _rsa.PublicKeyPem;
                ViewBag.PrivateKey = _rsa.PrivateKeyPem;
                return View("Index");
            }

            using var memoryStream = new MemoryStream();
            await uploadedFile.CopyToAsync(memoryStream);
            var hash = Sha256Helper.ComputeHash(memoryStream.ToArray());

            ViewBag.Hash = hash;
            ViewBag.FileName = uploadedFile.FileName;
            ViewBag.PublicKey = _rsa.PublicKeyPem;
            ViewBag.PrivateKey = _rsa.PrivateKeyPem;
            ViewBag.Message = "✅ Dosya hash hesaplama başarılı.";

            return View("Index");
        }
    }
}
