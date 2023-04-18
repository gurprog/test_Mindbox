namespace Shapes
{
    public class Triangle:IShape
    {
        public double FirstSide { get; }
        private double SecondSide { get; }
        private double ThirdSide { get; }

        public bool IsRightTriangle { get; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Sides should be greater than 0.");
            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide)
                throw new ArgumentException("The sum of two sides should be less than third side.");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            if (CheckRightTriangle(firstSide, secondSide, thirdSide) && CheckRightTriangle(secondSide, firstSide, thirdSide) && CheckRightTriangle(thirdSide, secondSide, firstSide))
            {
                IsRightTriangle = true;
            }
            else
            {
                IsRightTriangle = false;
            }
        }

        public double CalcSquare()
        {
            double parameter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(parameter * (parameter - FirstSide) * (parameter - SecondSide) * (parameter - ThirdSide));
        }

        private bool CheckRightTriangle(double a, double b, double c)
        {
            return Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2);
        }
    }
}
