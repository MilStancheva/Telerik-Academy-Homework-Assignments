using System;
using System.Text;

namespace Problem_2___TradeCompany
{
    public class Product : IComparable<Product>
    {
        public Product(string barcode, string vendor, string title, decimal price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public string Barcode { get; set; }

        public string Vendor { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Product: ");
            builder.AppendLine($"Barcode: {this.Barcode}; ");
            builder.AppendLine($"Vendor: {this.Vendor}; ");
            builder.AppendLine($"Title: {this.Title}; ");
            builder.AppendLine($"Price: {this.Price}; ");


            return builder.ToString();
        }
    }
}