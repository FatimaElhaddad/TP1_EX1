using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Entrer un nbr");
            n = int.Parse(Console.ReadLine());
            is_prime(n);
        }
        public static void is_prime(int n)
        {
            int prime = 1;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prime = 0;
                    break;
                }

            }
            if (prime == 0)
                Console.WriteLine("Le nbr n'est pas premier");

            else
                Console.WriteLine("Le nbr est premier");
            Console.ReadKey();
        }
    }
}
