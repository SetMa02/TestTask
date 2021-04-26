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
            
            }
            Console.ReadKey();
        }

    }
}
