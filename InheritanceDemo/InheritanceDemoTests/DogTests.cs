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
    public class DogTests
    {
        [TestMethod()]
        public void testDogSound()
        {
            var dog = new Dog();
            string expectedResponse = "Voof!";

            var response = dog.sound();

            Assert.IsInstanceOfType(response, typeof(string));
            Assert.AreEqual(expectedResponse, response);

        }
    }
}