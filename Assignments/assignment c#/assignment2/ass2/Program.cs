using System;
namespace ass2
{
    class Average
    {
        public static void Main()
        {
            int[] arr = { 8, 16, 100, 21, 20 };
            int i = 0;
            int sum = 0;
            float average = 0.0F;
            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            average = (float)sum / arr.Length;
            Console.WriteLine("Average of Array elements: " + average);
            Console.Read();
        }
    }
}
