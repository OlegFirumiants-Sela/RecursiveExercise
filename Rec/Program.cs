using System;
using System.Collections.Generic;

namespace Rec
{
    class Program
    {
        static void Main(string[] args)
        {
            RecMet39();
        }

        static void RecMet1()
        {
            var r = new Rec01();
            var i = int.Parse(Console.ReadLine());

            Console.WriteLine(r.Factorial(i));

            Console.ReadLine();
        }

        static void RecMet2()
        {
            var r = new Rec02();
            var arr = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            r.PrintArray(arr);

            Console.ReadLine();
        }

        static void RecMet3()
        {
            var r = new Rec03();
            var i = int.Parse(Console.ReadLine());

            Console.WriteLine(r.MultiplyNumber(i));

            Console.ReadLine();
        }

        static void RecMet4()
        {
            var r = new Rec04();
            var i = int.Parse(Console.ReadLine());

            r.PrintOddNumbersInNumber(i);

            Console.ReadLine();
        }

        static void RecMet5()
        {
            var r = new Rec05();
            var arr = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            r.PrintOddIndexesInArray(arr);

            Console.ReadLine();
        }

        static void RecMet6()
        {
            var r = new Rec06();
            var arr = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            Console.WriteLine(r.IsArratSortedAscending(arr));

            Console.ReadLine();
        }

        static void RecMet7()
        {
            var r = new Rec07();
            var arr = new int[] { 20, 10, 20, 30, 40, 20, 50, 60, 70, 20 };

            Console.WriteLine(r.CountAppearancesOfNumInArray(arr, 20));

            Console.ReadLine();
        }

        static void RecMet8()
        {
            var r = new Rec08();
            var arr = new int[][]
            {
                new int[] { 20, 10, 20, 30, 40, 20, 50, 60, 70, 20 },
                new int[] { 20, 10, 20, 30, 40, 20, 50, 60, 70, 20 },
                new int[] { 20, 10, 20, 30, 40, 20, 50, 60, 70, 20 },
                new int[] { 20, 10, 20, 30, 40, 20, 50, 60, 70, 20 },
                new int[] { 20, 10, 20, 30, 40, 20, 50, 60, 70, 20 },
                new int[] { 20, 10, 20, 30, 40, 20, 50, 60, 70, 20 },
                new int[] { 20, 10, 20, 30, 40, 20, 50, 60, 70, 20 }
            };

            Console.WriteLine(r.CountAppearancesOfNumInArrayOfArrays(arr, 20, 0, 0));

            Console.ReadLine();
        }

        static void RecMet9()
        {
            var r = new Rec09();
            var s = "abcdefgh";

            r.PrintCharsUntiilDollarSignBackwards(s);

            Console.ReadLine();
        }

        static void RecMet10()
        {
            var r = new Rec10();
            var i = 1221;

            Console.WriteLine(r.SwitchNumersIfAppearCloseOnTheSides(i, 1, 2));

            Console.ReadLine();
        }

        static void RecMet11()
        {
            var r = new Rec11();
            var i = int.Parse(Console.ReadLine());
            var s = i.ToString();

            Console.WriteLine(r.SwitchNumbersIfAppearCloseInNumber(s, '1', '2'));

            Console.ReadLine();
        }

        static void RecMet12()
        {
            var r = new Rec12();

            Console.WriteLine(r.GetGCD(15, 51));

            Console.ReadLine();
        }

        static void RecMet13()
        {
            var r = new Rec13();
            var i = int.Parse(Console.ReadLine());

            r.GetAllPossibleOptionsToSumNumber(i);

            Console.ReadLine();
        }

        static void RecMet23()
        {
            var r = new Rec23();

            var arr = new int[][] { new int[] { 1, 2, 3 }, new int[] { 6, 2, 3 }, new int[] { 1, 2, 3 } };

            Console.WriteLine(r.IsMultiplicationTable(arr));

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

            r.FillSpace(grid);
        }

        static void RecMet27()
        {
            var r = new Rec27();
            Console.WriteLine("insert base:");
            var baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("number:");
            var number = int.Parse(Console.ReadLine());


            Console.WriteLine(r.IsNumberFitsNumBase(baseNum, number));
        }

        static void RecMet31()
        {
            var r = new Rec31();

            var arr = new int[] { 21, 45, 78, 65, 5, 11, 2, 46, 77 };

            Console.WriteLine($"\nminsub -> {r.MinimalSubtraction(arr)}");
        }

        static void RecMet35()
        {
            var r = new Rec35();

            var l1 = new List<int> { 7, 3, 18, 2, 21, 9, 5 };
            var l2 = new List<int> { 14, 9, 3, 23, 22, 8 };

            r.PrinNotSharedValues(l1, l2);
        }

        static void RecMet37()
        {
            var r = new Rec37();

            var arr = new int[] { 3, 6, 1, 9, 2, 10, 8 };

            Console.WriteLine($"-> {r.CountReversedOrderPairs(arr)}");
        }

        static void RecMet39()
        {
            var r = new Rec39();

            var arr = new int[] { 4, 8, 7, 2, 6, 1, 3, 5 };

            r.Foo(arr);

        }

        static void RecMet41()
        {
            var r = new Rec41();
            var arr = new char[] { 'b', 'a', 'd', '*', 'd', 'a', 'm', '4', 'a', 'm', 'm', 'c', 'b', 'x' };
            Console.WriteLine(r.UpdateCharList(arr));
        }

        static void RecMet43()
        {
            var r = new Rec43();
            var arr = new char[] { 'B', 'B', 'B', 'B', '*', '*', '*', 'X', 'C', 'C' };
            Console.WriteLine(r.UpdateCharList(arr));

        }

        static void RecMet45()
        {
            var r = new Rec45();

            var arr = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            r.PrintBackwardsList(arr);
        }
    }
}
