using System;
using System.Security.Cryptography;
using System.Text;
namespace Diplom
{
    static public class Cryptographer
    {
        static public string Coding(string password)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                string pass = password;
                byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
                return BitConverter.ToString(checkSum).Replace("-", String.Empty);
            }
        }
    }
}
