namespace Cosmetics.Common
{
    using System;

    /// <summary>
    /// Validator class uniting the validations of properties.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Checks if the provided parameters are not null. Throws and exception if the parameter is null. 
        /// </summary>
        /// <param name="obj">The object to be checked</param>
        /// <param name="message">Error message</param>
        /// <exception cref="NullReferenceException">Throws if a parameter is null</exception>
        public static void CheckIfNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }
        
        /// <summary>
        /// Checks if a parameter of type string s null or empty. 
        /// </summary>
        /// <param name="text">The parameter of type string to be checked</param>
        /// <param name="message">Error message</param>
        /// <exception cref="NullReferenceException">Throws an exception if a parameter of type string is null or empty.</exception>
        public static void CheckIfStringIsNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        /// <summary>
        /// Checks if the length of a parameter of type string is valid.
        /// </summary>
        /// <param name="text">The parameter to be checked</param>
        /// <param name="max">Maximal length</param>
        /// <param name="min">Minimal lenght</param>
        /// <param name="message">Error message</param>
        /// <exception cref="IndexOutOfRangeException">Throws an exception if the length is not valid.</exception>
        public static void CheckIfStringLengthIsValid(string text, int max, int min = 0, string message = null)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new IndexOutOfRangeException(message);
            }
        }
    }
}
