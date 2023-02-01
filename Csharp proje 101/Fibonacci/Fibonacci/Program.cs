using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen fibonacci seri uzunluğunu giriniz: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci serisinin toplamı: {0}", fibonacci(length));
            Console.ReadLine();

        }
        public static int fibonacci(int x)
        {
            if (x <= 2)
            {
                return 1;
            }
            else
            {
                return fibonacci(x - 1) + fibonacci(x - 2);
            }
        }
    }
}
