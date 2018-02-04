using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            // vavejda elementi na arraya
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arr.Length;
            //obrabotka
            int min = arr[0];
            int max = arr[0];
            float sum = arr[0];
            
            for (int i = 1; i < n; i++)
            {
                sum += arr[i];
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }

                
            }

            // izvejdane na elementi
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {sum/n}");
        }
    }
}
