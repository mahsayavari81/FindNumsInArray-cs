using System;

class Program
{
    static void Main(string[] args)
    {
        //initialize a 10x10 array
        int[,] a = new int[10, 10];

        Console.WriteLine("Enter values for the a:");

        //get values from input
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Enter value for [{i}, {j}]: ");
                int val = int.Parse(Console.ReadLine()!);
                a[i, j] = val;
            }
        }

        //get two numbers to search
        Console.WriteLine("Enter the two numbers:");
        int num1 = int.Parse(Console.ReadLine()!);
        int num2 = int.Parse(Console.ReadLine()!);

        bool found = false;

        //search for first and second number in columns
        for (int col = 0; col < 10; col++)
        {

            //not found
            int row1 = -1, row2 = -1;

            //search for numbers
            for (int row = 0; row < 10; row++)
            {
                //first number found
                if (a[row, col] == num1)
                {
                    row1 = row;
                }
                //second number found
                if (a[row, col] == num2)
                {
                    row2 = row;
                }
            }
            //both numbers found
            if (row1 != -1 && row2 != -1)
            {
                Console.WriteLine(num1 + " found: " + $"[{row1}, {col}]");
                Console.WriteLine(num1 + " found: " + $"[{row2}, {col}]");
                found = true;

                //exit the loop
                break;
            }
        }
        //if not found
        if (!found)
        {
            //output not found
            Console.WriteLine("Not Found!");
        }
    }
}