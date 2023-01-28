using System;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "hello", "2", "word", ":-)", "1234", "1567", "-2" };

            PrintArray(FindItems(array));
        }

        static string[] FindItems(string[] array)
        {
            int count = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    count++;
                }
            }

            string[] resultArray = new string[count];
            count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    resultArray[count] = array[i];
                    count++;
                }
            }
            return resultArray;
        }

        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
