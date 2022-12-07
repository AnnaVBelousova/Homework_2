// See https://aka.ms/new-console-template for more information
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int n = Convert.ToInt32(Console.ReadLine());



if (n>=100)
{ 
n = n/100;
n = n%10;

Console.WriteLine(n);
}
else
{
Console.WriteLine("Третьей цифры нет");   
}
