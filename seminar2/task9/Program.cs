//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine(number);
int digit2 = number % 10;
int digit1 = number / 10;
Console.WriteLine($"Первая цифра = {digit1}, вторая цифрв = { digit2}");
if (digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else
{
    Console.WriteLine(digit2);
}
