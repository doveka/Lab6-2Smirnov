{
    Console.ReadKey();
}

namespace MatrixLibrary
{
    public class MatrixOperations
    {
        public static int[] GetMinSumColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[] columnSums = new int[columns];

            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    columnSums[j] += matrix[i, j];
                }
            }

            int minSum = columnSums[0];
            int minSumIndex = 0;

            for (int j = 1; j < columns; j++)
            {
                if (columnSums[j] < minSum)
                {
                    minSum = columnSums[j];
                    minSumIndex = j;
                }
            }

            int[] minSumColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                minSumColumn[i] = matrix[i, minSumIndex];
            }

            return minSumColumn;
        }
    }
}