// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [m, n];
Random rnd = new Random();
int i, ii;
int count = 0;
double srednee = 0;
for (i=0, ii=0; ii<n; i++)
{
    if (i==m) 
    {
        ii=ii + 1; i=0; 
        if (ii<n)
        {
            numbers[i, ii] = rnd.Next(1, 9);
            Console.Write($"{numbers[i, ii]}  ");
        }
    }
    else{
    numbers[i, ii] = rnd.Next(1, 9);
    if (i==(m-1))
        {
            Console.WriteLine($"{numbers[i, ii]}  ");
        }
        else
        {
            Console.Write($"{numbers[i, ii]}  ");
        }
    }
}
for (i=0, ii=0; i<m;)
{
    if (ii<n)
    {
        srednee += numbers[i, ii];
        ii +=1;
    }
    else
    {
        srednee /= n;
        i += 1;
        Console.Write($"\nСреднее арифметическое столбца {i-1} = {(Convert.ToDouble(srednee.ToString("0.0")))}  ");
        srednee =0;
        ii = 0;
    }
} 
//Console.Write($"Среднее арифметическое каждого столбца{numbers[i, ii]}  ");
