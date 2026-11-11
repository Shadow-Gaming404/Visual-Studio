using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Typ je naam:");
            string naam = Console.ReadLine();
            Console.WriteLine("Typ graag ook je leeftijd:");
            string leeftijd = Console.ReadLine();
            Console.WriteLine($"Hallo {naam}, je bent {leeftijd} jaar oud!");
        }
    }
}
