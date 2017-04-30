using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace Problem_2___SearchInRange
{
    public class StartUp
    {
        public static void Main()
        {
            var products = new OrderedBag<Product>();
            int countOfProducts = 500000;
            int countOfSearches = 10000;
            int searchedProductsCount = 20;

            for (int i = 0; i < countOfProducts; i++)
            {
                products.Add(new Product($"Product : {i + 1}", ((i + 1) % 50) + (decimal) i / 100));
            }

            //Uncomment to check 10000 price searches 
            //for (int i = 0; i < countOfSearches; i++)
            //{
            //    var searhedProducts = GetProductsInRange(products, i + 1, products.Count - 1, searchedProductsCount);
            //    Console.WriteLine($"First {searchedProductsCount} products with prices from {i + 1} to {products.Count-1}");
            //    Console.WriteLine(string.Join(Environment.NewLine, searhedProducts));
            //    Console.WriteLine();
            //}

            var productsWithPriceFromTenToFifteen = GetProductsInRange(products, 10, 15, searchedProductsCount);
            var productsWithPriceFromFifteenToTwenty = GetProductsInRange(products, 15, 20, searchedProductsCount);
            var productsWithPriceFromTwentyToTwentyFive = GetProductsInRange(products, 20, 25, searchedProductsCount);

            Console.WriteLine($"First {searchedProductsCount} products with prices from 10.00 to 15.00");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPriceFromTenToFifteen));
            Console.WriteLine();

            Console.WriteLine($"First {searchedProductsCount} products with prices from 15.00 to 20.00");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPriceFromFifteenToTwenty));
            Console.WriteLine();

            Console.WriteLine($"First {searchedProductsCount} products with prices from 20.00 to 25.00");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPriceFromTwentyToTwentyFive));
        }

        private static IEnumerable<Product> GetProductsInRange(OrderedBag<Product> products, decimal fromPrice, decimal toPrice, int count)
        {
            var result = products
                .Range(
                products
                .FirstOrDefault(x => x.Price >= fromPrice), 
                true, 
                products
                .LastOrDefault(x => x.Price <= toPrice), 
                true)
                .Take(count);

            return result;
        }
    }
}