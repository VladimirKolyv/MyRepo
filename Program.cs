using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string [] s= { "555", "777", "999" };
            int n = 0;
            foreach (string s1 in args)
            {
                n++;
                Console.WriteLine("Аргумент " + n.ToString() + "  " + s1.ToString());
            }
            Console.Read();
        }

    }

}