using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidationDemo.Program;
using ValidationDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ValidationDemo.Tests
namespace ValidationDemo.Program.Tests

{
    [TestClass()]
    public class CatTests
    {
        [TestMethod()]
        public void Cat_SetNameTest_IsNOtNull()
        {
            // Arrange
            var cat = new Cat();
            string catName = "Fluffy";
            // Act
            cat.SetName(catName);
            // Assert
            Assert.IsNotNull(cat.Name);
        }

        [TestMethod()]
        public void Cat_SetNameTest_Has_Correct_Value()
        {
            // Arrange
            var cat = new Cat();
            string catName = "Fluffy";
            // Act
            cat.SetName(catName);
            // Assert
            Assert.AreEqual(catName, cat.Name.ToString());

        }

    }
}