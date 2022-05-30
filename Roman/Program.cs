using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' '); ;
            if (command[0] == "rome")
            {
                Rome num = new Rome(command[1]);
                Console.WriteLine(num.ConvertToArabic());
            }
            else if (command[0] == "arabic")
            {
                Arabic num = new Arabic(command[1]);
                Console.WriteLine(num.ConvertToRoman());
            }
            else
            {
                Console.WriteLine("Что-то не так");
            }

            Console.ReadKey();
        }
    }
}
