// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int m, n, range;

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

int SumElements(int[,] array, int i)
{
  int sumonline = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumonline += array[i,j];
  }
  return sumonline;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
m = ConsoleImport("Введите m: ");
n = ConsoleImport("Введите n: ");
range = ConsoleImport("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minsum = 0;
int sumonline = SumElements(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
  int TempSum = SumElements(array, i);
  if (sumonline > TempSum)
  {
    sumonline = TempSum;
    minsum = i;
  }
}

Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minsum+1}. Сумма = {sumonline} ");


