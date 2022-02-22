using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalorieCalculate.Extensions
{
   public static class StringExtension
    {
        public static bool IsValidEmail(this string email)
        {
            string pattern = @"[\w+-]+(?:.[\w+-]+)@[\w+-]+(?:.[\w+-]+)(?:.[a-zA-Z]{2,4})";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
