using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cat = new Cat();
            cat.SetName("Fluffy");
            Console.WriteLine("Cats name: {0}",cat.Name);
            Console.WriteLine("Ready for new name.");
            Console.ReadLine();
            //string newName = "Queen FLuffy XII";
            //string newName = " ";
            //string newName = "Fluffy";

            string newName = "Tom";

            try
            {
                cat.SetName(newName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to change name. Input: '{0}' Errormessage: {1}",newName, e.Message);
                Console.ReadLine();
            }

            Console.WriteLine("Name updated successfully.");
            Console.WriteLine("Cats name: {0}", cat.Name);
            Console.ReadLine();
            

            Animal cat1 = new Cat();
            Animal dog = new Dog();

            // Check if object cat is of type Dog.
            if (cat1 is Dog)
                throw new NotSupportedException("Dogs only!");

            //Checks if two objects are the same, not if they are the same type
            if (cat1 == dog)
                throw new Exception("Not the same");

            // Checks if they have the same value
            if (cat1.Equals(dog))
                throw new Exception("Not equal");


        }


    }
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public abstract void SetName(string value);
    }

    public class Cat : Animal
    {
        public override void SetName(string value)
        {
            // validate empty
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("value");

            // validate conflict
            if (value == Name)
                throw new ArgumentException("value is duplicate");


            // validate size
            if (value.Length > 10)
                throw new ArgumentException("value is too long");

            // Adding this defines all lines above as a contract:
            //Contract.EndContractBlock();

            this.Name = value;
        }
    }

    public class Dog : Animal
    {
        public new string Name { get; protected set; }
        public override void SetName(string value)
        {
            //// validate input. 
            // Requires: Preprocessing of method
            // Means Not null or white space allowed.
            // You can have multiple (different) checks
            Contract.Requires(!string.IsNullOrWhiteSpace(value), "value is empty");
            Name = value;
        }

        public string GetName()
        {
            // validate output
            // Ensure : post processing of method
            // You can't return empty string
            Contract.Ensures(!string.IsNullOrWhiteSpace(Contract.Result<string>()));
            return this.Name;
        }
    }

}

