using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var hund = new Dog();
            hund.Name = "Fido";
            hund.Temp = 38;
            var hund2 = new Poodle();
            hund2.Name = "Fluffy";
            hund2.Temp = 39;
            hund2.Groomer = "Mr Cutty";
            Console.WriteLine("Name: {0:12}  sound: {1}", hund.Name, hund.sound());
            Console.WriteLine("Name: {0:12}  sound: {1}", hund2.Name, hund2.sound());

            var dyr = new Animal();
            dyr.Temp = 37;


            // Run code inside the class y
            var init = new y();
            init.x();

            
            
            //Console.ReadLine();

        
        }


    }
    public class y
    {
        public void x()
        {
            var animal = new Animal();
            var dog = new Dog();
            var poodle = new Poodle();

            TakeAnimal(poodle);

        }
        public void TakeAnimal(Animal a)
        {
            Console.WriteLine("Start of TakeAnimal");
            //Console.ReadLine();
            a.Temp = 10;

            /*
            // Cast 'a' til Dog og få tilgang på name:
            //var dog = (Dog)a;
            // bedre metode for casting:
            var dog = a as Dog;
            // Hvis input objektet er animal kan den ikke castes og vil gi 'null'
            // Poodle kan castes til dog, fordi den er derived av dog.
            if (dog != null)
                dog.Name = "Daren";
            */


            // Best å sjekke på objektets type før du gjør noen casting:
            // 'is' gjør ingen casting, kun en sjekk, returnerer true/false:
            if (a is Dog)
            {
                var dog = a as Dog;
                if (dog != null)
                    dog.Name = "Daren";

            }
        }


    }
    public class Animal {
        public int Temp { get; set; }
    }
    public class Dog : Animal
    {
        public string Name { get; set; }
        public string sound()
        {
            return "Voof!";

        }

    }
    public class Poodle : Dog
    {
        public bool approvedPoodle { get; set; }
        public string Groomer { get; set; }
        public new string sound()
        {
            return "Roff!";
        }

    }



}





