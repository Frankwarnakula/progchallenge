using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pallindrome.test
{
    [TestFixture]
    internal class NumberToTextTest
    {

        private NumberToText _numberToText;

        [SetUp]
        public void SetUp()
        {
            _numberToText = new NumberToText();
        }

        [TestCase(0, "Zero")]
        [TestCase(1, "One")]
        [TestCase(2, "Two")]
        [TestCase(3, "Three")]
        [TestCase(4, "Four")]
        [TestCase(5, "Five")]
        [TestCase(6, "Six")]
        [TestCase(7, "Seven")]
        [TestCase(8, "Eight")]
        [TestCase(9, "Nine")]
        [TestCase(10, "Ten")]
        [TestCase(11, "Eleven")]
        [TestCase(12, "Twelve")]
        [TestCase(13, "Thirteen")]
        [TestCase(14, "Fourteen")]
        [TestCase(15, "Fifteen")]
        [TestCase(16, "Sixteen")]
        [TestCase(17, "Seventeen")]
        [TestCase(18, "Eighteen")]
        [TestCase(19, "Nineteen")]
        [TestCase(20, "Twenty")]
        [TestCase(30, "Thirty")]
        [TestCase(40, "Forty")]
        [TestCase(49, "Forty Nine")]
        [TestCase(50, "Fifty")]
        [TestCase(60, "Sixty")]
        [TestCase(70, "Seventy")]
        [TestCase(80, "Eighty")]
        [TestCase(85, "Eighty Five")]
        [TestCase(90, "Ninety")]
        [TestCase(99, "Ninety Nine")]
        [TestCase(100, "One Hundred")]
        [TestCase(123, "One Hundred Twenty Three")]
        [TestCase(999, "Nine Hundred Ninety Nine")]
        [TestCase(9999, "Nine Thousand Nine Hundred Ninety Nine")]
        [TestCase(12345, "Twelve Thousand Three Hundred Forty Five")]
        [TestCase(1000000, "One Million")]
        [TestCase(1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")]
        [TestCase(1234567000, "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand")]
        [TestCase(2147483647, "Two Billion One Hundred Forty Seven Million Four Hundred Eighty Three Thousand Six Hundred Forty Seven")]
        public void TestNumberToWords(int number, string text)
        {
            Assert.That(_numberToText.numberToWords(number), Is.EqualTo(text));
        }
    }
}
