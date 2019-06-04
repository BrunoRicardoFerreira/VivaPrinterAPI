using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Epta.API.Helpers
{
    public class Criptografia
    {
        private const string chave = "viva@Printer$2019#Api";

        public static String Encrypt(String toEncrypt, bool useHashing, string chaveOpcional = null)
        {
            var chaveUsada = chaveOpcional ?? chave;

            byte[] keyArray;
            var toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);

            if (string.IsNullOrEmpty(toEncrypt)) return string.Empty;

            if (useHashing)
            {
                using (var hashmd5 = new MD5CryptoServiceProvider())
                {
                    keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(chaveUsada));
                    hashmd5.Clear();
                }
            }
            else
                keyArray = Encoding.UTF8.GetBytes(chaveUsada);

            using (var tdes = new TripleDESCryptoServiceProvider())
            {
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                var cTransform = tdes.CreateEncryptor();
                var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                tdes.Clear();
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
        }


        public static String Decrypt(String cipherString, bool useHashing, string chaveOpcional = null)
        {
            var chaveUsada = chaveOpcional ?? chave;

            if (cipherString != null)
            {
                cipherString = cipherString.Replace(" ", "+");

                byte[] keyArray;
                var toEncryptArray = Convert.FromBase64String(cipherString);

                if (useHashing)
                {
                    using (var hashmd5 = new MD5CryptoServiceProvider())
                    {
                        keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(chaveUsada));
                        hashmd5.Clear();
                    }
                }
                else

                    keyArray = Encoding.UTF8.GetBytes(chaveUsada);

                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = keyArray;
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    var cTransform = tdes.CreateDecryptor();
                    var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                    tdes.Clear();
                    return Encoding.UTF8.GetString(resultArray);
                }
            }
            return null;
        }
    }
}
