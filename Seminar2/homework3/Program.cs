﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Вариант с обработкой данных от пользователя");
Console.WriteLine("---------");
Console.Write("Введите цифру обозначающую день недели(от 1 до 7): "); 
string A_num = Console.ReadLine();
// int A = Convert.ToInt32(A_num);  - Конвертация не обязательна т.к. не происходит никаких вычислений.
int A = Convert.ToInt32(A_num);

if (A==6 || A==7)
{Console.WriteLine("Да, это выходной день");}
else if (A<6) {Console.WriteLine("Нет, это не выходной день");}
else {Console.WriteLine("Вы ввели число превышающее количество дней в неделе! Попробуйте еще раз.");}