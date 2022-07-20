//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int MinSummaInRow(int[,] arr)
{
    int minSumma = 0;
    int answer = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumInRow = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumInRow = sumInRow + arr[i, j];
        }

        if (minSumma == 0)
        {
            minSumma = sumInRow;
        }
        if (minSumma > sumInRow)
        {
            minSumma = sumInRow;
            answer = i + 1;
        }
    }
    return answer;
}

int Promt(string message)
{
    System.Console.Write(message);
    int ret = int.Parse(Console.ReadLine());
    return ret;
}


int rows = Promt("Enter a number of rows: ");
int columns = Promt("Eneter a number of columns: ");
if (rows != columns)
{
    int[,] matrix = GenerateMatrix(rows, columns);
    PrintArray(matrix);

    Console.WriteLine();

    int minInRow = MinSummaInRow(matrix);
    Console.WriteLine($"Minimum total in {minInRow} row");
}
else System.Console.WriteLine("Array isn't rectangle! Please try again.");