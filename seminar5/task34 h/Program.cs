// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int size, int leftRange, int rightRange) 
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++ )
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}   
const int SIZE =5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 99;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(",", arr)); 


for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] <= 99 && arr[i] >= 1, arr.Length % 2 == 1)
    {
     res++;
    }
}
Console.WriteLine(res);
 