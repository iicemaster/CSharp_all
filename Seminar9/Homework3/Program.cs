// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Тело задания
Console.WriteLine("Программа найдёт сумму натуральных элементов в промежутке между M и N(Включительно)");
int m = ConsoleImport("Введите число M: ");
int n = ConsoleImport("Введите число N: ");
Console.WriteLine(Akkerman(m, n));



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

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
