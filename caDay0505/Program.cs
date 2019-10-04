using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0505
{
    class Program
    {
        static void Main(string[] args)
        {
            string tampung = Console.ReadLine();
            char[] pisah = tampung.ToCharArray();
            //int[] angka = Convert.ToInt32(pisah);
            int n = pisah.Length;
            for (int i=1; i<=n; i++)
            {
                string x = tampung.Substring(0, i-1);
                char[] y = x.ToCharArray();
                //int ti = Convert.ToInt32(y);
                //int[] angka = new int[ti];
                y[i-1] = y[i-2];
                
                Console.WriteLine(x);
                Console.WriteLine();
                Console.WriteLine(y[i]);
            }
            Console.ReadKey();
        }
    }
}
