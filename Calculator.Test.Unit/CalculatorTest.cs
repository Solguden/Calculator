using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            //Arrange
            uut = new Calculator();
        }

        [Test]
        public void Add_2and2_Return4()
        {
            //Act
            var check = uut.Add(2, 2);

            //Assert
            Assert.That(check, Is.EqualTo(4));
        }

        [TestCase(1, 2, 3)]
        [TestCase(5,5, 10)]
        [TestCase(5, 0, 5)]
        [TestCase(0, 10, 10)]
        [TestCase(10,-10, 0)]
        [TestCase(-20, 20, 0)]
        [TestCase(-5, -5, -10)]
        public void Add(int integer1, int integer2, int result)
        {
            // Act
            var check = uut.Add(integer1, integer2);

            // Assert
            Assert.That(check, Is.EqualTo(result));
        }

        [TestCase(5, 2, 3)]
        [TestCase(5, 5, 0)]
        [TestCase(10, 0, 10)]
        [TestCase(5, 10, -5)]
        [TestCase(0, 10, -10)]
        [TestCase(10, -10, 20)]
        [TestCase(-20, 20, -40)]
        [TestCase(-5, -5, 0)]
        public void Subtract(int integer1, int integer2, int result)
        {
            // Act
            var check = uut.Subtract(integer1, integer2);

            // Assert
            Assert.That(check, Is.EqualTo(result));
        }

    }
}