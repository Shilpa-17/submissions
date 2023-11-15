using System;

using System.Collections.Generic;
using static System.Console;

class Product

{
    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public double Price { get; set; }

}



class Program

{
    static void Main()

    {

        List<Product> products = new List<Product>();

        for (int i = 1; i <= 10; i++)

        {

            WriteLine($"Enter details for Product {i}:");

            Write("Product ID: ");

            int productId = int.Parse(ReadLine());

            Write("Product Name: ");

            string productName = ReadLine();

            Write("Price: ");

            double price = double.Parse(ReadLine());



            Product product = new Product

            {

                ProductId = productId,

                ProductName = productName,

                Price = price

            };



            products.Add(product);

        }
        products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));


        WriteLine("Sorted Products by Price:");

        foreach (Product product in products)

        {

            WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");

        }

    }

}
