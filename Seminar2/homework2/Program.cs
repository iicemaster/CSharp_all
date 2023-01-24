//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.WriteLine("Вариант с обработкой данных от пользователя");
Console.WriteLine("---------");
Console.Write("Введите число: "); 
string A_num = Console.ReadLine();
// int A = Convert.ToInt32(A_num);  - Конвертация не обязательна т.к. не происходит никаких вычислений.
int L = A_num.Length;
int i;
if (L>=3)
{
   for (i = 0; i < L; i++)
   {
       if (i == 2) {Console.WriteLine($"Третий символ: {A_num[i]}. Всего символов: {L}");}
   }
}
else {Console.WriteLine($"Третьей цифры нет. Всего символов: {L}");}

Console.WriteLine("Вариант с заранее известным числом");
Console.WriteLine("---------");
Console.WriteLine("Задание №1");
string A_num1 = "645";
int L1 = A_num1.Length;
if (L1>=3)
{
    for (i=0; i < L1; i++)
    {
        if (i == 2) {Console.WriteLine($"Третий символ: {A_num1[i]}. Всего символов: {L1}");}
    }
}
else {Console.WriteLine($"Третьей цифры нет. Всего символов: {L1}");}

Console.WriteLine("---------");
Console.WriteLine("Задание №2");
string A_num2 = "78";
int L2 = A_num2.Length;
if (L2>=3)
{
    for (i=0; i < L2; i++)
    {
        if (i == 2) {Console.WriteLine($"Третий символ: {A_num1[i]}. Всего символов: {L2}");}
    }
}
else {Console.WriteLine($"Третьей цифры нет. Всего символов: {L2}");}

Console.WriteLine("---------");
Console.WriteLine("Задание №3");
string A_num3 = "32679";
int L3 = A_num3.Length;
if (L3>=3)
{
    for (i=0; i < L3; i++)
    {
        if (i == 2) {Console.WriteLine($"Третий символ: {A_num3[i]}. Всего символов: {L3}");}
    }
}
else {Console.WriteLine($"Третьей цифры нет. Всего символов: {L3}");}