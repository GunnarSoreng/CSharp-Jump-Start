using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Tests
{
    [TestClass()]
    public class yTests
    {
        [TestMethod()]
        public void TakeAnimalTest()
        {
            var dog = new Dog();
            var y = new y();
            y.TakeAnimal(dog);
            string expectedResult = "Daren";
            var result = dog.Name.ToString();

            Assert.AreEqual(expectedResult, result);
        }

    }
}