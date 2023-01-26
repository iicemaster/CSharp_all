/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("---------");
Console.WriteLine("Введите координаты первой точки");
Console.Write("Введите Х: "); 
int X_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: "); 
int Y_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: "); 
int Z_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("Введите Х: "); 
int XX_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: "); 
int YY_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: "); 
int ZZ_num = Convert.ToInt32(Console.ReadLine());
double Method1(int num1, int num2)
{
double res_m1 = Math.Pow((num1-num2),2);
return res_m1;
}
double result = (Math.Pow(Method1(X_num, XX_num) + Method1(Y_num, YY_num)+ Method1(Z_num, ZZ_num), 0.5));
Console.WriteLine($"Расстояние между точками: {result.ToString("0.00")}");
