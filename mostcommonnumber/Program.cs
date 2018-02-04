using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostcommonnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arr.Length;
            int maxCommonElement = 0; //nai-chesto sreshtanoto chislo
            int count = 1;
            int maxCount = 0; //nai-golqm broi
            for (int i = 0; i <= n-2; i++)
            {
                for (int j = i+1; j < n-1; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        count++;
                    }
                }
                if (maxCount<count)
                {
                    maxCount = count;
                    maxCommonElement = arr[i];
                }
                count = 1;
            }
            Console.WriteLine($"{maxCommonElement} се среща {maxCount}");
            
        }
    }
}
