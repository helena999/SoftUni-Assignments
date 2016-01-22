//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below. 

using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        int row = 0;
        int col = 0;
        int size = n*n;
        string direction = "right";


        if (n >= 1 && n <= 15)
        {
            for (int i = 1; i <= size; i++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row,col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                else if (direction == "down" && (row > n - 1 || matrix[row,col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                else if (direction == "left" && (col < 0 || matrix[row,col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                else if (direction == "up" && (row < 0 || matrix[row,col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                else if (direction == "down")
                {
                    row++;
                }
                else if (direction == "left")
                {
                    col--;
                }
                else if (direction == "up")
                {
                    row--;
                }

            }
        }
        else
        {
            Console.WriteLine("Please enter number between 1 and 20");
        }

        PrintMatrix(matrix);
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write("{0,4}",matrix[r,c]);
            }
            Console.WriteLine();
        }

    }
}
