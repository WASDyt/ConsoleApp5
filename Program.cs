using System;
//public class Example
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите количество чисел");
//        int N = int.Parse(Console.ReadLine());
//        int[] arr = new int[N];
//        Random random = new Random();

//        for (int i = 0; i < N; i++)
//            arr[i] = random.Next(-100, 100);

//        Console.WriteLine("Сортировка выбором");
//        Console.Write("Исходный массив: ");
//        for (int i = 0; i < N; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        int temp, smallest;
//        for (int i = 0; i < N - 1; i++)
//        {
//            smallest = i;
//            for (int j = i + 1; j < N; j++)
//            {
//                if (arr[j] < arr[smallest])
//                {
//                    smallest = j;
//                }
//            }
//            temp = arr[smallest];
//            arr[smallest] = arr[i];
//            arr[i] = temp;
//        }
//        Console.WriteLine();
//        Console.Write("Отсортированный массив: ");
//        for (int i = 0; i < N; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//    }
//}
static int[] shellSort(int[] array)
{
    var length = array.Length;
    var h = 1;
    while (h < length / 3)
    {
        h = 3 * h + 1;
    }
    while (h > 0)
    {
        for (var i = h; i < length; i++)
        {
            for (var j = i; j > 0 && array[j] < array[j - h]; j -= h)
            {
                {
                    var x = array[j];
                    array[j] = array[j - h];
                    array[j - h] = x;
                }
            }
        }
        h = -h / 3;
    }
    return array;
}
Random random = new Random();
int[] array1 = new int[100];
for (int i = 0; i < 100; i++)
{ array1[i] = random.Next(-100, 100); }
Console.WriteLine("Исходный массив");
foreach(int arr in array1)
    Console.WriteLine($"{arr}");
Console.WriteLine();
int[] array2 = shellSort(array1);
Console.WriteLine("Сортированный массив");
foreach (int arr in array2)
    Console.WriteLine($"{arr}");
Console.WriteLine() ;