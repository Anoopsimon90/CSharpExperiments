using System;
using System.Collections.Generic;
using System.Globalization;
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
            try
            {
                return new string(str.Where(char.IsLetter).ToArray()).Trim();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Extract only numbers from a String
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

        /// <summary>
        /// To convert a String to double
        /// </summary>
        /// <param name="str"></param>
        /// <param name="throwExceptionIfFailed"></param>
        /// <returns></returns>
        public static double ToDouble(this string str, bool throwExceptionIfFailed = false)
        {
            double result;
            var valid = double.TryParse(str, NumberStyles.AllowDecimalPoint,
              new NumberFormatInfo { NumberDecimalSeparator = "." }, out result);
            if (!valid)
                if (throwExceptionIfFailed)
                    throw new FormatException(string.Format("'{0}' Can't be convered to Double", str));

            return result;
        }

        /// <summary>
        /// To convert a String to Date
        /// </summary>
        /// <param name="input"></param>
        /// <param name="throwExceptionIfFailed"></param>
        /// <returns></returns>
        public static DateTime ToDate(this string input, bool throwExceptionIfFailed = false)
        {
            DateTime result;
            var valid = DateTime.TryParse(input, out result);
            if (!valid)
                if (throwExceptionIfFailed)
                    throw new FormatException(string.Format("'{0}' cannot be converted as DateTime", input));
            return result;
        }
    }
}
