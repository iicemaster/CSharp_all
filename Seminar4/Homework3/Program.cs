// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [1] {1};
Array.Resize<int>(ref numbers, length);
Random rnd = new Random();

for (int i=0; i<length; i++)
{
    numbers[i] = rnd.Next(1, 99);
    if (i == length-1) // просто для красоты
    {Console.Write($"{numbers[i]}");}
    else 
    {Console.Write($"{numbers[i]}, ");}
}
