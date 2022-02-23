using CalorieCalculate.Model.Data;
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
        public static bool TestForNullOrEmpty(List<string> text)
        {
            bool result = text.Any(x => x == "" || x == null);
            return result;
        }
        public static bool IsStokEmail(this string email)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var result = db.Users.Any(x => x.Email.Equals(email));
                return result;
            }
        }

        public static bool IsValidPassword(string plainText)
        {
            var input = plainText;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isValidated = hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMinimum8Chars.IsMatch(input);
            return isValidated; 

        }

    }
}
