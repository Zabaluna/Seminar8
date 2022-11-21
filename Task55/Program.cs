// задача 55 Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (new Random().Next(-11, 11));
        }
    }
}

void ChengRow(int[,] matrix)
{
    int temp = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    const int cellWidth = 6;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i, j],cellWidth:f1}");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}




Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите колличество колонок: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrixFyrst = new int[rows, columns];

FillMatrix(matrixFyrst);
PrintMatrix(matrixFyrst);
Console.WriteLine();
Console.WriteLine();


if (matrixFyrst.GetLength(1) != matrixFyrst.GetLength(0))
{
    Console.Write($"невозможно");

}
else
{
    ChengRow(matrixFyrst);
    PrintMatrix(matrixFyrst);
}

