using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection Demo:{0}=================={0}",Environment.NewLine);

            var dog = new Dog { NumberOfLegs = 4 };

            //
            // How to get Type data?
            //

            // At compile time
            // Gets type from the definition itself
            Type t1 = typeof(Dog);
            Console.WriteLine(t1.Name);

            // At runtime
            // Gets type from the instance itself
            Type t2 = dog.GetType();

            // output: Dog
            Console.WriteLine(t2.Name);

            // output: ReflectionDemo, Version=1.0.0.0
            //         Culture=neutral, PublicKeyToken=null
            Console.WriteLine(t2.Assembly);

            Console.ReadLine();

            //
            // How can I create an instance of a Type?
            //

            // Two ways:

            // 1: Activator CreateInstance
            // Here you get an object that you need to cast to correct type: (Dog) (old way of doing it)
            var newDog = (Dog)Activator.CreateInstance(typeof(Dog));

            // Better way, using generics:
            var genericDog = Activator.CreateInstance<Dog>();

            // 2: Use default constructor, no parameters

            var dogConstructor = typeof(Dog).GetConstructors()[0];
            // This should be an empty array, not 'null', because default constructor may require different number of parameters that is unknown at this time:
            var advancedDog = (Dog)dogConstructor.Invoke(null);

            var advancedType = advancedDog.GetType();
            Console.WriteLine("advancedDog type: {0}",advancedType.Name);


            Console.ReadLine();

            //
            // Accessing a Property
            //

            var horse = new Animal() { Name = "Ed" };
            var type = horse.GetType();
            var property = type.GetProperty("Name");
            var value = property.GetValue(horse, null);

            Console.WriteLine("Property 'Name' of object horse: {0}",value);

            Console.ReadLine();

            //
            // Invoking a method of an object
            //

            var horse2 = new Animal();
            var typehorse2 = horse2.GetType();
            var method = type.GetMethod("Speak");

            // Here 'horse' is the instance of the Animal type we want to run the method 'Speak' on
            // The return value is CAST to type string
            var value2 = (string)method.Invoke(horse, null);
            // value == "Hello"

            Console.WriteLine("Horse 2 - result of method 'Speak': {0}",value2);

            Console.ReadLine();


        }
        class Animal
        {
            public string Name { get; set; }
            public string Speak() {
                return "Hello";
            }
        }
    }
}
