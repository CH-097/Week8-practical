using MyInheritanceLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace AnimalTests
{
    [TestClass]
    public sealed class AnimalTests
    {
        [TestMethod]
        public void Speak_ReturnsCorrectResult()
        {
            //Add test methods to the AnimalTests class to test the Speak() method.


            // arrange
            var animal = new Animal("Duck", 12, 2);

            //Act
            string result = animal.Speak();

            // Assert
            Assert.AreEqual("Hello", result);

        }
    }
}

