/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
Console.Write("Введите число:  ");
string text = Console.ReadLine();
int N = text.Length; // длина строки
int n = N-1; // правим отсчёт индекса массива
int i; 
string n_reverse; 
char [] charStr = text.ToCharArray(); 
for (i = 0; i<=N-1; i++, n--)
     {charStr[n] = text[i];} // Пузырьковым методом по 1 символу переносим данные
 n_reverse = new string(charStr);
 if (text == n_reverse){Console.WriteLine("Является палиндромом");}
 else {Console.WriteLine("Не является палиндромом");}


// ВАРИАНТ С ИСПОЛЬЗОВАНИЕМ МЕТОДА Reverse();
Console.WriteLine("-------");
Console.WriteLine("Второй вариант, более короткий и без цикла.");
Console.Write("Введите число:  ");
string chartext22;
string text2 = Console.ReadLine();
char[] chartext2 = text2.ToCharArray();
Array.Reverse(chartext2); // reverse() Отражает переменную за одно действие.
chartext22 = new string(chartext2);
if (text2 == chartext22){Console.WriteLine("Является палиндромом");}
else {Console.WriteLine("Не является палиндромом");}