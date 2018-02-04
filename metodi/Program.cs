using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, -5, 1, 10 };
            // Array.Clear(arr, 0, 1); 
            // int[] arrReverse = new int[arr.Length];
            //  Array.Reverse(arr);
            //  arrReverse = arr;
            int[] arrCopy = { 6, 7, 8 };
            arrCopy.CopyTo(arr, 1);
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
