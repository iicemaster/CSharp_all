// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
string text = Console.ReadLine();
int i, temp;
for (i=0, temp=0; i<=text.Length-1; i++)
     {
        temp = temp + (int.Parse(text[i].ToString()));
     } // Пузырьковым методом по 1 символу переносим данные
Console.WriteLine($"Результат: {temp}");