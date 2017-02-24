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
    public class PoodleTests
    {
        [TestMethod()]
        public void testPoodleSound()
        {
            var poodle = new Poodle();
            var response = poodle.sound();
            string expectedResponse = "Roff!";
            Assert.AreEqual(expectedResponse, response);
        }

        [TestMethod()]
        public void testPoodleSoundType()
        {
            var poodle = new Poodle();
            var response = poodle.sound();
            Assert.IsInstanceOfType(response, typeof(string));
        }
    }
}