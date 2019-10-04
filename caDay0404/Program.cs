using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0404
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int n = Convert.ToInt32(x);
            int[] angka = new int[n + 3];
            angka[0] = 1;
            angka[1] = 1;
            angka[2] = 1;
            for (int i = 2; i <= n+1; i++)
            {
                angka[i + 1] = angka[i] + angka[i - 1] + angka[i - 2];
                Console.Write(angka[i-2] + " ");
            }
            //Console.WriteLine(angka[n-1]);
            Console.ReadKey();
        }
    }
}
