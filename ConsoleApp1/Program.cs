//Written by Webi Chala


using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bowl listingBowl = new Bowl();
            listingBowl.Num(listingBowl.Max,listingBowl.Min);
            Console.WriteLine(listingBowl.ToString());
            Console.ReadLine();
        }
    }
}
