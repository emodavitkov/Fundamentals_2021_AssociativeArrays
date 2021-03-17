using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that keeps information about products and their prices.Each product has a name, a price and a quantity.
            //If the product doesn’t exist yet, add it with its starting quantity.
            //If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different, 
            //replace the price as well.
            //You will receive products’ names, prices and quantities on new lines.Until you receive the command "buy", keep adding items.
            //When you do receive the command "buy", print the items with their names and total price of all the products with that name. 
           
            //can work with new Dictionary<string, List<double>();
            
            Dictionary<string, double> productCatalogByPrice = new Dictionary<string, double>();
            Dictionary<string, double> productCatalogByQuantity = new Dictionary<string, double>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="buy")
                {
                    break;
                }

                string[] product = input
                    .Split();

                string item = product[0];
                double price = double.Parse(product[1]);
                double quantity = double.Parse(product[2]);

                if (productCatalogByPrice.ContainsKey(product[0]))
                {
                    productCatalogByPrice[product[0]]=price;
                    productCatalogByQuantity[product[0]] += quantity;
                }
                else
                {
                    productCatalogByPrice.Add(item, price);
                    productCatalogByQuantity.Add(item, quantity);
                }

                //if (productCatalogByQuantity.ContainsKey(product[0]))
                //{
                //    productCatalogByQuantity[product[0]] += quantity;
                //}
                //else
                //{
                //    productCatalogByQuantity.Add(item, quantity);
                //}
            }

            foreach (var item in productCatalogByPrice)
            {
                string productOutput = item.Key;
                double priceOutput = item.Value;
                double quantityOutput = productCatalogByQuantity[productOutput];

                double totalPrice = quantityOutput * priceOutput;

                Console.WriteLine($"{productOutput} -> {totalPrice:f2}");
            }



        }
    }
}
