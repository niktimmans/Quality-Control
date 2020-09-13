using NUnit.Framework;
using System;
using System.IO;
using System.Linq;
using triangle;

namespace triangleTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new object[] { "3", "4", "5" })]
        [TestCase (new object[] { "2,2", "1", "3" })]
        [TestCase (new object[] { "2147483647", "2147483648", "2149483647" })]


        [Test]
        public void GetSimpleTriangleTypeTest(object[] input)
        {
            String[] inputString = input.Cast<string>().ToArray();
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(inputString);
            String expected = "Обычный\r\n";
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestCase(new object[] { "4", "4", "6" })]
        [TestCase(new object[] { "6", "4", "4" })]
        [TestCase(new object[] { "4", "6", "4" })]
        [TestCase(new object[] { "4                     ", "6                      ", "4" })]

        [Test]

        public void GetIsoscelesTriangleTypeTest(object[] input)
        {
            String[] inputString = input.Cast<string>().ToArray();
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(inputString);
            String expected = "Равнобедренный\r\n";
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestCase(new object[] { "6", "6", "6" })]

        [Test]

        public void GetEquilateralTriangleTypeTest(object[] input)
        {
            String[] inputString = input.Cast<string>().ToArray();
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(inputString);
            String expected = "Равносторонний\r\n";
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestCase(new object[] { "", "", "" })]
        [TestCase(new object[] { "" })]
        [TestCase(new object[] { "4" })]
        [TestCase(new object[] { "-1", "2", "4" })]
        [TestCase(new object[] { "-124" })]
        [TestCase(new object[] { "" })]
        [TestCase(new object[] { "-1", "a", "4" })]
        [TestCase(new object[] { "a", "b", "c" })]
        [TestCase(new object[] { "2", "2" })]
        [TestCase(new object[] { "" })]
        [TestCase(new object[] { "1", "2", "3", "4" })]
        [TestCase(new object[] { "1.2412345135E+400", "1.2412345135E+401", "1.2412345135E+400" })]
        [TestCase(new object[] { null, "1", "2"})]

        [Test]

        public void GetError_NotTriangleTest(object[] input)
        {
            String[] inputString = input.Cast<string>().ToArray();
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(inputString);
            String expected = "Не треугольник\r\n";
            Assert.AreEqual(expected, sw.ToString());
        }

    }
}