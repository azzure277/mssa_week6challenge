namespace mssa_week6challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            RotateMatrix(matrix);

            // Print rotated matrix
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Rotates the n x n matrix by 90 degrees clockwise in place
        static void RotateMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            // Transpose the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
                }
            }

            // Reverse each row
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    (matrix[i, j], matrix[i, n - 1 - j]) = (matrix[i, n - 1 - j], matrix[i, j]);
                }
            }
        }
    }
}
