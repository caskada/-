using System;

namespace Задание_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 93;
            int b = 233;
            bool r = a > b; // false
            bool c = b < 100; // false
            bool f = r || c;
            string m = Convert.ToString(a) + " > " + Convert.ToString(b) + " || " + Convert.ToString(b) + " < 100 = " + Convert.ToString(f);
            string n = Convert.ToString(b) + " < 100 = " + Convert.ToString(c);
            Console.WriteLine((string)m);

            //Console.WriteLine((string)n);
            //Console.WriteLine(string m = Convert.ToString(a) + " > " + Convert.ToString(b) + " = " + Convert.ToString(r) || string n = Convert.ToString(b) + " < 100 = " + Convert.ToString(c));

            //Console.WriteLine(Convert.ToString(f));

            Console.ReadKey();
        }
    }
}
