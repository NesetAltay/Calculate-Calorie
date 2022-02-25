using CalorieCalculate.Crud;
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
        private static DatabaseContext _db = BaseContext.GetInstance();
        /// <summary>
        /// Kayıt oluşturan kullanıcının email adresinin geçerli olmasını kontrol eder
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(this string email)
        {
            string pattern = @"[\w+-]+(?:.[\w+-]+)@[\w+-]+(?:.[\w+-]+)(?:.[a-zA-Z]{2,4})";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
        /// <summary>
        /// Kayıt oluşturan kullanıcının oluşturduğu şifrenin gerekli koşulları sağlamasını kontrol eder
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static bool IsValidPassword(string plainText)
        {
            var input = plainText;
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isValidated = hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMinimum8Chars.IsMatch(input);
            return isValidated; 
        }

        #region Database Boolean sorgu yapıları

        /// <summary>
        /// Kayıt oluştururken textboxların boş olmasını kontrol eder
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool TestForNullOrEmpty(List<string> text)
        {
            bool result = text.Any(x => x == "" || x == null);
            return result;
        }
        /// <summary>
        /// Oturum açan kullanıcının şifresinin doğru olup olmadığını kontrol eder
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEquelsEmail(this string email)
        {
            var result = _db.Users.Any(x => x.Email.Equals(email));
            return result;
        }
        /// <summary>
        /// Oturum açan kullanıcının databasede kayıtlı olup olmadığını kontrol eder
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool AnyUser(string email, string password)
        {
            bool validUser = _db.Users.Any(x => x.Email == email && x.Password == password);
            return validUser;
        } 

        #endregion
    }
}
