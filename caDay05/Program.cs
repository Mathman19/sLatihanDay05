using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay05
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] n = new string[7] { "A", "B", "C", "D", "E", "F", "G" };
            
            for (int i=0; i<input-1; i++)
            {
                for (int j = 0; j<=i && j<input; j++)
                {
                    Console.Write(n[i]);
                }
            }
            Console.ReadKey();
            
        }
    }
}
