
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class ChnageNumbersWithDiaganal
{
    static void changeNumbersWIthDIaganal()
    {
        int[,] twoDArray = new int[3, 3];
        int[,] resultOfInput = inputArray(twoDArray);
        int[,] resultOfOutput = outputArray(twoDArray);

        static int[,] inputArray(int[,] twoDArray)
        {
            Random rnd = new Random();
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    twoDArray[i, j] = rnd.Next(1, 10);
                    Console.Write(twoDArray[i, j] + " ");
                }

            }
            return twoDArray;
        }

        static int[,] outputArray(int[,] twoDArray)
        {
            Random random = new Random();
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        twoDArray[i, j] = random.Next(1, 10);
                        Console.Write(twoDArray[i, j] + " ");
                    }
                    else if (i > j)
                    {
                        twoDArray[i, j] = 0;
                        Console.Write(twoDArray[i, j] + " ");
                    }
                    else
                    {
                        twoDArray[i, j] = 1;
                        Console.Write(twoDArray[i, j] + " ");
                    }
                }
                Console.WriteLine("");
            }
            return twoDArray;
        }

    }
}

