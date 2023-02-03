// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [1] {1};
Array.Resize<int>(ref numbers, length);
Random rnd = new Random();
int i, result;
for (i=0, result=0; i<length; i++)
{
    numbers[i] = rnd.Next(1, 999);
    Console.Write($"{numbers[i]} ");
    if (numbers[i] % 2 == 1) // проверка на чётность
    {result = result+numbers[i];}
}
//Console.WriteLine("");
Console.WriteLine($"\nСумма нечетных чисел: {result}");