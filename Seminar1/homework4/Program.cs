// ВСЕ ЗАДАНИЯ ВЫПОЛНЕНЫ В НЕСКОЛЬКИХ ВАРИАНТА
// ВАРИАНТ ГДЕ ПОЛЬЗОВАТЕЛЬ МОЖЕТ САМОСТОЯТЕЛЬНО ВВЕСТИ ДАННЫЕ
// ВАРИАНТЫ ГДЕ ДАННЫЕ ЗАРАНЕЕ ИЗВЕСТНЫ
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
Console.Write("Введите число:  ");
string N_num = Console.ReadLine();
int N = Convert.ToInt32(N_num);
int i = 0;
while (i <= N){
if (i % 2 == 0 && i != 0) {Console.Write ($"{i} "); i = i+1;}
else i = i + 1;
}
Console.WriteLine("");
Console.WriteLine("Варианты с известными данными в переменных.");
Console.WriteLine("Пример №1");
int N1 = 5;
int i1 = 0;
while (i1 <= N1){
if (i1 % 2 == 0 && i1 != 0) {Console.Write ($"{i1} "); i1 = i1+1;}
else i1 = i1 + 1;
}

Console.WriteLine("");
Console.WriteLine("Пример №2");
int N2 = 8;
int i2 = 0;
while (i2 <= N2){
if (i2 % 2 == 0 && i2 != 0) {Console.Write ($"{i2} "); i2 = i2+1;}
else i2 = i2 + 1;
}