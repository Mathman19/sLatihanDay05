using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0506
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] huruf = new string[5] { "A", "B", "C", "D", "E" };
 
            for (int i = 0; i<input-1; i++)
            {
                for (int j = 0; j<=i; j++)
                {
                    string gabung = string.Join("", huruf[i]);
                    string str = gabung.Substring(j, i);
                    Console.Write(gabung);
                   //onsole.Write(huruf[i]);
                }
            }

          
            
            Console.ReadKey();
            
        }
    }
}
