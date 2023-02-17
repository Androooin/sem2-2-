// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


Console.WriteLine("введите целое число от 1 до 10");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7)
{
Console.WriteLine("Число болшее чем день недели");
}
else if (num == 6)Console.WriteLine("да, выходной");
else if(num == 7 ) Console.WriteLine("да, выходной");
else Console.WriteLine("нет, будни");


