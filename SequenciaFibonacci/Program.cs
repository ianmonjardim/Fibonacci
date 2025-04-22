using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de termos da sequência de Fibonacci que deseja ver:");
            int n = int.Parse(Console.ReadLine());

            List<int> fibonacci = new List<int>();

            fibonacci.Add(0);
            fibonacci.Add(1);

            for (int i = 2; i < n; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
            }
            Console.WriteLine("Sequência de Fibonacci:");
            foreach (var item in fibonacci)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
