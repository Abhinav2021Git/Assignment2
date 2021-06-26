using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
   public static class TriangleSolver
    {
        
        public static string Analyze(int a, int b, int c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                if (a != b && a != c)
                {
                    string ScaleneTriangle = "This is a Scalene Triangle because all 3 sides are unequal\n";
                    return ScaleneTriangle;
                }
                else if (a == b && a != c || a == c && b != c)
                {
                    string IsoscelesTriangle = "This is an Isosceles Triangle because 2 sides are equal\n";
                    return IsoscelesTriangle;
                }
                else if (a == b && b == c)
                {
                    string EquilateralTriangle = "This is an Equilateral Triangle because all 3 sides are equal\n";
                    return EquilateralTriangle;
                }
            }
            else
            {
                string NoTriangle = "Based on your input values, it doesn't form any triangle.\n";
                return NoTriangle;
            }
            return "No";
           
        }
    }
}
