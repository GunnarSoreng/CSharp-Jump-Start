using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //
            // Use Entity Framework to interact with a local database
            //
            //

            //
            // First creat a new empty local database of type 'Service-based database', by right clicking project and choosing 'Add new item'
            // Fill it with some data
            // Then add a datamodel of type 'ADO.NET Entity Data Model' to project
            //

            // Use the context from the datamodel to access the database.
            var context = new Database1Entities();

            var products = context.Products;

            foreach (var product in products
                .Where(x => x.Name.Contains("o")))
            {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine();

            // Uses T-SQL behind the scenes to interact with database


            //var prod = products.First();
            // Use lambda expression (predicate returns true or false) to filter data further
            var prod = products.First(x => x.Name.Contains("Lion"));
            Console.WriteLine(prod.Name);
            Console.WriteLine();

            // Change entry in database, and update/commit
            prod.Name = "Faux Lion Fur Hat";
            context.SaveChanges();

            products = context.Products;
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine();

            // Delete record from table
            context.Products.Remove(prod);
            context.SaveChanges();


            products = context.Products;
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
