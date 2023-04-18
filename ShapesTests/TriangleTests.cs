using FluentAssertions;
using Shapes;

namespace ShapesTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalcSquare_Sides_RightSquare()
        {
            // Arrange
            var triangle = new Triangle(3,4,5);

            // Act
            double square = triangle.CalcSquare();

            // Assert
            double rightSquare = 6;
            square.Should().Be(rightSquare);
        }

        [Fact]
        public void IsRightSquare_TypeOfTrisngle_True()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle;

            // Assert
            isRightTriangle.Should().BeTrue();
        }

        [Fact]
        public void IsRightSquare_TypeOfTrisngle_False()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 4);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle;

            // Assert
            isRightTriangle.Should().BeFalse();
        }

        [Fact]
        public void Constructor_InvalidSides_ArgumentException()
        {
            // Act
            Action act = () => new Triangle(-1,3,5);

            // Assert
            act.Should().Throw<ArgumentException>().
                WithMessage("Sides should be greater than 0.");
        }
        [Fact]
        public void Constructor_InvalidLethgthOfSides_ArgumentException()
        {
            // Act
            Action act = () => new Triangle(1, 3, 4);

            // Assert
            act.Should().Throw<ArgumentException>().
                WithMessage("The sum of two sides should be less than third side.");
        }
    }
}
