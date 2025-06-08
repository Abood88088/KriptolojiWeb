using System.Text;
using System.Security.Cryptography;

namespace KriptolojiWeb.Helpers
{
    public class RsaHelper
    {
        private RSA _rsa;

        public string PublicKeyPem { get; private set; }
        public string PrivateKeyPem { get; private set; }

        public RsaHelper()
        {
            _rsa = RSA.Create(2048);
            PublicKeyPem = ExportPublicKeyPem(_rsa);
            PrivateKeyPem = ExportPrivateKeyPem(_rsa);
        }

        public string Encrypt(string plainText, string publicKeyPem)
        {
            try
            {
                using var rsa = RSA.Create();
                rsa.ImportFromPem(publicKeyPem.ToCharArray());
                var data = Encoding.UTF8.GetBytes(plainText);
                var encrypted = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
                return Convert.ToBase64String(encrypted);
            }
            catch
            {
                return null;
            }
        }

        public string Decrypt(string encryptedText, string privateKeyPem)
        {
            try
            {
                using var rsa = RSA.Create();
                rsa.ImportFromPem(privateKeyPem.ToCharArray());
                var bytes = Convert.FromBase64String(encryptedText);
                var decrypted = rsa.Decrypt(bytes, RSAEncryptionPadding.Pkcs1);
                return Encoding.UTF8.GetString(decrypted);
            }
            catch
            {
                return null;
            }
        }

        private string ExportPublicKeyPem(RSA rsa)
        {
            var pubBytes = rsa.ExportSubjectPublicKeyInfo();
            var base64 = Convert.ToBase64String(pubBytes);
            return FormatPem(base64, "PUBLIC KEY");
        }

        private string ExportPrivateKeyPem(RSA rsa)
        {
            var privBytes = rsa.ExportPkcs8PrivateKey();
            var base64 = Convert.ToBase64String(privBytes);
            return FormatPem(base64, "PRIVATE KEY");
        }

        private string FormatPem(string base64, string type)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-----BEGIN {type}-----");
            for (int i = 0; i < base64.Length; i += 64)
            {
                sb.AppendLine(base64.Substring(i, Math.Min(64, base64.Length - i)));
            }
            sb.AppendLine($"-----END {type}-----");
            return sb.ToString();
        }
    }

}
