// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:

// 18 20
// 15 18


int[,] array1 = CreateMatrixRndInt(2, 3, 1, 5);
PrintMatrix(array1);
Console.WriteLine();
int[,] array2 = CreateMatrixRndInt(3, 2, 1, 5);
PrintMatrix(array2);
int[,] multiMatrix = MatrixMultiplic(array1, array2);
Console.WriteLine("Результирующая матрица: ");
PrintMatrix(multiMatrix);


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

int[,] MatrixMultiplic(int[,] arr1, int[,] arr2)
{
    int[,] multiMatrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < multiMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                multiMatrix[i,j] += arr1[i, k] * arr2[k, j];
            }
        }
    } 
    return multiMatrix;
}















