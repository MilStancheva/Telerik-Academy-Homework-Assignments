using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int n = numbers[0];
            int m = numbers[1];
            var matrix = new string[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new string[m];
            }
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').ToArray();
            }

            int counter = 1;
            int bestCounter = 1;
            int newRow = 0;
            int newCol = 0;
            bool isCounted = true;
           

            for (int row = 1; row < n - 1; row++)
            {
                for (int col = 1; col < m - 1; col++)
                {
                    if (matrix[row][col] == matrix[row - 1][col])
                    {
                        counter++;
                        isCounted = true;
                        if (counter >= bestCounter)
                        {
                            bestCounter = counter;
                            newRow = row;
                            newCol = col;
                            matrix[row][col] = null;
                            continue;
                        }
                        else
                        {
                            bestCounter = counter;
                            isCounted = false;
                            counter = 1;
                            continue;
                        }
                    }
                    if (matrix[row][col] == matrix[row - 1][col - 1])
                    {
                        counter++;
                        isCounted = true;

                        if (counter >= bestCounter)
                        {
                            bestCounter = counter;
                            newRow = row;
                            newCol = col;
                            matrix[row][col] = null;

                            continue;
                        }
                        else
                        {
                            bestCounter = counter;
                            isCounted = false;
                            counter = 1;
                            
                            continue;
                        }
                    }
                    if (matrix[row][col] == matrix[row - 1][col + 1])
                    {
                        counter++;
                        isCounted = true;
                        if (counter >= bestCounter)
                        {
                            bestCounter = counter;
                            newRow = row;
                            newCol = col;
                            matrix[row][col] = null;

                            continue;
                        }
                        else
                        {
                            bestCounter = counter;
                            isCounted = false;
                            counter = 1;
                            continue;
                        }
                    }
                    if (matrix[row][col] == matrix[row][col - 1])
                    {
                        counter++;
                        isCounted = true;
                        if (counter >= bestCounter)
                        {
                            bestCounter = counter;
                            newRow = row;
                            newCol = col;
                            matrix[row][col] = null;

                            continue;
                        }
                        else
                        {
                            bestCounter = counter;
                            isCounted = false;
                            counter = 1;
                            continue;
                        }
                    }
                    if (matrix[row][col] == matrix[row][col + 1])
                    {
                        counter++;
                        isCounted = true;
                        if (counter >= bestCounter)
                        {
                            bestCounter = counter;
                            newRow = row;
                            newCol = col;
                            matrix[row][col] = null;

                            continue;
                        }
                        else
                        {
                            bestCounter = counter;
                            isCounted = false;
                            counter = 1;
                            continue;
                        }
                    }

                    if (matrix[row][col] == matrix[row + 1][col - 1])
                    {
                        counter++;
                        isCounted = true;
                        if (counter >= bestCounter)
                        {
                            bestCounter = counter;
                            newRow = row;
                            newCol = col;
                            matrix[row][col] = null;

                            continue;
                        }
                        else
                        {
                            bestCounter = counter;
                            isCounted = false;
                            counter = 1;
                            continue;
                        }
                    }
                    if (matrix[row][col] == matrix[row + 1][col])
                    {
                        counter++;
                        isCounted = true;
                        if (counter >= bestCounter)
                        {
                            bestCounter = counter;
                            newRow = row;
                            newCol = col;
                            matrix[row][col] = null;

                            continue;
                        }
                        else
                        {
                            bestCounter = counter;
                            isCounted = false;
                            counter = 1;
                            
                            continue;
                        }
                    }
                    if (matrix[row][col] == matrix[row + 1][col + 1])
                    {
                        counter++;
                        isCounted = true;
                        if (counter >= bestCounter)
                        {
                            bestCounter = counter;
                            newRow = row;
                            newCol = col;
                            matrix[row][col] = null;

                            continue;
                        }
                        else
                        {
                            bestCounter = counter;
                            isCounted = false;
                            counter = 1;
                            
                            continue;
                        }
                    }
                    /*if (matrix[row - 1][col - 1] == matrix[row - 1][col])
                     {
                         counter++;
                         isCounted = true;
                         if (counter >= bestCounter)
                         {
                             bestCounter = counter;
                             newRow = row;
                             newCol = col;
                            matrix[row - 1][col- 1] = null;

                            continue;
                         }
                         else
                         {
                             bestCounter = counter;
                             isCounted = false;
                             counter = 1;
                             continue;
                         }
                     }
                     if (matrix[row - 1][col] == matrix[row - 1][col + 1])
                     {
                         counter++;
                         isCounted = true;
                         if (counter >= bestCounter)
                         {
                             bestCounter = counter;
                             newRow = row;
                             newCol = col;
                            matrix[row - 1][col] = null;

                            continue;
                         }
                         else
                         {
                             bestCounter = counter;
                             isCounted = false;
                             counter = 1;
                             
                             continue;
                         }
                     }
                     if (matrix[row - 1][col + 1] == matrix[row][col + 1])
                     {
                         counter++;
                         isCounted = true;
                         if (counter >= bestCounter)
                         {
                             bestCounter = counter;
                             newRow = row;
                             newCol = col;
                            matrix[row - 1][col + 1] = null;

                            continue;
                         }
                         else
                         {
                             bestCounter = counter;
                             isCounted = false;
                             counter = 1;
                             
                             continue;
                         }
                     }
                     if (matrix[row][col + 1] == matrix[row + 1][col + 1])
                     {
                         counter++;
                         isCounted = true;
                         if (counter >= bestCounter)
                         {
                             bestCounter = counter;
                             newRow = row;
                             newCol = col;
                            matrix[row][col + 1] = null;

                            continue;
                         }
                         else
                         {
                             bestCounter = counter;
                             isCounted = false;
                             counter = 1;
                            
                             continue;
                         }
                     }
                     if (matrix[row + 1][col + 1] == matrix[row + 1][col])
                     {
                         counter++;
                         isCounted = true;
                         if (counter >= bestCounter)
                         {
                             bestCounter = counter;
                             newRow = row;
                             newCol = col;
                            matrix[row + 1][col + 1] = null;

                            continue;
                         }
                         else
                         {
                             bestCounter = counter;
                             isCounted = false;
                             counter = 1;
                             continue;
                         }
                     }
                     if (matrix[row + 1][col] == matrix[row + 1][col - 1])
                     {
                         counter++;
                         isCounted = true;
                         if (counter >= bestCounter)
                         {
                             bestCounter = counter;
                             newRow = row;
                             newCol = col;
                            matrix[row + 1][col] = null;

                            continue;
                         }
                         else
                         {
                             bestCounter = counter;
                             isCounted = false;
                             counter = 1;
                             
                             continue;
                         }
                     }
                     if (matrix[row + 1][col - 1] == matrix[row][col - 1])
                     {
                         counter++;
                         isCounted = true;
                         if (counter >= bestCounter)
                         {
                             bestCounter = counter;
                             newRow = row;
                             newCol = col;
                            matrix[row + 1][col - 1] = null;

                            continue;
                         }
                         else
                         {
                             bestCounter = counter;
                             isCounted = false;
                             counter = 1;
                            
                             continue;
                         }
                     }
                     if (matrix[row][col - 1] == matrix[row + 1][col - 1])
                     {
                         counter++;
                         isCounted = true;
                         if (counter >= bestCounter)
                         {
                             bestCounter = counter;
                             newRow = row;
                             newCol = col;
                            matrix[row][col - 1] = null;

                            continue;
                         }
                         else
                         {
                             bestCounter = counter;
                             isCounted = false;
                             counter = 1;
                             
                             continue;
                         }

                     }
                    */
                }
            }
                        Console.WriteLine(bestCounter);
        }
    }
}
