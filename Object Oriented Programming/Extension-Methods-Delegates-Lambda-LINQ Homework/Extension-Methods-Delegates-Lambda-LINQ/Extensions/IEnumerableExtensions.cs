//Problem 2. IEnumerable extensions
//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//- sum, 
//- product, 
//- min,
//- max,
//- average.


namespace Extension_Methods_Delegates_Lambda_LINQ.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        //extension methods with constrains for numeral types and any other types that implement these interfaces;

        public static decimal Sum<T>(this IEnumerable<T> collection) where T : struct, IComparable, IConvertible
        {
            var sum = collection.Select(x => Convert.ToDecimal(x)).Sum();

            return sum;
        }


        public static decimal Product<T>(this IEnumerable<T> collection) where T : struct, IComparable, IConvertible
        {
            var convertedCollection = collection.Select(x => Convert.ToDecimal(x));

            decimal product = 1;
            foreach (decimal element in convertedCollection)
            {
                product *= element;
            }

            return product;
        }


        public static decimal Min<T>(this IEnumerable<T> collection) where T : struct, IComparable, IConvertible
        {
            var minElement = collection.Select(x => Convert.ToDecimal(x)).Min();

            return minElement;
        }


        public static decimal Max<T>(this IEnumerable<T> collection) where T : struct, IComparable, IConvertible
        {
            var maxElement = collection.Select(X => Convert.ToDecimal(X)).Max();

            return maxElement;
        }


        public static decimal Average<T>(this IEnumerable<T> collection) where T : struct, IComparable, IConvertible
        {
            var average = collection.Select(x => Convert.ToDecimal(x)).Average();

            return average;
        }
    }
}
