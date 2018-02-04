using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] uspehGrupa = new float[8];
            string[] firstNameGrupa = new string[] { "Aleksandra", "Gergana", "Desislava", "Ivailo",
                "Kristina", "Mariela", "Mario", "Tsvetina"};
            Console.WriteLine(firstNameGrupa.Length);
            firstNameGrupa[0] = "Александра";
            firstNameGrupa[1] = "Гергана";
            float sum = 0f;
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Оценка за " + firstNameGrupa[i] + " e: ");
                uspehGrupa[i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{uspehGrupa[i]} - ");
                sum = sum + uspehGrupa[i];
            }
            Console.WriteLine("\n Average: " + sum/uspehGrupa.Length);
        }
    }
}
