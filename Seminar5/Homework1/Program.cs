// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [1] {1};
Array.Resize<int>(ref numbers, length);
Random rnd = new Random();
int i, count;
for (i=0, count=0; i<length; i++)
{
    numbers[i] = rnd.Next(100, 999);
    Console.Write($"{numbers[i]} ");
    if (numbers[i] % 2==1) // проверка на чётность
    {count+=1;}
}
//Console.WriteLine("");
Console.WriteLine($"\nЧётных чисел: {count}");