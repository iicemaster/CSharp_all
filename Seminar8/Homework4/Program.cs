// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System.Linq;

// Тело задания
Console.Write("Введите количество столбцов(x): ");
int columns = ConsoleImport();
Console.WriteLine();
Console.Write("Введите количество строк(y): ");
int rows = ConsoleImport();
Console.Write("Введите количество строк(z): ");
int zet = ConsoleImport();
Console.WriteLine();
// int[,] matrix1 = PrintMatrix(FillMatrix(CreateMatrix(columns, rows)));
// Console.WriteLine();
// int[,] matrix2 = PrintMatrix(FillMatrix(CreateMatrix(columns, rows)));
// Console.WriteLine();
int[,,] matrix = FillMatrix(CreateMatrix(columns, rows, zet));
// matrix3 = PrintMatrix(MultiplierMatrix(matrix1, matrix2));

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

// Метод создания трёхмерной матрицы
int[,,] CreateMatrix(int columns, int rows, int zet)
{
    int[,,] matrix = new int[rows, columns, zet];
    return matrix;
}

// Метод заполнения трёхмерной матрицы
int[,,] FillMatrix(int[,,] matrix)
{
    for (int z = 0; z < matrix.GetLength(2); z++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j, z] = NewNumber(matrix);
                Console.Write($"{matrix[i, j, z]}({i},{j},{z}) ");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Thread.Sleep(100);
        }
    }
    return matrix;
}

//Проверка каждого элемента массива
int NewNumber(int[,,] matrix)
{
    Random rnd = new Random();
    int randomNum = rnd.Next(10, 99);
    foreach (int number in matrix)
    {
        if (number == randomNum)
        {
            //Console.Write("!");
            randomNum = NewNumber(matrix);
        }
    }
    return randomNum;
}

// int NewNumber(int[,,] matrix)
// {
// Random rnd = new Random();
// int randomNum = rnd.Next(10, 99);
// if (matrix.Contains(randomNum))
// {
//     Console.WriteLine(string.Format("Слово '{0}' содержится в массиве", name));
//     // to do something...
// }
// return randomNum;
// }