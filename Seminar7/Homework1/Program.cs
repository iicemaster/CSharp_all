// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// Console.WriteLine("Вариант с вводом данных через консоль");
// Console.WriteLine("-------");
// Console.Write("m = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("n = ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [m, n];
// Random rnd = new Random();
// int i, ii;
// for (i=0, ii=0; ii<n; i++)
// {
//     if (i==m) 
//     {
//         ii=ii + 1; i=0; 
//         if (ii<n)
//         {
//             numbers[i, ii] = rnd.Next(1, 9);
//             Console.WriteLine($"\n{i}{ii}= {numbers[i, ii]}");
//         }
//     }
//     else{
//     numbers[i, ii] = rnd.Next(1, 9);
//     Console.WriteLine($"\n{i}{ii}= {numbers[i, ii]}");}
// }


// Console.WriteLine("Вариант с вводом данных через консоль");
// Console.WriteLine("-------");
// Console.Write("m = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("n = ");
// int n = Convert.ToInt32(Console.ReadLine());
// double [,] numbers = new double [m, n];
// Random rnd = new Random();
// int i, ii;
// for (i=0, ii=0; ii<n; i++)
// {
//     if (i==m) 
//     {
//         ii=ii + 1; i=0; 
//         if (ii<n)
//         {
//             double rand_num = rnd.NextDouble() * 40 - 20;
//             numbers[i, ii] = Convert.ToDouble(rand_num.ToString("0.00"));
//             Console.WriteLine($"{numbers[i, ii]} ");
//         }
//     }
//     else{
//     double rand_num = rnd.NextDouble() * 40 - 20;
//     numbers[i, ii] = Convert.ToDouble(rand_num.ToString("0.00"));
//     Console.Write($"{numbers[i, ii]} ");}
// }





Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("-------");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] numbers = new double [m, n];
Random rnd = new Random();
int i, ii;
for (i=0, ii=0; ii<n; i++)
{
    if (i==m) 
    {
        ii=ii + 1; i=0; 
        if (ii<n)
        {
            double rand_num = rnd.NextDouble() * 198 - 99;
            numbers[i, ii] = Convert.ToDouble(rand_num.ToString("0.00"));
            Console.Write($"{numbers[i, ii]}  ");
        }
    }
    else
    {
        double rand_num = rnd.NextDouble() * 198 - 99;
        numbers[i, ii] = Convert.ToDouble(rand_num.ToString("0.00"));
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