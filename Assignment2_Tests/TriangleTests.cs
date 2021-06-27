using Assignment2;
using NUnit.Framework;

namespace Assignment2_Tests
{
    [TestFixture]
    public class TriangleTests
    {
        /* To verify whether an Equilateral triangle can be formed if all three sides(i.e., 3, 3, and 3) are equal  */
        [Test]
        public void Verify_EquilateralTriangle_With_Three_Three_And_Three_InputValues()
        {
            int num1 = 3, num2 = 3, num3 = 3; // arrange
            string result = TriangleSolver.Analyze(num1, num2, num3); //act
            Assert.AreEqual("This is an Equilateral Triangle because all 3 sides are equal\n", result); //assert
        }

        /* To verify whether an Equilateral triangle can be formed if all three sides(i.e., 9, 9, and 9) are equal  */
        [Test]
        public void Verify_EquilateralTriangle_With_Nine_Nine_And_Nine_InputValues()
        {
            int num1 = 9, num2 = 9, num3 = 9; // arrange
            string result = TriangleSolver.Analyze(num1, num2, num3); //act
            Assert.AreEqual("This is an Equilateral Triangle because all 3 sides are equal\n", result); //assert
        }

        /* To verify whether an Equilateral triangle can be formed if all three sides(i.e., 5, 5, and 5) are equal  */
        [Test]
        public void Verify_EquilateralTriangle_With_Five_Five_And_Five_InputValues()
        {
            int num1 = 5, num2 = 5, num3 = 5; // arrange
            string result = TriangleSolver.Analyze(num1, num2, num3); //act
            Assert.AreEqual("This is an Equilateral Triangle because all 3 sides are equal\n", result); //assert
        }

        /* To verify whether a Scalene triangle can be formed if all three sides(i.e., 5, 6, and 9) are different  */

        [Test]
        public void Verify_ScaleneTriangle_With_Five_Six_And_Nine_InputValues()
        {
            int num1 = 5, num2 = 6, num3 = 9; // arrange
            string result = TriangleSolver.Analyze(num1, num2, num3); //act
            Assert.AreEqual("This is a Scalene Triangle because all 3 sides are unequal\n", result); //assert
        }

        /* To verify whether a Scalene triangle can be formed if all three sides(i.e., 10, 15, and 20) are different  */
        [Test]
        public void Verify_ScaleneTriangle_With_Ten_Fifteen_And_Twenty_InputValues()
        {
            int num1 = 10, num2 = 15, num3 = 20; // arrange
            string result = TriangleSolver.Analyze(num1, num2, num3); //act
            Assert.AreEqual("This is a Scalene Triangle because all 3 sides are unequal\n", result); //assert
        }

        /* To verify whether an Isosceles triangle can be formed if any two sides(i.e., 5, 5, and 6) are equal  */
        [Test]
        public void Verify_IsoscelesTriangle_With_Five_Five_And_Six_InputValues()
        {
            int num1 = 5, num2 = 5, num3 = 6; // arrange
            string result = TriangleSolver.Analyze(num1, num2, num3); //act
            Assert.AreEqual("This is an Isosceles Triangle because 2 sides are equal\n", result); //assert
        }

        /* To verify whether an Isosceles triangle can be formed if any two sides(i.e., 3, 6, and 6) are equal  */
        [Test]
        public void Verify_IsoscelesTriangle_With_Three_Six_And_Six_InputValues()
        {
            int num1 = 3, num2 = 6, num3 = 6; // arrange
            string result = TriangleSolver.Analyze(num1, num2, num3); //act
            Assert.AreEqual("This is an Isosceles Triangle because 2 sides are equal\n", result); //assert
        }

        /* To verify whether an Isosceles triangle can be formed if any two sides(i.e., 8, 6, and 8) are equal  */
        [Test]
        public void Verify_IsoscelesTriangle_With_Eight_Six_And_Eight_InputValues()
        {
            int num1 = 8, num2 = 6, num3 = 8; // arrange
            string result = TriangleSolver.Analyze(num1, num2, num3); //act
            Assert.AreEqual("This is an Isosceles Triangle because 2 sides are equal\n", result); //assert
        }

        /* To verify No triangle can be formed if sum of two sides is less than to third side  */
        [Test]
        public void Verify_NoTriangle_Is_Formed_When_Sum_Of_Two_InputValues_Is_Less_Than_ThirdSide()
        {
            int num1 = 5, num2 = 6, num3 = 12; // arrange
            string result = TriangleSolver.Analyze(num1, num2, num3); //act
            Assert.AreEqual("Based on your input values, no triangle can be formed\n", result); //assert
        }

        /* To verify No triangle can be formed if sum of two sides is equal to third side  */
        public void Verify_NoTriangle_Is_Formed_When_Sum_Of_Two_InputValues_Is_EqualTo_ThirdSide()
        {
            int num1 = 10, num2 = 10, num3 = 20; // arrange
            string result = TriangleSolver.Analyze(num1, num2, num3); //act
            Assert.AreEqual("Based on your input values, no triangle can be formed\n", result); //assert
        }

    }
}
