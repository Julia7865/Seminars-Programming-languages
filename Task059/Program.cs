// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// Например задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// 5 2 6 7

// Наименьший элемент 1, на выходе получим слудующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
int[] arrayMin = IndexMinInMatrix(array2D);
PrintArray(arrayMin);
int[,] arrayDel = DeleteRowColumnMin(array2D, arrayMin);
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

int[] IndexMinInMatrix(int[,] matrix)
{
    int[] indexMin = new int[i];
    int minInMatrix = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < minInMatrix)
            {
                minInMatrix = matrix[i ,j];
                indexMin[0] = i;
                indexMin[1] = j;
            }
        }
    }
    return indexMin;
}

// int[,] DeleteRowColumnMin([,] matrix, int[] arr)
// {
//     int[,] newMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < length; i++)
//     {
        
//     }
// }

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}








































