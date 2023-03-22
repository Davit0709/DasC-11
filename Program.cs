using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();


        int[] arr = new int[4];

        Console.WriteLine("Случайный массив:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100, 1000);
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();


        int evenCount = 0;

        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                evenCount++;
            }
        }


        Console.WriteLine("Количество чётных чисел в массиве: " + evenCount);


        Console.ReadKey();
    }
}
