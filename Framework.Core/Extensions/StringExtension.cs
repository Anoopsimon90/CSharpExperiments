using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Framework.Core
{
    /// <summary>
    /// A bunch of string extension methods
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Extract only Letters from a String
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ExtractLetters(this string str)
        {
            return Regex.Replace(str, @"[^A-Z]+", string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int ExtractNumbers(this string str)
        {
            try
            {
                return Convert.ToInt32(new string(str.Where(char.IsDigit).ToArray()).Trim());
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
