using Shapes;

namespace test_Mindbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IShapeSquareCalculator circle = new Circle(1);
                Console.Write("Square is ");
                Console.WriteLine(circle.CalcSquare());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IShapeSquareCalculator circle = new Circle(-1);
                Console.Write("Square is ");
                Console.WriteLine(circle.CalcSquare());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IShapeSquareCalculator triangle = new Triangle(4, 3, 2);
                Console.Write("Square is ");
                Console.WriteLine(triangle.CalcSquare());
                Console.Write("Is right triangle? ");
                Triangle tri = triangle as Triangle;
                Console.WriteLine(tri.IsRightTriangle );
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IShapeSquareCalculator triangle = new Triangle(4, 3, 5);
                Console.Write("Square is ");
                Console.WriteLine(triangle.CalcSquare());
                Console.Write("Is right triangle? ");
                Triangle tri = triangle as Triangle;
                Console.WriteLine(tri.IsRightTriangle);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IShapeSquareCalculator triangle = new Triangle(4, -3, 1);
                Console.Write("Square is ");
                Console.WriteLine(triangle.CalcSquare());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IShapeSquareCalculator triangle = new Triangle(4, 3, 1);
                Console.Write("Square is ");
                Console.WriteLine(triangle.CalcSquare());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            IShapeSquareCalculator[] shapeArray = {new Circle(3), new Triangle(3,4,5) };
            foreach (var item in shapeArray)
            {
                Console.WriteLine(item.CalcSquare());
            }

        }
    }
}