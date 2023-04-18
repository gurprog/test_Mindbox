namespace Shapes
{
    public class Triangle : IShapeSquareCalculator
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }

        public bool IsRightTriangle => CheckRightTriangleByPifagor();

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Sides should be greater than 0.");
            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide)
                throw new ArgumentException("The sum of two sides should be less than third side.");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public double CalcSquare()
        {
            double parameter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(parameter * (parameter - FirstSide) * (parameter - SecondSide) * (parameter - ThirdSide));
        }


        private bool CheckRightTriangleByPifagor()
        {
            double[] sides = {FirstSide, SecondSide, ThirdSide};
            var orderedSides = sides.Order().ToArray();
            return Math.Pow(orderedSides[2], 2) == Math.Pow(orderedSides[1], 2) + Math.Pow(orderedSides[0], 2);
        }
    }
}
