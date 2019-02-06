using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                string pattern = @"\bSharif\b";
                string replace = "Officer";
                string result = Regex.Replace(line, pattern, replace);
                Console.WriteLine($"Case {t}: {result}");
            }
        }
    }
}
