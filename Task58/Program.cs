// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 6);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ResultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < 2; k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
            Console.Write(resultMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = FillMatrix(2, 2);
PrintMatrix(matrix1);
Console.WriteLine("----");
int[,] matrix2 = FillMatrix(2, 2);
PrintMatrix(matrix2);
Console.WriteLine("result");
ResultMatrix(matrix1, matrix2);
