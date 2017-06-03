using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNAComparer
{
    class Program
    {
        const string path = @"C:\Users\Public\Documents\Unity Projects\NeuroNetBot\CrossDna_13.csv";
        const string space = "\t";

        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(path).Select(a => a.Split(',')).ToList();

            Console.WriteLine();
            Console.WriteLine(lines.Count+" Zeilen...:");
            Console.WriteLine();
            Console.WriteLine("{0, 15} {1,23} {2,22} {3,21}\n", "P1", "P2", "C1", "C2");

            foreach (var line in lines)
            {
                if (line[0] == line[1])
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("{0,23:D20}", line[0]);
                    Console.Write("{0,23:D20}", line[1]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0,23:D20}",line[0]);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0,23:D20}", line[1]);
                    Console.ResetColor();

                }

                if (line[2] != line[3])
                {

                    if (line[0] == line[2])
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (line[1] == line[2])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("{0,23:D20}", line[2]);
                    Console.ResetColor();

                    if (line[0] == line[3])
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (line[1] == line[3])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("{0,23:D20}", line[3]);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("{0,23:D20}", line[2]);
                    Console.Write("{0,23:D20}", line[3]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(lines.Count + " Zeilen...: " + new System.IO.FileInfo(path).LastWriteTime);
            Console.ReadLine();
        }
    }
}