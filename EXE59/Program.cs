using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] y = { 1, 2, 3, 4, 5, 6, 7 };
            int[] z = { 4, 1, 8, 2, 4, 7, 8, 9, 4 };
            
            Console.WriteLine(Isincreasing(y));
            Console.WriteLine(Isincreasing(z));
            Console.ReadLine();
        }
        public static bool Isincreasing(int[] x)
        {
            int n = x.Length;
            for(int i = 1; i < n; i++)
            {
                if (x[i] <= x[i - 1])
                {
                    return false;
                }   
            }
            return true;
            
        }
   
    }
}
