using Shapes;

namespace test_Mindbox
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                IShape shape1 = new Shape(5);
                Console.Write("Square is ");
                Console.WriteLine(shape1.CalcSquare());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                IShape shape2 = new Shape(4, 3, 5);
                Console.Write("Square is ");
                Console.WriteLine(shape2.CalcSquare());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                IShape circle = new Shape(-1);
                Console.Write("Square is ");
                Console.WriteLine(circle.CalcSquare());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                IShape triangle = new Shape(4, -3, 1);
                Console.Write("Square is ");
                Console.WriteLine(triangle.CalcSquare());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                IShape triangle = new Shape(4, 3, 1);
                Console.Write("Square is ");
                Console.WriteLine(triangle.CalcSquare());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}