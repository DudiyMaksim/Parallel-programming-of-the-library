using System;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void DisplayDateTime()
    {
        Console.WriteLine($"Date and time right now: {DateTime.Now}");
    }

    static void Printsimple()
    {
        for (int i = 2; i <= 1000; i++)
        {
            bool isSimple = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isSimple = false;
                    break;
                }
            }

            if (isSimple)
            {
                Console.Write($"{i}, ");
            }
        }
    }

    static void Printsimple(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            bool isSimple = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isSimple = false;
                    break;
                }
            }

            if (isSimple)
            {
                Console.Write($"{i}, ");
            }
        }
    }


    static void Main(string[] args)
    {
        ////task 1
        //Task task1 = new Task(DisplayDateTime);
        //task1.Start();

        //Task task2 = Task.Factory.StartNew(DisplayDateTime);

        //Task task3 = Task.Run(DisplayDateTime);

        //Task.WaitAll(task1, task2, task3);

        //Console.WriteLine("Усі завдання завершено.");
        ////task 2
        //Task task2 = Task.Run(Printsimple);
        //Task.WaitAll(task2);
        //Console.WriteLine("\nAll tasks were completed");
        ////task 3
        //Task task1 = Task.Run(() => Printsimple(0, 100));
        //Task.WaitAll(task1);
        //Console.WriteLine("\nAll tasks were completed");
        ////task 4
        //int[] arr = new int[10] { 25, 21, 84, 46, 4, 34, 96, 57, 5, 37 };
        //Console.WriteLine("Масив:");
        //Console.WriteLine(string.Join(", ", arr));

        //Task<int> findMinTask = Task.Run(() => arr.Min());
        //Task<int> findMaxTask = Task.Run(() => arr.Max());
        //Task<double> findAvgTask = Task.Run(() => arr.Average());
        //Task<int> findSumTask = Task.Run(() => arr.Sum());

        //Task[] tasks = { findMinTask, findMaxTask, findAvgTask, findSumTask };

        //Task.WaitAll(tasks);

        //Console.WriteLine($"Min: {findMinTask.Result}");
        //Console.WriteLine($"Max: {findMaxTask.Result}");
        //Console.WriteLine($"Average: {findAvgTask.Result:F2}");
        //Console.WriteLine($"Sum: {findSumTask.Result}");
        ////task 5
        //int[] array = { 5, 3, 8, 5, 2, 8, 1, 3, 9, 2, 7 };

        //Task<int[]> removeDuplicatesTask = Task.Run(() =>
        //{
        //    return array.Distinct().ToArray();
        //});

        //Task<int[]> sortTask = removeDuplicatesTask.ContinueWith(prevTask =>
        //{
        //    var distinctArray = prevTask.Result;
        //    Array.Sort(distinctArray);
        //    return distinctArray;
        //});

        //Task<int> binarySearchTask = sortTask.ContinueWith(prevTask =>
        //{
        //    var sortedArray = prevTask.Result;
        //    Console.WriteLine("\nSorted array with deleted :");
        //    Console.WriteLine(string.Join(", ", sortedArray));

        //    Console.Write("\nEnter value for searching: ");
        //    int value = int.Parse(Console.ReadLine());

        //    int index = Array.BinarySearch(sortedArray, value);
        //    return index >= 0 ? index : -1;
        //});

        //binarySearchTask.ContinueWith(prevTask =>
        //{
        //    int searchResult = prevTask.Result;
        //    if (searchResult != -1)
        //    {
        //        Console.WriteLine($"\nIndex of value: {searchResult}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\nYour value does not exist in array");
        //    }
        //});

        //Task.WaitAll(binarySearchTask);
    }
}
