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
        public string Encypt(string input)
        {
            using (SHA256 sHA256=SHA256.Create())
            {
                string hash = Gethash(sHA256, input);
                return hash.ToString();
            }
            
        }
        private string Gethash(HashAlgorithm hashAlgorithm,string input)
        {
            byte[] inputbytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = hashAlgorithm.ComputeHash(inputbytes);
            var sbuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sbuilder.Append(hash[i].ToString("x2"));
            }
            return sbuilder.ToString();
        }
    }
}
