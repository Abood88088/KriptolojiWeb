using System.Text;
using System.Security.Cryptography;

namespace KriptolojiWeb.Helpers
{
    public class Sha256Helper
    {
        public static string ComputeHash(string input)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(input);
            var hashBytes = sha256.ComputeHash(bytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }

        public static string ComputeHash(byte[] data)
        {
            using var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(data);
            return Convert.ToHexString(hash);
        }
    }

}
