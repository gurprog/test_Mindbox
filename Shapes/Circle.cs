namespace Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius should be greater than 0.");
            Radius = radius;
        }

        public double CalcSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
