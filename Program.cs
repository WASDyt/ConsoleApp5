using System.Diagnostics;

class Program
{
    //метод для обмена элементов
    static void Swap(ref int a, ref int b)
    {
        var t = a;
        a = b;
        b = t;
    }
    // Шелл
    //static int[] ShellSort(int[] array)
    //{
    //    //расстояние между элементами, которые сравниваются
    //    var d = array.Length / 2;
    //    while (d >= 1)
    //    {
    //        for (var i = d; i < array.Length; i++)
    //        {
    //            var j = i;
    //            while ((j >= d) && (array[j - d] > array[j]))
    //            {
    //                Swap(ref array[j], ref array[j - d]);
    //                j = j - d;
    //            }
    //        }

    //        d = d / 2;
    //    }

    //    return array;
    //}

    //сортировка пузырьком
    //static int[] BubbleSort(int[] array)
    //{
    //    var len = array.Length;
    //    for (var i = 1; i < len; i++)
    //    {
    //        for (var j = 0; j < len - i; j++)
    //        {
    //            if (array[j] > array[j + 1])
    //            {
    //                Swap(ref array[j], ref array[j + 1]);
    //            }
    //        }
    //    }

    //    return array;
    //}

    //сортировка вставками
    static int[] InsertionSort(int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var key = array[i];
            var j = i;
            while ((j > 1) && (array[j - 1] > key))
            {
                Swap(ref array[j - 1], ref array[j]);
                j--;
            }

            array[j] = key;
        }

        return array;
    }

    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array1 = new int[100000];
        for (int i = 0; i < 100000; i++)
        {
            array1[i] = random.Next(-100000, 100000);
        }
        Console.WriteLine();
        Stopwatch stopwatch= new Stopwatch();
        stopwatch.Start();
        //int[] array2 = ShellSort(array1);
        //int[] array2 = BubbleSort(array1);
        int[] array2 = InsertionSort(array1);
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}