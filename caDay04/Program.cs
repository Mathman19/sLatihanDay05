using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay04
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int x = Convert.ToInt32(n);
            
            for (int i = 1; i <= x; i++)
            {
                int hasil = 2 * i - 1;
                Console.Write(hasil + " ");
            }
            Console.ReadLine();
        }
    }
}
