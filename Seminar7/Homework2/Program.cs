// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// пользователь вводит индексы 10, 10 - такого элемента нет.
// пользователь вводите индексы 0, 2 - выводим элеменет 7


Console.WriteLine("Вариант с вводом данных через консоль");
Console.WriteLine("Сгенерируются случайный массив размером 10х10");
Console.WriteLine("-------");
Console.Write("Введите адресс ячейки массива(через запятую, точку или пробел) данные которой хотите получить: "); // Приводим разделители к одному виду а затем разделяем элементы.
string[] adress = Console.ReadLine().Replace(". ", " ").Replace(" .", " ").Replace(" ,", " ").Replace(", ", " ").Replace("  ", " ").Split(' '); 

double [,] numbers = new double [10, 10];
Random rnd = new Random();
int i, ii;
for (i=0, ii=0; ii<10; i++)
{
    if (i==10) 
    {
        ii=ii + 1; i=0; 
        if (ii<10)
        {
            double rand_num = rnd.NextDouble() * 198 - 99;
            numbers[i, ii] = Convert.ToDouble(rand_num.ToString("0.00"));
            //Console.Write($"{numbers[i, ii]}  ");
        }
    }
    else
    {
        double rand_num = rnd.NextDouble() * 198 - 99;
        numbers[i, ii] = Convert.ToDouble(rand_num.ToString("0.00"));
        if (i==(10-1))
        {
           //Console.WriteLine($"{numbers[i, ii]}  ");
        }
        else
        {
            //Console.Write($"{numbers[i, ii]}  ");
        }
    }
}
if ((Convert.ToInt32(adress[0]) <10) || (Convert.ToInt32(adress[1])<10))
{
    Console.Write($" жмых{numbers[(Convert.ToInt32(adress[0])), (Convert.ToInt32(adress[1]))]}  ");
}
else 
{
 Console.Write("Адресс ячейки вне диапазона, попробуйте внести адресс ячейки от 0 до 9(Включительно). \nПримеры: \n9 9 \n5, 7 \n 3. 2 ");
}