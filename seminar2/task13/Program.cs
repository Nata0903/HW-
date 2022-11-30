//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());
int [] array = {digit};
array[0] = digit;
Console.WriteLine(array[3]);


