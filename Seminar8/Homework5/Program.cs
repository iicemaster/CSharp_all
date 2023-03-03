// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Тело задания
Console.Write("Введите количество столбцов(x): ");
int columns = ConsoleImport();
Console.WriteLine();
Console.Write("Введите количество строк(y): ");
int rows = ConsoleImport();
Console.WriteLine();
int[,] matrix1 = PrintMatrix(FillMatrix(CreateMatrix(columns, rows)));
Console.WriteLine();
int[,] matrix2 = PrintMatrix(FillMatrix(CreateMatrix(columns, rows)));
Console.WriteLine();
int[,] matrix3 = CreateMatrix(columns, rows);
matrix3 = PrintMatrix(MultiplierMatrix(matrix1, matrix2));

// Метод заполнения двумерной матрицы
int[,] FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
            //Console.Write($"{matrix[i, j]} ");
            Thread.Sleep(100);
        }
        //Console.WriteLine();
        Thread.Sleep(100);
    }
    return matrix;
}

// Метод получения данных из консоли формата int32
int ConsoleImport()
{
    bool result;
    int x;
    do
    {
        result = int.TryParse((Console.ReadLine()), out x);
        if (result == false) { Console.WriteLine("Вы ввели не число или число меньше 1. Попробуйте еще раз"); }
        else { break; }
    }
    while (result == false);
    return x;
}

// Метод создания двумерной матрицы
int[,] CreateMatrix(int columns, int rows)
{
    int[,] matrix = new int[rows, columns];
    return matrix;
}


// Метод печати двумерной матрицы
int [,] PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
            Thread.Sleep(100);
        }
        Console.WriteLine();
        Thread.Sleep(100);
    }
    return matrix;
}