using System;
using System.Linq;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            char[] chis = input.ToCharArray();
            int letterCounts = 0;
            int[] counts = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach(var ch in chis)
            {
                for(int y = 0 ;y < chis.Length; y++)
                {
                    if(ch == chis[y])
                    {
                        letterCounts++;
                    }
                }
                if(letterCounts != 0 && letterCounts != 1)
                {
                    Console.WriteLine(ch + ":" + " " + letterCounts);
                    letterCounts = 0;
                    chis = chis.Where(x => x != ch).ToArray();
                }
                int i = ToInt(ch);
               switch(i)
                {
                    case 0: counts[0]++; break;
                    case 1: counts[1]++; break;
                    case 2: counts[2]++; break;
                    case 3: counts[3]++; break;
                    case 4: counts[4]++; break;
                    case 5: counts[5]++; break;
                    case 6: counts[6]++; break;
                    case 7: counts[7]++; break;
                    case 8: counts[8]++; break;
                    case 9: counts[9]++; break;
                }
            }
            for(int x = 0; x < counts.Length; x++)
            {
                if(counts[x] > 0)
                    Console.WriteLine(x + ":" + " " + counts[x]);
            }
            Console.ReadKey();
        }
        static int ToInt(char c)
        {
            return (c - '0');
        }
    }
}
