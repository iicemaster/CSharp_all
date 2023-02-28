// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int sumLine = 0;
int max = 0;
int columns = ConsoleImport("Введите количество столбцов(x): ");
Console.WriteLine();
int rows = ConsoleImport("Введите количество строк(y): ");
Console.WriteLine();
int[,] result = SumMatrix(FillMatrix(CreateMatrix(columns, rows)));
Console.WriteLine();
Console.WriteLine(max + 1);

int[,] SumMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowResult = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            rowResult = rowResult + matrix[i, j];
        }
        if (rowResult > sumLine)
        {
            sumLine = rowResult;
            max = i;
        }
    }
    return matrix;
}






int ConsoleImport(string input)
{
    Console.Write(input);
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

// Метод печати двумерной матрицы
int[,] PrintMatrix(int[,] matrix)
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



