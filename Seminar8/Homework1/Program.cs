// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
int[,] CreateMatrix(int x, int y)
{
    int[,] matrix = new int[x, y];
    return matrix;
}
// Метод заполнения двумерной матрицы
//
int[,] FillMatrix(int[,] matrix, int x, int y)
{
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j<y; j++)
        {
            matrix [i,j] = rnd.Next(1, 10);
            Console.Write($"{matrix[i,j]} ");
            Thread.Sleep(500);
        }
        Console.WriteLine();
        Thread.Sleep(500);
    }
return matrix;
}

// int SortMatrix()
// {
// }



Console.Write("Введите количество столбцов(x): ");
int x = ConsoleImport();
Console.WriteLine();
Console.Write("Введите количество строк(y): ");
int y = ConsoleImport();
Console.WriteLine();
//Console.WriteLine($"Ваше число x: {x}, y: {y}");



int[,] anal = FillMatrix(CreateMatrix(x, y), x, y);

//Console.WriteLine(anal[7, 7]);