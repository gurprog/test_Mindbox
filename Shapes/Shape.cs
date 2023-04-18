namespace Shapes
{
    public class Shape:IShape
    {
        private IShape _shape { get; set; }

        public Shape(double radius) 
        {
            _shape = new Circle(radius);
        }

        public Shape(double firstSide, double secondSide, double thirdSide) 
        {
            _shape = new Triangle(firstSide, secondSide, thirdSide);
        }

        public double CalcSquare()
        {
            return _shape.CalcSquare();
        }
    }
}
