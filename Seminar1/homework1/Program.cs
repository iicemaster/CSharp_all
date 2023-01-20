//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Вариант с вводом данных через консоль
Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
Console.Write("Введите число A:  ");
string A_num = Console.ReadLine();
int A = Convert.ToInt32(A_num);
Console.Write("Введите число B:  ");
string B_num = Console.ReadLine();
int B = Convert.ToInt32(B_num);
if (A > B) {Console.WriteLine($"А({A}) больше В({B})");}
else {Console.WriteLine($"В({B}) больше А({A})");}

Console.WriteLine("Варианты с известными данными в переменных.");
// Варианты с известными данными в переменных.
// 1  - a = 5; b = 7 -> max = 7
Console.WriteLine("-------");
Console.WriteLine("Пример №1");
int aa = 5;
int bb = 7;
if (aa > bb) {Console.WriteLine($"A({aa}) больше B({bb})");}
else {Console.WriteLine($"В({bb}) больше А({aa})");}
// Дальше простая копипаста
// 2 - a = 2 b = 10 -> max = 10
Console.WriteLine("-------");
Console.WriteLine("Пример №2");
int aaa = 2;
int bbb = 10;
if (aaa > bbb) {Console.WriteLine($"A({aaa}) больше B({bbb})");}
else {Console.WriteLine($"В({bbb}) больше А({aaa})");}

// 3 - a = -9 b = -3 -> max = -3
Console.WriteLine("-------");
Console.WriteLine("Пример №3");
int aaaa = -9;
int bbbb = -3;
if (aaaa > bbbb) {Console.WriteLine($"A({aaaa}) больше B({bbbb})");}
else {Console.WriteLine($"В({bbbb}) больше А({aaaa})");}