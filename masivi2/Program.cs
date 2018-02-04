using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "one", "two", "three", "four", "five" };
            for (int i= 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
