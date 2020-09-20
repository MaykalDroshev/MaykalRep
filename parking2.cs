using System;


namespace Parking2_Kattis.com
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalCases = int.Parse(Console.ReadLine());
            for (int Case = 0; Case < totalCases; Case++)
            {
                int numOfShops = int.Parse(Console.ReadLine());
                int[] shopNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Array.Sort(shopNumbers);
                Array.Reverse(shopNumbers);
                int answer = 0;
                for (int shopnum = 0; shopnum < numOfShops - 1; shopnum++)
                {
                    answer += shopNumbers[shopnum + 1] - shopNumbers[shopnum];
                }
                answer += shopNumbers[numOfShops - 1] - shopNumbers[0];
                Console.WriteLine(Math.Abs(answer));
            }

        }
    }
}
