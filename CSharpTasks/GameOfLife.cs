using System;

public class GameOfLife

{
    static void Main(string[] args)
    {
        string[,] resultOfInput = create2DArray(5, 9);
        startGame(resultOfInput);
    }

    static string[,] create2DArray(int firstLength, int secondLength)
    {
        string[,] twoDArray = new string[firstLength, secondLength];
        for (int i = 0; i < twoDArray.GetLength(0); i++)
        {
            Console.Write($"Row:{i}");
            for (int j = 0; j < twoDArray.GetLength(1); j++)
            {
                string randomInput = (new Random().Next() % 2 == 1 ? "-" : "+");
                twoDArray[i, j] = randomInput;

                Console.Write(twoDArray[i, j] + " ");
            }
        }
        return twoDArray;
    }
    static string[,] startGame(string[,] twoDArray)
    {
        int countOfChanges = 1;
        while (countOfChanges > 0)
        {
            countOfChanges = 0;
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    int livePointAround = 0;
                    if (j - 1 >= 0)
                    {
                        if (twoDArray[i, j - 1] == "+")
                        {
                            livePointAround++;
                        }


                        if (i - 1 >= 0)
                        {
                            if (twoDArray[i - 1, j - 1] == "+")
                            {
                                livePointAround++;
                            }
                        }

                        if (i + 1 < twoDArray.GetLength(0))
                        {
                            if (twoDArray[i + 1, j - 1] == "+")
                            {
                                livePointAround++;
                            }

                            if (twoDArray[i + 1, j] == "+")
                            {
                                livePointAround++;
                            }
                        }

                        if (i - 1 >= 0)
                        {
                            if (twoDArray[i - 1, j] == "+")
                            {
                                livePointAround++;
                            }

                            if (j + 1 < twoDArray.GetLength(1))
                            {
                                if (twoDArray[i - 1, j + 1] == "+")
                                {
                                    livePointAround++;
                                }
                            }
                        }
                        if (j + 1 < twoDArray.GetLength(1))
                        {
                            if (twoDArray[i, j + 1] == "+")
                            {
                                livePointAround++;
                            }

                            if (i + 1 < twoDArray.GetLength(0))
                            {
                                if (twoDArray[i + 1, j + 1] == "+")
                                {
                                    livePointAround++;
                                }
                            }
                        }

                    }

                    if (twoDArray[i, j] == "+" && (livePointAround < 2 || livePointAround > 3))
                    {
                        twoDArray[i, j] = "-";
                        countOfChanges++;
                    }
                    if (twoDArray[i, j] == "-" && livePointAround == 3)
                    {
                        twoDArray[i, j] = "+";
                        countOfChanges++;
                    }
                }
            }


        }
        Console.WriteLine("GAME OVER");
        return twoDArray;
    }



}
