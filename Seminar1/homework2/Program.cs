//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Вариант с вводом данных через консоль
Console.WriteLine("Вариант с вводом данных через консоль");
// --------
Console.Write("Введите число A:  ");
string A_num = Console.ReadLine();
int A = Convert.ToInt32(A_num);
// --------
Console.Write("Введите число B:  ");
string B_num = Console.ReadLine();
int B = Convert.ToInt32(B_num);
// --------
Console.Write("Введите число C:  ");
string C_num = Console.ReadLine();
int C = Convert.ToInt32(C_num);
// --------
int max=0, max1=0, max2=0, max3=0;
if (A > max) {max = A;}
if (B > max) {max = B;}
if (C > max) {max = C;}
Console.WriteLine($"Max = {max}");

Console.WriteLine("Варианты с известными данными в переменных.");
// Варианты с известными данными в переменных.
// 1  - 2, 3, 7 -> 7
Console.WriteLine("Пример №1");
int aa = 2;
int bb = 3;
int cc = 7;
if (aa > max1) {max1 = aa;}
if (bb > max1) {max1 = bb;}
if (cc > max1) {max1 = cc;}
Console.WriteLine($"Max = {max1}");

// Дальше простая копипаста
// 2 - 44 5 78 -> 78

Console.WriteLine("Пример №2");
int aaa = 44;
int bbb = 5;
int ccc = 78;
if (aaa > max2) {max2 = aaa;}
if (bbb > max2) {max2 = bbb;}
if (ccc > max2) {max2 = ccc;}
Console.WriteLine($"Max = {max2}");

// 3 - 22 3 9 -> 22

Console.WriteLine("Пример №3");
int aaaa = 22;
int bbbb = 3;
int cccc = 9;
if (aaaa > max3) {max3 = aaaa;}
if (bbbb > max3) {max3 = bbbb;}
if (cccc > max3) {max3 = cccc;}
Console.WriteLine($"Max = {max3}");

