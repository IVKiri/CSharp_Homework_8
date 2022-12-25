// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int size = 4;
int[,] spiralMatrix = new int[size, size];

int row = 0;
int column = 0;
int num = 1;

while (num <= size * size)
{
    spiralMatrix[row, column] = num;
    num++;
    if (row <= column + 1 && row + column < size - 1)
    {
        column++;
    }
    else if (row < column && row + column >= size - 1)
    {
        row++;
    }
    else if (row >= column && row + column > size - 1)
    {
        column--;
    }
    else
    {
        row--;
    }

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (matrix[i, j] / 10 <= 0)
                Console.Write($" {matrix[i, j]} ");

            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(spiralMatrix);
