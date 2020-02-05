using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        #region Add tests

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
        public void Add(double d1, double d2, int result)
        {
            // Act
            var check = uut.Add(d1, d2);

            // Assert
            Assert.That(check, Is.EqualTo(result));
        }

        #endregion

        #region Subtract Tests

        [TestCase(5, 2, 3)]
        [TestCase(5, 5, 0)]
        [TestCase(10, 0, 10)]
        [TestCase(5, 10, -5)]
        [TestCase(0, 10, -10)]
        [TestCase(10, -10, 20)]
        [TestCase(-20, 20, -40)]
        [TestCase(-5, -5, 0)]
        public void Subtract(double d1, double d2, int result)
        {
            // Act
            var check = uut.Subtract(d1, d2);

            // Assert
            Assert.That(check, Is.EqualTo(result));
        }

        #endregion

        #region Multiply Tests

        [TestCase(1, 2, 2)]
        [TestCase(5, 5, 25)]
        [TestCase(10, 0, 0)]
        [TestCase(10, -5, -50)]
        [TestCase(-10, -10, 100)]
        public void Multiply(double d1, double d2, int Result)
        {
            // Act
            var check = uut.Multiply(d1, d2);

            // Assert
            Assert.That(check, Is.EqualTo(Result));
        }

        #endregion

        #region Power Tests

        [TestCase(2, 2, 4)]

        public void Power(double d1, double d2, int Result)
        {
            // Act
            var check = uut.Power(d1, d2);

            // Assert
            Assert.That(check, Is.EqualTo(Result));
        }

        #endregion

    }
}