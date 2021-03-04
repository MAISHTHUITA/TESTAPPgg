using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SHOPLITE.Models
{
    public class EncryptKey
    {
        private string hash = "@thuitas";
        public string Encypt(string input)
        {
            
            byte[] data = UTF8Encoding.UTF8.GetBytes(input);
            using (MD5CryptoServiceProvider sha=new MD5CryptoServiceProvider())
            {
                byte[] keys = sha.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                
                using (TripleDESCryptoServiceProvider trip=new TripleDESCryptoServiceProvider() { Key=keys,Mode=CipherMode.ECB,Padding=PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = trip.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                 return Convert.ToBase64String(result, 0, result.Length);
                }
            }
            
            
        }
        public string Decryptor(string encrypted )
        {


            byte[] data = Convert.FromBase64String(encrypted);
                using (MD5CryptoServiceProvider sha = new MD5CryptoServiceProvider())
                {
                    byte[] keys = sha.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = trip.CreateDecryptor();
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return  UTF8Encoding.UTF8.GetString(result);
                     
                    }
                }


            
        }
        
    }
}
