using ValidationDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidationDemo.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemo.Tests
{
    [TestClass()]
    public class DogTests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            // Arrange
            var dog = new Dog();
            dog.SetName("Fido");
            // Act
            var dogsName = dog.GetName();
            // Assert
            Assert.IsNotNull(dogsName);
        }
    }
}

namespace ValidationDemo.Program.Tests
{
    [TestClass()]
    public class DogTests
    {
        [TestMethod()]
        public void Dog_SetNameTest()
        {
            // Arrange
            var dog = new Dog();
            string dogName = "Lassie";
            // Act
            dog.SetName(dogName);
            // Assert
            Assert.AreEqual(dogName, dog.Name.ToString());
        }
    }
}