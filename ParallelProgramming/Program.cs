using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("1. Juan");
            names.Add("2. Fernando");
            names.Add("3. Elena");
            names.Add("4. Rebeca");
            names.Add("5. Francisco");

            Parallel.ForEach(names, name =>
            {
                Console.WriteLine(name);
            });

        }
    }
}
