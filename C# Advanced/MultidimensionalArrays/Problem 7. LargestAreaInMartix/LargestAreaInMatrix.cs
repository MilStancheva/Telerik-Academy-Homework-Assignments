using System;
using System.Linq;

public class LargestAreaInMatrix
{
    public static void Main()
    {
        string dimentions = Console.ReadLine();

        var result = dimentions.Split(' ').Select(x => Convert.ToInt16(x)).ToArray();

        short rows = result[0];
        short cols = result[1];

        var matrix = new short?[rows][];

        for (short i = 0; i < rows; i++)
        {
            matrix[i] = new short?[cols];
        }

        for (short i = 0; i < rows; i++)
        {
            dimentions = null;
            dimentions = Console.ReadLine();
            result = dimentions.Split(' ').Select(z => Convert.ToInt16(z)).ToArray();
            dimentions = null;
            for (short j = 0; j < cols; j++)
            {
                matrix[i][j] = result[j];
            }
        }

        short max = 1;
        short counter = 0;
        short? curent;
        for (short i = 0; i < rows; i++)
        {
            for (short j = 0; j < cols; j++)
            {
                counter = 0;
                if (matrix[i][j] == null)
                {
                    continue;
                }
                else
                {
                    counter = 1;
                    curent = matrix[i][j];
                    matrix[i][j] = null;
                    counter = Finder(matrix, i, j, ref curent, ref counter);
                    if (counter > max)
                    {
                        max = counter;
                    }
                }

            }
        }

        Console.WriteLine(max);
    }

    static short Finder(short?[][] matrix, short row, short col, ref short? curent, ref short counter)
    {
        if (col > 0 && matrix[row][col - 1] == curent) //left
        {
            counter++;
            matrix[row][col - 1] = null;
            counter = Finder(matrix, row, (short)(col - 1), ref curent, ref counter);
        }

        if (row < matrix.Length - 1 && matrix[row + 1][col] == curent) //down
        {
            counter++;
            matrix[row + 1][col] = null;
            counter = Finder(matrix, (short)(row + 1), col, ref curent, ref counter);
        }

        if (col < matrix[row].Length - 1 && matrix[row][col + 1] == curent) //right
        {
            counter++;
            matrix[row][col + 1] = null;
            counter = Finder(matrix, row, (short)(col + 1), ref curent, ref counter);
        }

        if (row > 0 && matrix[row - 1][col] == curent) //up
        {
            counter++;
            matrix[row - 1][col] = null;
            counter = Finder(matrix, (short)(row - 1), col, ref curent, ref counter);
        }

        return counter;
    }
}