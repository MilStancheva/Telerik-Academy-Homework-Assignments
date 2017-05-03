using System;
using System.Collections.Generic;

using Wintellect.PowerCollections;

namespace Problem_2___TradeCompany
{
    public class Program
    {
        public static void Main()
        {
            var products = new OrderedMultiDictionary<decimal, Product>(true);
            var countOfProducts = 1000000;

            for (int i = 0; i < countOfProducts; i++)
            {
                var product = new Product(i.ToString(), i.ToString(), i.ToString(), (((i + 1) % 50) + (decimal) i / 100));
                products.Add(product.Price, product);
            }

            var productsWithPriceFromTenToFifteen = GetProductsInPriceRange(products, 10, 15);
            var productsWithPriceFromFifteenToTwenty = GetProductsInPriceRange(products, 15, 20);
            var productsWithPriceFromTwentyToTwentyFive = GetProductsInPriceRange(products, 20, 25);

            Console.WriteLine($"Products with prices from 10.00 to 15.00");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPriceFromTenToFifteen));
            Console.WriteLine();

            Console.WriteLine($"Products with prices from 15.00 to 20.00");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPriceFromFifteenToTwenty));
            Console.WriteLine();

            Console.WriteLine($"Products with prices from 20.00 to 25.00");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPriceFromTwentyToTwentyFive));
        }

        private static IEnumerable<Product> GetProductsInPriceRange(OrderedMultiDictionary<decimal, Product> products, decimal fromPrice, decimal toPrice)
        {
            var result = products.Range(fromPrice, true, toPrice, true).Values;

            return result;
        }
    }
}