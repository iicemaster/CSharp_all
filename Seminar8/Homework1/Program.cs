// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Тело задания
Console.Write("Введите количество столбцов(x): ");
int columns = ConsoleImport();
Console.WriteLine();
Console.Write("Введите количество строк(y): ");
int rows = ConsoleImport();
Console.WriteLine();
int[,] result = PrintMatrix(SortMatrix(FillMatrix(CreateMatrix(columns, rows))));


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

// Метод заполнения двумерной матрицы
int[,] FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
            Thread.Sleep(100);
        }
        Console.WriteLine();
        Thread.Sleep(100);
    }
    return matrix;
}
// Метод сортировки двумерной матрицы
int[,] SortMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int count = 0; count < columns; count++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i, j - 1])
                {
                    (matrix[i, j], matrix[i, j - 1]) = (matrix[i, j - 1], matrix[i, j]);
                }
               
            }
        }   
    }
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