// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.

// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixSumIndex(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)  // rows(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // columns(1)
        {
            matrix[i, j] = i + j;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine(" ]");
    }
}

int[,] createMatrixSumIndex= CreateMatrixSumIndex(m, n);
PrintMatrix(createMatrixSumIndex);
















