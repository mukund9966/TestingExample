using NUnit.Framework;
using ConsoelAppNunit2;
using System;

namespace ConsoleApp1
{
    [TestFixture]
    internal class Program
    {
        public Class1 utility;

        [SetUp]
        public void Setup()
        {
            utility = new Class1();
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(8, utility.Add(4, 4));
            Assert.AreEqual(-5, utility.Add(-2, -3));
            Assert.AreEqual(0, utility.Add(0, 0));
        }

        [Test]
        public void TestSubtract()
        {
            Assert.AreEqual(-1, utility.Subtract(3, 4));
            Assert.AreEqual(1, utility.Subtract(-2, -3));
            Assert.AreEqual(0, utility.Subtract(0, 0));
        }

        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(2, utility.Divide(6, 3));
            Assert.AreEqual(-2, utility.Divide(6, -3));
            Assert.Throws<ArgumentException>(() => utility.Divide(5, 0));
        }

        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual(6, utility.Multiply(2, 3));
            Assert.AreEqual(-6, utility.Multiply(2, -3));
            Assert.AreEqual(0, utility.Multiply(0, 0));
        }

        [Test]
        public void TestIsPrime()
        {
            Assert.IsTrue(utility.IsPrime(2));
            Assert.IsTrue(utility.IsPrime(3));
            Assert.IsFalse(utility.IsPrime(4));
            Assert.IsTrue(utility.IsPrime(17));
            Assert.IsFalse(utility.IsPrime(20));
            Assert.IsTrue(utility.IsPrime(997));
        }
    }
   internal class program
    {
        static void Main(string[] args)
        {

        }
    }
}
