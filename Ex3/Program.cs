// See https://aka.ms/new-console-template for more information
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6, 7 - выходной.
//НО дня с индексом 0 или 12 не существует.

int n = Convert.ToInt32(Console.ReadLine());

if (n>=1 & n <=5)
{
Console.WriteLine("Нет");
}
else if (n == 6 | n == 7)
{
Console.WriteLine("Да");
}
else 
{
Console.WriteLine("Такого дня нет");
}
