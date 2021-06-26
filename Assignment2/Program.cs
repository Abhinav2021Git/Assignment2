using System;

namespace Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
           UserInput();
        }

        public static int UserInput()
        {
            int choice = 0;
            try
            {
                do
                {
                    Console.WriteLine("-----Menu options are as follows: -------");
                    Console.WriteLine("1. Enter triangle dimensions");
                    Console.WriteLine("2. Exit\n");
                    Console.WriteLine("Please select a valid menu option i.e. either 1 or 2");


                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        switch (choice)
                        {
                            case 1:

                                int first_value, second_value, third_value;
                                Console.WriteLine("Enter the first side (1st integer value) of a triangle");
                                first_value = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the second side (2nd integer value) of a triangle");
                                second_value = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the third side (3rd integer value) of a triangle");
                                third_value = Convert.ToInt32(Console.ReadLine());
                                if (first_value >= 0 && second_value >= 0 && third_value >= 0)
                                {
                                    if (first_value != second_value && first_value != third_value)
                                    {
                                        Console.WriteLine("This is a Scalene Triangle because all 3 sides are unequal\n");
                                    }
                                    else if (first_value == second_value && first_value != third_value || first_value == third_value && second_value != third_value)
                                    {
                                        Console.WriteLine("This is an Isosceles Triangle because 2 sides are equal\n");
                                    }
                                    else if (first_value == second_value && second_value == third_value)
                                    {
                                        Console.WriteLine("This is an Equilateral Triangle because all 3 sides are equal\n");
                                    }
                                }
                                else
                                    Console.WriteLine("Based on your input values, it doesn't form any triangle.\n");
                                    break;

                            case 2:
                                Console.WriteLine("Good Bye! See you soon...");
                                break;

                            default:
                                Console.WriteLine("Invalid menu option i.e. {0}\n", choice);
                                break;
                        }
                        break;
                    }
                } while (choice != 1 || choice != 2);

            }
            catch (FormatException exception)
            {
                Console.WriteLine("Invalid Input\n");
                UserInput();
            }
            return choice;
        }
    }
}
