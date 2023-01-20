// ВСЕ ЗАДАНИЯ ВЫПОЛНЕНЫ В НЕСКОЛЬКИХ ВАРИАНТА
// ВАРИАНТ ГДЕ ПОЛЬЗОВАТЕЛЬ МОЖЕТ САМОСТОЯТЕЛЬНО ВВЕСТИ ДАННЫЕ
// ВАРИАНТЫ ГДЕ ДАННЫЕ ЗАРАНЕЕ ИЗВЕСТНЫ
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

//Вариант с вводом данных через консоль
Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
Console.Write("Введите число:  ");
string A_num = Console.ReadLine();
int num = Convert.ToInt32(A_num);
if (num % 2 == 0) {Console.WriteLine($"{num} - Чётное число");}
else {Console.WriteLine($"{num} - Нечётное число");}

Console.WriteLine("Варианты с известными данными в переменных.");
Console.WriteLine("-------");

Console.WriteLine("Пример №1");
int num1 = 4;
if (num1 % 2 == 0) {Console.WriteLine($"{num1} - Чётное число");}
else {Console.WriteLine($"{num1} - Нечётное число");}
Console.WriteLine("-------");

Console.WriteLine("Пример №2");
int num2 = -3;
if (num2 % 2 == 0) {Console.WriteLine($"{num2} - Чётное число");}
else {Console.WriteLine($"{num2} - Нечётное число");}
Console.WriteLine("-------");

Console.WriteLine("Пример №3");
int num3 = 7;
if (num3 % 2 == 0) {Console.WriteLine($"{num3} - Чётное число");}
else {Console.WriteLine($"{num3} - Нечётное число");}