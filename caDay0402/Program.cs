using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0402
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int n = Convert.ToInt32(x);
            int[] angka = new int[n+2];
            angka[0] = 0;
            angka[1] = 1;
            for (int i=1; i <= n; i++)
            {
                angka[i+1]= angka[i] + angka[i - 1];
                Console.Write(angka[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
