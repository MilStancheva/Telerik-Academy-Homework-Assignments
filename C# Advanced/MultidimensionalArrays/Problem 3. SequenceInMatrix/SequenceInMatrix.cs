using System;

namespace _03_Sequence_In_Matrix
{
    public class SequenceInMatrix
    {
        public static void Main()
        {
            string sizeInput = Console.ReadLine();

            string[] Sizes = sizeInput.Trim(' ').Split(' ');

            int rows = int.Parse(Sizes[0]);
            int cols = int.Parse(Sizes[1]);

            string[][] matrix = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Trim(' ').Split(' ');
            }

            
            int MaxSequence = 0;
            int CurSequence = 1;

            for (int row = 0; row < rows; row++)
            {
                CurSequence = 1;

                for (int col = 1; col < cols; col++)
                {
                    if (matrix[row][col] == matrix[row][col - 1])
                    {
                        CurSequence++;
                    }
                    else
                    {
                        if (CurSequence > MaxSequence)
                        {
                            MaxSequence = CurSequence;
                        }
                        
                        CurSequence = 1;
                    }
                }
                
                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }

            
            for (int col = 0; col < cols; col++)
            {
                
                CurSequence = 1;

                for (int row = 1; row < rows; row++)
                {
                    if (matrix[row][col] == matrix[row - 1][col])
                    {
                        CurSequence++;
                    }
                    else
                    {                        
                        if (CurSequence > MaxSequence)
                        {
                            MaxSequence = CurSequence;
                        }
                        
                        CurSequence = 1;
                    }
                }
                
                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }

            for (int Col = 1; Col < cols; Col++)
            {
                CurSequence = 1;

                for (int curMod = 1;curMod <= Math.Min(Col, rows - 1);curMod++)
                {
                    if (matrix[0 + curMod][Col - curMod] == matrix[0 + (curMod - 1)][Col - (curMod - 1)])
                    {
                        CurSequence++;
                    }
                }

                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }

            for (int Row = 1; Row < rows; Row++)
            {
                CurSequence = 1;

                for (int curMod = 1; curMod <= Math.Min(rows - 1 - Row - 1, cols - 2);curMod++)
                {
                    if (matrix[Row + curMod][(cols - 1) - curMod] ==
                        matrix[Row + (curMod + 1)][(cols - 1) - (curMod + 1)])
                    {
                        CurSequence++;
                    }
                }

                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }
            
            for (int Row = rows - 2; Row >= 0; Row--)
            {
                CurSequence = 1;

                for (int curMod = 1; curMod <= Math.Min(rows - Row - 1, cols - 1);curMod++)
                {
                    if (matrix[Row + curMod][0 + curMod] == matrix[Row + (curMod - 1)][0 + (curMod - 1)])
                    {
                        CurSequence++;
                    }
                }

                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }
            
            for (int Row = 1; Row < rows - 1; Row++)
            {
                CurSequence = 1;

                for (int curMod = 1;  curMod <= Math.Min(Row - 1, cols - 1); curMod++)
                {
                    if (matrix[Row - curMod][(cols - 1) - curMod] ==
                        matrix[Row - (curMod - 1)][(cols - 1) - (curMod - 1)])
                    {
                        CurSequence++;
                    }
                }

                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }
            
            Console.WriteLine(MaxSequence);
        }
    }
}