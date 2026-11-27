using System;
using System.Collections.Generic;
using System.Text;
using MyInheritanceLibrary;

namespace AnimalTests
{
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        public void Speak_ReturnsCorrectResult()
        {
            // arrange
            var animal = new Dog("Rex", 12, 2);

            // act
            string result = animal.Speak();

            // assert
            Assert.AreEqual("Woof", result);
        }
    }
}
