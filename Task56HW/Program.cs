// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет 
//  находить строку с наименьшей суммой элементов.


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetResultArray(int[,] array)
{
    int minSumRow = 0;
    int minSum = 0;
    int sum = 0;

    for (int j = 0; j < columns; j++)
    {
        minSum += array[0, j];

    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
        sum = 0;
    }
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"|{array[minSumRow, j]}");
    }
    Console.WriteLine($"|-> Cторка с минимальной суммой номер {minSumRow + 1}");

}

Console.WriteLine();
GetResultArray(array);