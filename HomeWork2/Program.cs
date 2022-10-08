/*//                                      Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

if (number > 100 && number < 1000) // Нужен промежуток 100 и 999
{
    Console.WriteLine("Трех значное число");
}
else
{
    Console.WriteLine("Ошибка, введите трёхзначное число");

}
int num1 = number/10; 
int num2 = num1%10;
Console.WriteLine($" {num2}");*/

/*// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
if (number < 100)
{
    Console.WriteLine($"{number}");
    return;
}
int num1 = 0;
if (number > 99 && number < 1000)
{
    num1 = (number % 100) % 10;
}
if (number > 999 && number < 10000)
{
    num1 = (number % 100) / 10;
}
if (number > 9999 && number < 100000)
{
    num1 = (number % 1000) / 100;
}
Console.WriteLine($"Третья цифра {num1}");*/

//  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательно сделать проверку на ввод чисел меньше 1 и больше 7
Console.WriteLine("Введите день недели");
int number = int.Parse(Console.ReadLine()!);

if (number < 1 && number > 7){
Console.WriteLine($"День недели  = {number}");

if (number > 5 && number < 8 ){
    Console.WriteLine("Выходной день");
    }
else{
    Console.WriteLine("Будний день");
    }
}
else{
    Console.WriteLine("Ошибка ввода");
    } 
 
