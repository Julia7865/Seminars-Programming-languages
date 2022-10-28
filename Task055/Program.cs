// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести сообщение для пользователя.

int[,] array2D = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

if (SizeEquality(array2D))
{
    int[,] changeRowsAndColumns = ChangeRowsAndColumns(array2D);
    PrintMatrix(changeRowsAndColumns);
}
else Console.WriteLine("Невозможно заменить строки на столбцы");

Console.WriteLine();
RewriteRowsToColumns(array2D);
PrintMatrix(array2D);


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  // rows(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // columns(1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}


int[,] ChangeRowsAndColumns(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[,] newMatrix = new int[size, size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}

bool SizeEquality(int[,] array2D)
{
    return array2D.GetLength(0) == array2D.GetLength(1);
}

void RewriteRowsToColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}









