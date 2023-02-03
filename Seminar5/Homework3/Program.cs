// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
Console.Write("Введите количество элементов массива: ");
double min = 999.99;
double max = 0;
int length = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double [1] {1};
Array.Resize<double>(ref numbers, length);
Random rnd = new Random();

for (int i=0; i<length; i++)
{ 
    double rand_num = rnd.NextDouble() * (999 - 1) + 1;
    numbers[i] = Convert.ToDouble(rand_num.ToString("0.00"));
    if (i == length-1)
    {Console.Write($"{numbers[i]}");
       if (numbers[i] > max){max=numbers[i];}
       if (numbers[i]< min){min=numbers[i];}
    }
    else 
    {Console.Write($"{numbers[i]}, ");
       if (numbers[i] > max){max=numbers[i];}
       if (numbers[i] < min){min=numbers[i];}
    }
}

Console.WriteLine("\n-------");
Console.WriteLine($"Max = {max} \nMin = {min}  \nРазница между Min и Max значениями массива = {max-min} ");
// Max - min = result = print