using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extensions
{
    public static class StringExtensions
    {
        public static string ConvertToMD5(this string passWord)
        {
            if (string.IsNullOrEmpty(passWord))
            {
                return String.Empty;
            }
            var word = (passWord += "|2d331cca-f6c0-40c0-bb43-6e32989c2881");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(word));
            var sb = new StringBuilder();
            foreach(var item in data)
            {
                sb.Append(item.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
