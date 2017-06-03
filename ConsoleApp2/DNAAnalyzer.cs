using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class DNAAnalyzer
    {
        internal string GetDNA(List<double> d1)
        {
            string dna = "";
            foreach (var gen in d1)
            {
                //long.toBinaryString(Double.doubleToRawLongBits(0D))
                //Console.WriteLine(Convert.ToString(gen,));
                DoubleToBinaryString(gen);
                var i1 = BitConverter.DoubleToInt64Bits(gen);
                dna += i1.ToString();
            }

            return dna;
            //Console.WriteLine(d1);
            //var i1= BitConverter.DoubleToInt64Bits(d1);
            //Console.WriteLine(BitConverter.DoubleToInt64Bits(i1));
            //i1 += 1000000000000000;
            //Console.WriteLine(BitConverter.Int64BitsToDouble(i1));
        }

        public string DoubleToBinaryString(double d)
        {
            return Convert.ToString(BitConverter.DoubleToInt64Bits(d), 2);
        }


        public string DoubleinBinaereundHexa(double wert)
        {
            int bitCount = sizeof(double) * 8;
            char[] result = new char[bitCount];

            //long lgValue = BitConverter.ToInt64(BitConverter.GetBytes(wert), 0);

            // split the conversion into two operations
            Byte[] bytes = BitConverter.GetBytes(wert);
            // show each byte
            //foreach (Byte b in bytes)
            //{
            //    Console.WriteLine(Convert.ToString(b, 2).PadLeft(8, '0'));
            //}

            long lgValue = BitConverter.ToInt64(bytes, 0);

            for (int bit = 0; bit < bitCount; ++bit)
            {
                // show each mask
                //Console.WriteLine(Convert.ToString((1 << bit), 2).PadLeft(64, '0'));

                long maskwert = lgValue & (1 << bit);
                if (maskwert > 0)
                {
                    maskwert = 1;
                }
                result[bitCount - bit - 1] = maskwert.ToString()[0];
            }
            //Console.WriteLine("\n\nBinaere Darstellung:");

            for (int i = 0; i < 64; i++)
            {

                if (i % 4 == 0)
                    //Console.Write(" ");
                if (result[i] == '-')
                {
                    result[i] = '1';
                }
                Console.Write(result[i]);
            }

            return result.ToString();
        }
    }
}
