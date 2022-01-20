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
                case 1:
                    a=Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    b = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine(a + b);
                    break;
                case 4:
                    Console.WriteLine(a - b);
                    break;
                case 5:
                    Console.WriteLine(a * b);
                    break;
                case 6:
                    Console.WriteLine(a / b);
                    break;
            }
        }
    }
}
