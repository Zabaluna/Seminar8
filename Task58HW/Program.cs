// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.

Console.Write("Введите количество строк массива A: ");
int rowsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива A: ");
int columnsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк массива B: ");
int rowsB = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива B: ");
int columnsB = int.Parse(Console.ReadLine());

if(columnsA!=rowsB)
{
  Console.Write("Такие матрицы нельзя перемножить.Попробуйте заново ввести данные "); 
  return; 
}

int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);

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

int[,] MultiplicationABarray(int[,]arrayA, int[,]arrayB)
{
    int[,] resultmatrix = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                resultmatrix[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return resultmatrix;
}
Console.WriteLine("Результат умножения матриц:");
PrintArray(MultiplicationABarray(A,B));


// 8 4  10 5
// 6 2  3 10
// 8*10 + 4*3   8*5+ 4*10  92 80
// 6*10+ 2*3   6*5 + 2*10  66 50