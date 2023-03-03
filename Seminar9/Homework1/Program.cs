// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Тело задания
int n = ConsoleImport("Введите число N(Программа выведет все натуральные числа в промужутке от N до 1): "); ;
Console.WriteLine();
NaturalNumbers(n);

// Метод получения данных из консоли формата int32
int ConsoleImport(string input)
{
    Console.Write(input);
    bool result;
    int x;
    do
    {
        result = int.TryParse((Console.ReadLine()), out x);
        if (result == false) { Console.WriteLine("Вы ввели не число или число меньше 1. Попробуйте еще раз"); }
        else { break; }
    }
    while (result == false);
    return x;
}

// Метод вывода натуральных чисел в заданном промежутке
void NaturalNumbers(int number)
{
    if (number == 1) { Console.Write($"{number}"); }
    else { Console.Write($"{number}, "); }
    number = number - 1;
    if (number >= 1)
    {
        NaturalNumbers(number);
    }
}