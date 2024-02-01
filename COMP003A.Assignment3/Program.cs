/*
 *  Author: Oscar Mendez
 *  Course: COMP - 003A
 *  Purpose: to replicate output assignment
 */


namespace COMP003A.Assignment3_
{
    internal class Program
    {
        static void Main()
        {
            // user input for numeric grade
            Console.WriteLine("Enter numeric grade (0-100): ");
            string input = Console.ReadLine();

            // Convert input to a double
            if (double.TryParse(input, out double numericGrade))
            {
                // Check if number is within range
                if (numericGrade >= 0 && numericGrade <= 100)
                {
                    // Determine letter grade base on range
                    char letterGrade = GetLetterGrade(numericGrade);

                    // Display result
                    Console.WriteLine($"Your letter grade is: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("invalid input. Numeric grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("invalid input. Please enter a valid numeric grade.");
            }
        }

        // get letter grade based on numeric grade
        static char GetLetterGrade (double numericGrade)
        {
            if (numericGrade >= 90)
                return 'A';
            else if (numericGrade >= 80)
                return 'B';
            else if (numericGrade >= 70)
                return 'C';
            else if (numericGrade >= 60)
                return 'D';
            else
                return 'F';
        }
    }
}