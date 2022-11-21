// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());

void PrintTwoDimArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
int[,] array = new int[row, column];

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
PrintTwoDimArray(array);

for (int i = 0; i < 1; i++)
{
    int temp;
    for (int j = 0; j < column; j++)
    {
        temp = array[i, j];
        array[i, j] = array[row-1, j];
        array[row-1, j] = temp;
    }
}
Console.WriteLine();
PrintTwoDimArray(array);
