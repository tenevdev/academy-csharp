using System;

namespace SelectionSort
{
    class SelectionSort
	{
		static void Main (string[] args)
		{

            Console.Write("Enter array length:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = int.MaxValue, swap;

            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    swap = array[min];
                    array[min] = array[i];
                    array[i] = swap;
                }
            }

			foreach (var num in array)
			{
				Console.WriteLine (num);
			}
		}
	}
}
