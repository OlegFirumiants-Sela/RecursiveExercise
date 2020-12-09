using System;
using System.Collections.Generic;

namespace Rec
{
    class Program
    {
        static void Main(string[] args)
        {
            RecMet27();
        }

        static void RecMet1()
        {
            var r = new Rec01();
            var i = int.Parse(Console.ReadLine());

            Console.WriteLine(r.RunRec(i));

            Console.ReadLine();
        }

        static void RecMet3()
        {
            var r = new Rec03();
            var i = int.Parse(Console.ReadLine());

            Console.WriteLine(r.RunRec(i));

            Console.ReadLine();
        }

        static void RecMet5()
        {
            var r = new Rec05();
            var arr = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            r.RunRec(arr);

            Console.ReadLine();
        }

        static void RecMet7()
        {
            var r = new Rec07();
            var arr = new int[] { 10, 20, 30, 40, 20, 50, 60, 70, 20 };

            Console.WriteLine(r.RunRec(arr, 20));

            Console.ReadLine();
        }

        static void RecMet9()
        {
            var r = new Rec09();
            var s = "abcdefgh";

            r.RunRec(s);

            Console.ReadLine();
        }

        static void RecMet11()
        {
            var r = new Rec11();
            var i = int.Parse(Console.ReadLine());
            var s = i.ToString();

            Console.WriteLine(r.RunRec(s, '1', '2'));

            Console.ReadLine();
        }

        static void RecMet13()
        {
            var r = new Rec13();
            var i = int.Parse(Console.ReadLine());

            r.RunRec(i);

            Console.ReadLine();
        }

        static void RecMet23()
        {
            var r = new Rec23();

            var arr = new int[][] { new int[] { 1, 2, 3 }, new int[] { 6, 2, 3 }, new int[] { 1, 2, 3 } };

            Console.WriteLine(r.RunRec(arr));

            Console.ReadLine();
        }

        static void RecMet25()
        {
            var r = new Rec25();

            var grid = new char[][]
            {
                new char[] { '0', '0', '1', '1', '1', '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '1', '0', '0', '0', '0', '1', '0', '0' },
                new char[] { '0', '1', '0', '0', '0', '0', '0', '0', '1', '0' },
                new char[] { '1', '0', '0', '0', '0', '0', '0', '0', '0', '1' },
                new char[] { '0', '1', '0', '0', '0', '0', '0', '0', '1', '0' },
                new char[] { '0', '0', '1', '0', '0', '0', '0', '1', '0', '0' },
                new char[] { '0', '0', '1', '1', '1', '1', '1', '1', '0', '0' }
            };

            r.RunRec(grid);
        }
    
        static void RecMet27()
        {
            var r = new Rec27();
            Console.WriteLine("insert base:");
            var baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("number:");
            var number = int.Parse(Console.ReadLine());


            Console.WriteLine(r.RunRec(baseNum, number));
        }
    }
}
