// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int digit = Convert.ToInt32(Console.ReadLine());

int mot1 = digit  / 10;
int mot2 = mot1 % 10;

Console.WriteLine($"Число = {mot2}");


