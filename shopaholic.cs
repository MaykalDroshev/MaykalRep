using System;


namespace Shopaholic_Kattis.com
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong itemsCount = ulong.Parse(Console.ReadLine());
            ulong[] items = Array.ConvertAll(Console.ReadLine().Split(' '), ulong.Parse);
            Array.Sort(items);
            Array.Reverse(items);
            ulong number = 2;
            ulong discout = 0;
            while (number < itemsCount)
            {

                discout += (ulong)items[number];
                number += 3;
            }

            Console.WriteLine(discout);
        }
    }
}
