using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0504
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 1; i<=x; i++)
            {
                if (x % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} angka prima", x);
            } else
            {
                Console.WriteLine("bukan angka prima");
            }
            Console.ReadKey();

        }
    }
}
