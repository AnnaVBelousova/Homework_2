// See https://aka.ms/new-console-template for more information
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int n = Convert.ToInt32(Console.ReadLine());
n = n/10;
n = n%10;
Console.WriteLine(n);
