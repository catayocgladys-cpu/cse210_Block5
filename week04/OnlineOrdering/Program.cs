//This is to create two customers, six products, and two orders. We'll use one customer living in the USA and another living in the Philippines to demonstrate both shipping costs.
//Gladys Catayoc

using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the first customer in the USA
            Address address1 = new("123 Main Street", "Dallas", "Texas", "USA");

            Customer customer1 = new("Maeve Curtins", address1);

            //Create products for the first order
            Product product1 = new("Wireless Mouse", "M101", 15.00, 2);

            Product product2 = new("Keyboard", "K202", 25.00, 1);

            Product product3 = new("USB Cable", "U303", 5.00, 3);

            //Create the first order
            Order order1 = new(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);

            //Create the second customer in the Philippines
            Address address2 = new("Chismosa Street", "Duguan City", "Libak Oriental", "Philippines");

            Customer customer2 = new("Maritess Ug Baba", address2);

            //Create products for the second order
            Product product4 = new("Lisptick", "L404", 3.00, 5);

            Product product5 = new("Blush On", "B505", 1.50, 4);

            Product product6 = new("SkinToner", "ST606", 30.00, 1);

            //Create the second order
            Order order2 = new(customer2);
            order2.AddProduct(product4);
            order2.AddProduct(product5);
            order2.AddProduct(product6);

            //Display the first order
            Console.WriteLine("==== ORDER 1 ====");
            Console.WriteLine(order1.GetPackingLabel(new System.Text.StringBuilder()));
            Console.WriteLine();
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("\nTotal Price: $" + order1.GetTotalCost().ToString("F2"));

            //Display the second order
            Console.WriteLine("\n==== Order 2 ====");
            Console.WriteLine(order2.GetPackingLabel(new System.Text.StringBuilder()));
            Console.WriteLine();
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("\nTotal Price: $" + order2.GetTotalCost().ToString("F2"));

        }
    }

}
