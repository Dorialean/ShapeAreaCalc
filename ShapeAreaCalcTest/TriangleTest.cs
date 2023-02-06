using ShapeAreaCalc;

namespace ShapeAreaCalcTest
{
    public class TriangleTest
    {
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 0, 0)]
        public void InitTriangleWithErrorTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void GetAreaTest()
        {
            // Data.
            double a = 3d, b = 4d, c = 5d, result = 6d;
            var triangle = new Triangle(a, b, c);

            // Act.
            var area = triangle.GetArea();

            // Assert.
            Assert.AreEqual(area, result);
        }

        [Test]
        public void InitNotTriangleTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(1, 1, 4));
        }
        


    }
}