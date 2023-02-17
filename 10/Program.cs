//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine("Введите целое трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)Console.WriteLine("Вы ввели не трехзначное число");
else if( num > 999)Console.WriteLine("Вы ввели не трехзначное число");
else
{
int result = num / 10 % 10;
Console.WriteLine(result);
}