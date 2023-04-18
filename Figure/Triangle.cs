
namespace Figure
{
    public class Triangle:Figure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public bool IsRightTriangle { get; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;

            if (CheckRightTriangle(firstSide, secondSide, thirdSide) && CheckRightTriangle(secondSide, firstSide, thirdSide) && CheckRightTriangle(thirdSide, secondSide, firstSide)) 
            {
                IsRightTriangle = true;
            }
            else 
            {
                IsRightTriangle = false;
            }
        }

        public override double CalcSquare()
        {
            double parameter = (_firstSide + _secondSide + _thirdSide)/2;

            return Math.Sqrt(parameter*(parameter-_firstSide)*(parameter -_secondSide)*(parameter -_thirdSide));
        }

        private bool CheckRightTriangle(double a, double b, double c) 
        {
            return Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2);
        }

    }
}
