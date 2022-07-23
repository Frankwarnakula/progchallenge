namespace pallindrome.test
{
    [TestFixture]
    internal class NumberTest
    {
        private Number _number;

        [SetUp]
        public void SetUp()
        {
            _number = new Number();
        }

        [Test]
        public void Is_121_Returns_True()
        {
            int number = 121;
            var result = _number.IsPallindrome(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void Is_3_Returns_True()
        {
            int number = 3;
            var result = _number.IsPallindrome(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void Is__7_Returns_False()
        {
            int number = -7;
            var result = _number.IsPallindrome(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void Is_0_Returns_True()
        {
            int number = 0;
            var result = _number.IsPallindrome(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void Is_10_Returns_Falsee()
        {
            int number = 10;
            var result = _number.IsPallindrome(number);
            Assert.IsFalse(result);
        }

        [Test]
        public void Is_11_Returns_True()
        {
            int number = 11;
            var result = _number.IsPallindrome(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void Is_1214554121_Returns_True()
        {
            int number = 1214554121;
            var result = _number.IsPallindrome(number);
            Assert.IsTrue(result);
        }

        [Test]
        public void Is__121_Returns_False()
        {
            int number = -121;
            var result = _number.IsPallindrome(number);
            Assert.IsFalse(result);
        }
    }
}
