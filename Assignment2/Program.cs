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
            bool result = true;
            try
            {
                while (result)
                {
                    Console.WriteLine("-----Menu options are as follows: -------");
                    Console.WriteLine("1. Enter triangle dimensions");
                    Console.WriteLine("2. Exit\n");
                    Console.WriteLine("Please select a valid menu option i.e. either 1 or 2\n");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        switch (choice)
                        {
                            case 1:
                                int first_value = 0, second_value = 0, third_value = 0;
                                do
                                {
                                    Console.WriteLine("Enter the first side (1st integer value) of a triangle");
                                    first_value = Convert.ToInt32(Console.ReadLine());
                                    if (first_value <= 0)
                                    {
                                        Console.WriteLine("The 1st side of a triangle can't be <= zero & u have entered : {0}\n", first_value);
                                    }
                                } while (first_value <= 0);
                                if (first_value >= 1)
                                {
                                    do
                                    {
                                        Console.WriteLine("Enter the second side (2nd integer value) of a triangle");
                                        second_value = Convert.ToInt32(Console.ReadLine());
                                        if (second_value <= 0)
                                        {
                                            Console.WriteLine("The 2nd side of a triangle can't be <= zero & u have entered : {0}\n", second_value);
                                        }
                                    } while (second_value <= 0);
                                }
                                if (second_value >= 1)
                                {
                                    do
                                    {
                                        Console.WriteLine("Enter the third side (3rd integer value) of a triangle");
                                        third_value = Convert.ToInt32(Console.ReadLine());
                                        if (third_value <= 0)
                                        {
                                            Console.WriteLine("The 3rd side of a triangle can't be <= zero & u have entered : {0}\n", third_value);
                                        }
                                    } while (third_value <= 0);
                                }

                                if (first_value != 0 && second_value != 0 && third_value != 0)
                                {
                                    string final_result = TriangleSolver.Analyze(first_value, second_value, third_value);
                                    Console.WriteLine(final_result);
                                }
                                else
                                    Console.WriteLine("On the basis of your input values, it doesn't form any triangle.");

                                break;

                            case 2:
                                result = false;
                                Console.WriteLine("Good Bye! See you soon...");
                                break;

                            default:
                                Console.WriteLine("Invalid menu option i.e. {0}\n", choice);
                                break;
                        }
                    }
                }

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
