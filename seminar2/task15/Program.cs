//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели от 1 до 7");
int digit = Convert.ToInt32(Console.ReadLine());
if (digit == 6 || digit == 7)
{
 Console.WriteLine ("Этот день выходной");
}
else
if (digit < 7 || digit > 1)
{
 Console.WriteLine("Этот день рабочий, не выходной!");
}
if (digit > 7 || digit < 1)
{
    Console.WriteLine( "Нет такого дня в неделе! Число должно быть от 1 до 7");
}

