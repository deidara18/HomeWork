// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)
/*Console.WriteLine("Введите пятизначное число");
String num = Console.ReadLine()!;

if ((num.Length == 5))
{
int num1 = Convert.ToInt32(num[0]+num[1]);
int num2 = Convert.ToInt32(num[3]+num[4]);
    if (num1 == num2)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}*/


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*Console.WriteLine("Введите координаты xa");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты ya");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты za");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты xb");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты ya");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты zb");
int zb = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
Console.WriteLine($"{result:f3}");*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);

int m = 1;
if (n < 1)
{
    Console.WriteLine("Не правильно ввели N");
}
else
{
    while (m <= n)
    {
        Console.Write ($"{m * m * m}, ");
        m = m + 1;
    }
}