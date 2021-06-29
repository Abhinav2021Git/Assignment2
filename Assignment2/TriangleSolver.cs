using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public static class TriangleSolver
    {

        public static string Analyze(int a, int b, int c)
        {
            //2nd Way to check whether triangle can be formed or not?
            /* if (a >= (b + c) || b >= (a + c)   || c >= (a + b))
             {
                 string NoTriangle = "Based on your input values, no triangle can be formed\n";
                 return NoTriangle;
             }*/
            if (a < (b + c) && b < (c + a) && c < (a + b))
            {
                Console.WriteLine("The Triangle can be formed\n");
                if (a == b && b == c)
                {
                    string EquilateralTriangle = "This is an Equilateral Triangle because all 3 sides are equal\n";
                    return EquilateralTriangle;
                }
                else if (a != b && b != c && c != a)
                {
                    string ScaleneTriangle = "This is a Scalene Triangle because all 3 sides are unequal\n";
                    return ScaleneTriangle;
                }
                else if (a == b || b == c || c == a)
                {
                    string IsoscelesTriangle = "This is an Isosceles Triangle because 2 sides are equal\n";
                    return IsoscelesTriangle;
                }
            }
            return "Based on your input values, no triangle can be formed\n";

        }
    }
}

