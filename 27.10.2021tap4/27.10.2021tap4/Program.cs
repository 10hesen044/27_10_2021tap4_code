using System;

namespace _27._10._2021tap4
{
    class Program
    {
        static void Main(string[] args) //TAPSIRIQ 4 27.10.2021
        {
            int[] array = { 13, 5, 3, 9, 56, 34, 24 };
            Console.WriteLine("Arrayda ki max element: "+MaxElement(array));
        }
        static int MaxElement(int[] Arr)
        {
            int max = Arr[0];
            foreach (var item in Arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

    }
}
