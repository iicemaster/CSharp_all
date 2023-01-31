// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("---------");
Console.WriteLine("Операция возведения в степень. Число A Возводится в степень B");
Console.Write("Введите число A: "); 
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: "); 
int b = Convert.ToInt32(Console.ReadLine());
double res = Math.Pow(a, b);
Console.WriteLine($"{a} в степени {b} = {res}");