// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//

// Тело задания
int result = 0;
Console.WriteLine("Программа найдёт сумму натуральных элементов в промежутке между M и N(Включительно)");
int m = ConsoleImport("Введите число M: ");
int n = ConsoleImport("Введите число N: ");
Console.WriteLine();
NaturalNumbers(m, n);


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

// Метод Суммы натуральных чисел в заданном промежутке
void NaturalNumbers(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        result += numberN;
        numberN += 1;
        NaturalNumbers(numberM, numberN);
    }
    else if (numberN > numberM)
    {
        result += numberM;
        numberM += 1;
        NaturalNumbers(numberM, numberN);
    }
    else 
    {
        result += numberM;
        Console.WriteLine($"Сумма натуральных числен в промежутке между {m} и {n} (Включительно): {result}");
    }


}
