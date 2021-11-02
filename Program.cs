using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку");
            string st = Console.ReadLine();
            string[] starray = st.Split();
            int stlenght = starray[0].Length;
            for (int i = 0; i < starray.Length; i++)
            {
                if (starray[i].Length > stlenght)
                    stlenght = starray[i].Length;
                Console.Write("{0} ", starray[i].Length);

            }
            Console.WriteLine();
            Console.WriteLine("Самое длинное слово состоит из {0} символов", stlenght);
            Console.ReadKey();
        }
    }
}
