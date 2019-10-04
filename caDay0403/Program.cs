using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0403
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            int[] array= new int[n+2];
            array[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                array[i] = i + array[i-1];
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
