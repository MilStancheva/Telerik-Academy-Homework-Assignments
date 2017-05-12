namespace _12.QueensPuzzle
{
    public class QueenPuzzleSolver
    {
        private byte[,] queens;
        private int count = 0;

        public QueenPuzzleSolver(int size)
        {
            this.queens = new byte[size, size];
        }

        public int FindAllSolutions()
        {
            Recursions(0);
            return this.count;
        }

        private void Recursions(int row)
        {
            if (row == this.queens.GetLength(1))
            {
                this.count++;
                return;
            }

            for (int col = 0; col < this.queens.GetLength(0); col++)
            {
                if (this.queens[row, col] == 0)
                {
                    MarkQueen(row, col);
                    this.Recursions(row + 1);
                    UnMarkQueen(row, col);
                }

            }
        }

        private void UnMarkQueen(int row, int col)
        {
            for (int i = row; i < this.queens.GetLength(0); i++)
            {
                this.queens[i, col] -= 1;

                if (col + (i - row) < this.queens.GetLength(0))
                {
                    this.queens[i, col + (i - row)] -= 1;
                }

                if (col - (i - row) >= 0)
                {
                    this.queens[i, col - (i - row)] -= 1;
                }

            }
        }

        private void MarkQueen(int row, int col)
        {
            for (int i = row; i < this.queens.GetLength(0); i++)
            {
                this.queens[i, col] += 1;

                if (col + (i - row) < this.queens.GetLength(0))
                {
                    this.queens[i, col + (i - row)] += 1;
                }

                if (col - (i - row) >= 0)
                {
                    this.queens[i, col - (i - row)] += 1;
                }
            }
        }
    }
}