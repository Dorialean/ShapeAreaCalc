using ShapeAreaCalc;

namespace ShapeAreaCalcTest
{
	public class CircleTest
	{
        [Test]
        public void ZeroRadiusTest() 
            => Assert.Catch<ArgumentException>(() => new Circle(0d));


        [Test]
        public void NegativeRadiusTest() 
            => Assert.Catch<ArgumentException>(() => new Circle(-1d));


        [Test]
        public void GetAreaTest()
        {
            //Data
            double radius = 5d;
            double expectedValue = Math.PI * Math.Pow(radius, 2d);

            //Act
            var circle = new Circle(radius);
            double area = circle.GetArea();

            //Assert
            Assert.That(area, Is.EqualTo(expectedValue));
        }

    }
}
