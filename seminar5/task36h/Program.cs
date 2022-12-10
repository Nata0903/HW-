//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

   int sum = 0;

    for (int i = 0, i < array.Length; i++)
    {
      if (i /2 && array[i] > 0) 
      {
        i++;
      }
      else
      {
        sum = sum + array[i];
      }
    }
    return (sum);



const int SIZE = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(",", arr)); 
(int sum) = GetSumPositiveAndNegative(array);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях, равна  {sum}");
