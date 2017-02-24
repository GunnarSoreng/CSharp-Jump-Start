using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceDemo;

namespace InheritanceDemo.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void TakeAnimalTest(Animal a)
        {
            // Send in object of type Dog and see if name gets set.

            var dog = new Dog();
            var testy = new y();

            testy.TakeAnimal(dog);

            string expectedDogsName = "Daren";
            var dogsName=dog.Name;

            Assert.AreEqual(expectedDogsName, dogsName);
           // Assert.IsFalse(true);           
        }
    }
}


