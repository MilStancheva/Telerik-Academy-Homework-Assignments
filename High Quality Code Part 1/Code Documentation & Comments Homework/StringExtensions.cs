namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// String extensions class includes methods for string conversion and validation. 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// ToMd5Hash receives an input string value, converts it to a byte array and returns a string - each byte as a hexadecimal string.
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>String value - bytes in hexadecimal representation.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var builder = new StringBuilder();

            // format each byte as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// ToBoolean method receives an input string value and checks whether it is a positive boolean value.
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>A boolean value</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };

            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// ToShort receives an input string value and checks whether it is of type short. 
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>The input converted to type short</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);

            return shortValue;
        }

        /// <summary>
        /// ToInteger receives an input string value and checks if it can be converted to type integer. 
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>The input converted to integer type</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);

            return integerValue;
        }

        /// <summary>
        /// ToLong receives an input string value and checks if it can be converted to type long.
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>The input converted to long type</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);

            return longValue;
        }

        /// <summary>
        /// ToDateTime receives an input string value and checks if it can be converted to type DateTime.
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>The input converted to DateTime type</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);

            return dateTimeValue;
        }

        /// <summary>
        /// CapitalizeFirstLetter receives an input string value and converts the first letter to Upper Case.
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>The input string with a capital first letter</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// GetStringBetween receives an input string value and returns a substring between two other strings. 
        /// </summary>
        /// <param name="input">string value</param>
        /// <param name="startString">string value - the start string</param>
        /// <param name="endString">string value - the end string</param>
        /// <param name="startFrom">string value - the start index</param>
        /// <returns>A substring between the start and the end strings</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// ConvertCyrillicToLatinLetters receives an input and converts its Cyrillic letters with Latin ones.
        /// </summary>
        /// <param name="input">input string with Cyrillic letters</param>
        /// <returns>The input string converted to Latin letters</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// ConvertLatinToCyrillicKeyboard receives an input string value and returns its Latin letters to Cyrillic ones.
        /// </summary>
        /// <param name="input">string value with Latin letters</param>
        /// <returns>The input string converted to Cyrillic letters</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// ToValidUsername receives an input and checks whether it matches the requirements. It should have only Latin letters. Replaces the symbols that don't match with empty string.
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>The validated input string</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();

            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// ToValidLatinFileName receives an input string value and checks whether it is a valid file name. It replaces Cyrillic to Latin letters and a white space with a hyphen. 
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>The validated input string.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();

            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// GetFirstCharacters receives a string value and a count of the first chars of the input to be returned. 
        /// </summary>
        /// <param name="input">string value - input</param>
        /// <param name="charsCount">integer value - charsCount</param>
        /// <returns>The substring of the first chars with length - charsCount</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// GetFileExtension receives a file name as a string and returns the file extension as string.
        /// </summary>
        /// <param name="fileName">string value - the name of the file name</param>
        /// <returns>The file name extension as string.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// ToContentType receives a file extension as a string and returns the content type of the file as a string value.
        /// </summary>
        /// <param name="fileExtension">string value - the name of the file extension</param>
        /// <returns>The content type of the file as a string.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// ToByteArray receives an input string value and returns it represented as an array of bytes. 
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>The input as an array of bytes</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);

            return bytesArray;
        }
    }
}
