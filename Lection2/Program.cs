// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int GetNumber()
{
int number = Convert.ToInt32(Console.ReadLine());
return number;
}

Console.Write("Введите число А: ");
int a = GetNumber();
Console.Write("Введите число B: ");
int b = GetNumber();

if (a / b == b) 
{
    Console.WriteLine($"Число {a} является квадратом {b}");
    }
else if (b / a == a){
    Console.WriteLine($"Число {b} является квадратом {a}");
    }
else {Console.WriteLine("Числа не являются квадратами");}