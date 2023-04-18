using FluentAssertions;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTests
{
    public class CircleTests
    {
        [Fact]
        public void CalcSquare_Radius_RightSquare() 
        {
            // Arrange
            var circle = new Circle(3);
            
            // Act
            double square = circle.CalcSquare();

            // Assert
            double rightSquare = 28.274333882308138;
            square.Should().Be(rightSquare);
        }

        [Fact]
        public void Constructor_InvalidRadius_ArgumentException()
        {
            // Act
            Action act = () => new Circle(-1);
           
            // Assert
            act.Should().Throw<ArgumentException>().
                WithMessage("Radius should be greater than 0.");
        }
    }
}
