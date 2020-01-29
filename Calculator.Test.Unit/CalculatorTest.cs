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

    }
}