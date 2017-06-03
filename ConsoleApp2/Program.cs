using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static Random rnd;

        static void Main(string[] args)
        {
            DNAAnalyzer da = new DNAAnalyzer();
            rnd = new Random();
            List<double> d1 = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                var r = rnd.NextDouble();
                if (rnd.NextDouble() > 0.5)
                {
                    r *= -1;
                }
                d1.Add(r);
            }

            string dna = da.GetDNA(new double[]{ 3}.ToList());

            Console.WriteLine();
            Console.WriteLine(dna);

            Console.ReadLine();
        }


    }
}


