using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("- ввести A - ввести B - выполнить операцию «+» -выполнить операцию «-» -выполнить операцию «*» -выполнить операцию «/»");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 3:
                    Console.WriteLine(a + b);
                    break;
            }
        }
    }
}
