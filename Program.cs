using System;

namespace Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int summNum = 0;

            for (int i = 0; i < numCount; i++)
            {
                int num = int.Parse(Console.ReadLine());
                summNum += num;
            }
            Console.WriteLine(summNum);

        }
    }
}
