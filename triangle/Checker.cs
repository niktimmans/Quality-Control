using System;
using System.Collections.Generic;
using System.Text;


namespace triangle
{
    class Checker
    {
        public static bool argsCheck(string[] args)
        {
            if (args.Length != 4)
            {
                return false;
            }
            return true;
        }

        public static double[] parse(string[] args)
        {
            double[] sides = new double[3];
            int i = 0;
            foreach (string arg in args)
            {
                double.TryParse(arg, out sides[i]);
                i++;
            }
            return sides;
        }
        public static String triangleType(double[] sides)
        {
            Array.Sort(sides);
            if (zeroLength(sides)) { return "Не треугольник"; }
            if (isEquilateral(sides)) { return "Равносторонний"; }
            if (isIsosceles(sides)) { return "Равнобедренный"; }
            if (isSimple(sides)) { return "Обычный"; }
            return "Неизвестная ошибка";
        }

        public static bool zeroLength(double[] sides)
        {
            foreach(int side in sides)
            {
                if (side == 0) { return true; }
            }
            if(!(sides[2] < sides[0] + sides[1] && sides[2] > sides[1] - sides[0])) { return true; }
            return false;
        }
        public static bool isEquilateral(double[] sides)
        {
            if(sides[0] == sides[1] && sides[1] == sides[2]) { return true; }
            return false;
        }
        public static bool isIsosceles(double[] sides)
        {
            if(sides[0] == sides[1]) { return true; }
            if(sides[1] == sides[2]) { return true; }
            return false;
        }
        public static bool isSimple(double[] sides)
        {
            if(sides[2] < sides[0] + sides[1] && sides[2] > sides[1] - sides[0]) { return true; }
            return false;
        }
    }
}
