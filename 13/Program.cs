// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.WriteLine("Введите целое  число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    if (num < 1000)
    {
        int result = num % 10;
        Console.WriteLine(result);
    }
}
else
{
    Console.WriteLine("третьей цифры нет");
}
if (num > 999)
{
    if (num < 10000)
    {
        int result = num % 100 / 10;
        Console.WriteLine(result);

    }
}
if (num > 9999)
{
    if (num < 100000)
    {
        int result = num % 1000 / 100;
        Console.WriteLine(result);

    }
}
if (num > 99999)
{
    if (num < 1000000)
    {
        int result = num % 10000 / 100 % 10;
        Console.WriteLine(result);

    }
}
if (num > 999999)
{
    Console.WriteLine("Вы ввели слишком большое число");
}