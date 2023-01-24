//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Вариант с обработкой данных от пользователя");
Console.WriteLine("---------");
Console.Write("Введите число: "); 
string A_num = Console.ReadLine();
// int A = Convert.ToInt32(A_num);  - Конвертация не обязательна т.к. не происходит никаких вычислений.
int L = A_num.Length;
int i;
for (i = 0; i < L; i++)
{
    if (i == 1) {Console.WriteLine($"Второй символ: {A_num[i]}");}
}
Console.WriteLine($"Всего символов: {L}");

Console.WriteLine("---------");
Console.WriteLine("Задание №1");
string A_num1 = "456";
int L1 = A_num1.Length;
for (i = 0; i < L1; i++)
{
    if (i == 1) {Console.WriteLine($"Второй символ: {A_num1[i]}. Всего символов: {L1}");}
}

Console.WriteLine("---------");
Console.WriteLine("Задание №2");
string A_num2 = "782";
int L2 = A_num2.Length;
for (i=0; i<L2; i++)
{
    if (i == 1) {Console.WriteLine($"Второй символ: {A_num2[i]}. Всего символов: {L2}");}
}

Console.WriteLine("---------");
Console.WriteLine("Задание №3");
string A_num3 = "918";
int L3 = A_num3.Length;
for (i=0; i<L3; i++)
{
    if (i == 1) {Console.WriteLine($"Второй символ: {A_num3[i]}. Всего символов: {L3}");}
}