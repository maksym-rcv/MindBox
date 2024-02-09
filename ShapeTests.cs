
namespace GeometryLib.Tests
{
    public class ShapeTests
    {
        [Test]
        public void CircleArea_CalculatedCorrectly()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void TriangleArea_CalculatedCorrectly()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6; // For a triangle with sides 3, 4, 5 (a Pythagorean triple), the area is 6.

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void Triangle_IsRightTriangle()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }
    }
}
