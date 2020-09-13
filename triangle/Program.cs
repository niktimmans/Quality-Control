using System;


namespace triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (Checker.argsCheck(args))
            {
                Console.WriteLine("Не треугольник");
            }
            else
            {
                double[] sides = Checker.parse(args);
                Console.WriteLine(Checker.triangleType(sides));
            }
        }
    }
}
