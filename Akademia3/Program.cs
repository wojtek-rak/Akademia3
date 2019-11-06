using System;
using System.Collections.Generic;
using System.Linq;

namespace Akademia3
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            var users = new List<string>() { "malroXd", "dare", "roage",
                "washbasinphxDone", "jealouslewsomed", "rashtoexd", "iffybalgy",
                "likebomb", "roadavoid"};

            foreach (var user in users)
            {
                if (user.Contains("xd"))
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}
