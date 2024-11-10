namespace dz_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // task 1. 
            Console.WriteLine("Транспонированная матрица:");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(matrix[j, i] + "\t");
                }
                Console.WriteLine();
            }

            // task 2.
            int min = matrix[0, 0];
            int max = matrix[0, 0];
            foreach (int element in matrix)
            {
                if (element < min) min = element;
                if (element > max) max = element;
            }
            Console.WriteLine($"\nМинимум: {min}, Максимум: {max}");

            // task 3. 
            Console.WriteLine("\nРезультат умножения матриц:");
            int[,] result = new int[rows, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols; k++)
                    {
                        result[i, j] += matrix[i, k] * matrix[k, j];
                    }
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // task 4. 
            Console.WriteLine("\nСумма по строкам и столбцам:");
            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;
                int colSum = 0;
                for (int j = 0; j < cols; j++)
                {
                    rowSum += matrix[i, j];
                    colSum += matrix[j, i];
                }
                Console.WriteLine($"Строка {i + 1}: {rowSum}, Столбец {i + 1}: {colSum}");
            }

            // task 5. 
            Console.WriteLine("\nМатрица после сортировки строк по сумме элементов:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    int sumI = 0, sumJ = 0;
                    for (int k = 0; k < cols; k++)
                    {
                        sumI += matrix[i, k];
                        sumJ += matrix[j, k];
                    }
                    if (sumI > sumJ)
                    {
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[j, k];
                            matrix[j, k] = temp;
                        }
                    }
                }
            }
            PrintMatrix(matrix);

            // task 6. 
            Console.WriteLine("\nМаксимальные элементы в каждой строке:");
            for (int i = 0; i < rows; i++)
            {
                int maxInRow = matrix[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] > maxInRow)
                        maxInRow = matrix[i, j];
                }
                Console.WriteLine($"Строка {i + 1}: {maxInRow}");
            }

            // task 7. 
            bool isSymmetric = true;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        isSymmetric = false;
                        break;
                    }
                }
                if (!isSymmetric) break;
            }
            Console.WriteLine("\nМатрица симметрична? " + (isSymmetric ? "Да" : "Нет"));

            // task 8. 
            Console.WriteLine("\nРезультат сложения матрицы с собой:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write((matrix[i, j] + matrix[i, j]) + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
