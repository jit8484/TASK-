using System;

class BorderedPattern
{
    static void Main()
    {
        int n = 5; // Size of the square

        for (int i = 0; i < n; i++)                                             // Outer loop for rows
        {
            for (int j = 0; j < n; j++)                                        // Inner loop for columns
            {
                if (i == 0 || i == n - 1 || j == 0 || j == n - 1)  
                                                                           // Checking if the current position is on the border
                     Console.Write("* ");                                // Printing asterisk if on the border
                else
                    Console.Write("  ");                         // Printing space if inside the border
            }
            Console.WriteLine();                            // Moving to the next line after each row
        }
    }
}
