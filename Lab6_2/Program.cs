using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку ");
            string str = Console.ReadLine();
            int i = 0;
            int j = str.Length - 1;
            bool f = true;
            for (; i < j; i++, j--)
                if (str[i] != str[j])
                {
                    f = false;
                    break;
                }
                else
                {
                    f = true;
                }
            if (!f)
                Console.WriteLine("Это не полиндром");
            else
                Console.WriteLine("Это полиндром");
            Console.ReadKey();
        }
    }
}
