﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// вводим через один Enter (разбиваем через Split())

Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("Примечание: программа работает только с целыми числами!");
Console.WriteLine("Примечание: рабочий пример: '10  11 13 -1. -2 .-3 ,-5.  6, 1' В результате отобразится 5 положительных чисел. ");
Console.WriteLine("Примечание: не рекомендуется специально создавать мусорные разделители. Пример: '1, .,2...3.'");
Console.WriteLine("-------");
Console.Write("Введите числа используя запятую, точку или пробел как разделитель. Можно использовать всё сразу: ");
int count = 0;
// Приводим разделители к одному виду а затем разделяем элементы.
string[] words = Console.ReadLine().Replace(". ", " ").Replace(" .", " ").Replace(" ,", " ").Replace(", ", " ").Replace("  ", " ").Split(' '); 
// в конечном итоге можно вводить элементы в удобном для пользователя варианте. в т.ч. даже если разделители будут разные
for (int i = 0; i<words.Length; i++)
{if (Convert.ToInt32(words[i]) > 0) {count += 1;}}
Console.WriteLine("\n-------");
Console.WriteLine($"Положительных чисел: {count}");