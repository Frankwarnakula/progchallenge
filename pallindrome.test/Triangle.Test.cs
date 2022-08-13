namespace challenge.test
{
    [TestFixture]
    internal class TriangleTest
    {

        [Test]
        public void Is_1_4__5_6__6_1__4_5_Returns_True()
        {
            Triangle triangle = new Triangle(new Point(1,4), new Point(5,6), new Point(6,1));
            Assert.IsTrue(triangle.IsPointInside(new Point(4,5)));
        }

        [Test]
        public void Is_0_0__4_0__0_4__1_1_Returns_True()
        {
            Triangle triangle = new Triangle(new Point(0, 0), new Point(4, 0), new Point(0, 4));
            Assert.IsTrue(triangle.IsPointInside(new Point(1, 1)));
        }

        [Test]
        public void Is__6_2___2__2__8_4__4_2_Returns_True()
        {
            Triangle triangle = new Triangle(new Point(-6, 2), new Point(-2, -2), new Point(8, 4));
            Assert.IsTrue(triangle.IsPointInside(new Point(4, 2)));
        }

        [Test]
        public void Is_1_4__5_6__6_1__3_2_Returns_False()
        {
            Triangle triangle = new Triangle(new Point(1, 4), new Point(5, 6), new Point(6, 1));
            Assert.IsFalse(triangle.IsPointInside(new Point(3, 2)));
        }
    }
}