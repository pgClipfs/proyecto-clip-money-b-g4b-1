using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConexionDB.Helpers
{
    public class Security
    {
        public static string Key = "M4r1@@g1N4@";
        public static string Encrypt(string password)
        {
            if (string.IsNullOrEmpty(password)) return "";

            //encrypt data
            password += Key;
            var passwordBytes = Encoding.UTF8.GetBytes(password);

            //return as base64 string
            return Convert.ToBase64String(passwordBytes);
        }

        public static string Decrypt(string baseEncodeData)
        {
            if (string.IsNullOrEmpty(baseEncodeData)) return "";

            //parse base64 string
            var encodeBytes = Convert.FromBase64String(baseEncodeData);

            //decrypt data
            var result = Encoding.UTF8.GetString(encodeBytes);
            result = result.Substring(0,result.Length-Key.Length);
            return result;
        }
    }
}
