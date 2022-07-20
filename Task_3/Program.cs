//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GenerateMatrix(int rows = 3, int columns = 3)
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
int[,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] resMass = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
        for (int j = 0; j < arrayB.GetLength(1); j++)
            for (int k = 0; k < arrayA.GetLength(1); k++)
                resMass[i, j] += arrayA[i, k] * arrayB[k, j];

    return resMass;
}

int[,] matrixA = GenerateMatrix();
int[,] matrixB = GenerateMatrix();
if (matrixA.GetLength(1) == matrixB.GetLength(0))
{
    int[,] matrixC = MultiplicationMatrix(matrixA, matrixB);
    PrintArray(matrixA);
    System.Console.WriteLine("\t X");
    PrintArray(matrixB);
    System.Console.WriteLine("\t =");
    PrintArray(matrixC);
}
else System.Console.WriteLine("The numbers of columns of the first matrix must be equal to the numbers of rows of the first matrix. ");

