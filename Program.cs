using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefLink
{
    public struct Lstr
    {
        public int a;
    }

    public class Cstr
    {
        public int a;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 7;
            int a2 = 21;
            string a3 = "21 числа др у Саб";
            string a4 = "7 числа др у Ник";
            int a5 = 66;

            Lstr s1;
            s1.a = 1;

            Cstr c1 = new Cstr();
            c1.a = 1;

            Chn(a1, a2, a3, a4, ref a5, s1, c1);

            System.Console.WriteLine(a1);
            System.Console.WriteLine(a2);
            System.Console.WriteLine(a3);
            System.Console.WriteLine(a4);
            System.Console.WriteLine(a5);
            System.Console.WriteLine(s1.a);
            System.Console.WriteLine(c1.a);
        }

        static void Chn(int _a1, int _a2, string _a3, string _a4, ref int _a5, Lstr _s, Cstr _c)
        {
            _a1 = 5;
            _a2 = 7;
            _a3 = "Не изменен";
            _a4 = "Не изменен";
            _a5 = 88;
            _s.a = 2;
            _c.a = 2;
        }
    }
}