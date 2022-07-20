//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GenerateMatrix(int rows = 3, int columns = 4)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 9);
        }
    }
    return result;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] SortRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        int tmp = 0;
        while (j < array.GetLength(1) - 1)
        {
            if (array[i, j] > array[i, j + 1])
            {
                tmp = array[i, j + 1];
                array[i, j + 1] = array[i, j];
                array[i, j] = tmp;
                j = 0;
            }
            else
            {
                j++;
            }
        }
    }
    return array;
}

int[,] matrix = GenerateMatrix();
PrintArray(matrix);

Console.WriteLine();

int[,] sorted = SortRow(matrix);
PrintArray(sorted);