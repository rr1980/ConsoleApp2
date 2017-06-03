using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_V2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BackPropogationNetwork charecterNet = new BackPropogationNetwork(2, 3, 1);

            List<DataSet> dataSetInputs = new List<DataSet>();

            dataSetInputs.Add(new DataSet(new double[] { 0, 0 }, new double[] { 0 }));
            dataSetInputs.Add(new DataSet(new double[] { 0, 1 }, new double[] { 1 }));
            dataSetInputs.Add(new DataSet(new double[] { 1, 0 }, new double[] { 1 }));
            dataSetInputs.Add(new DataSet(new double[] { 1, 1 }, new double[] { 0 }));


            //charecterNet.BackPropogate(dataSetInputs.ToArray(), 0.4, 0.9);
            charecterNet.BatchBackPropogate(dataSetInputs.ToArray(), 1000, 0.4, 0.9);


            foreach (var s in dataSetInputs)
            {
                charecterNet.ApplyInput(s.Inputs);
                charecterNet.CalculateOutput();
                var result = charecterNet.ReadOutput();
                System.Console.WriteLine(s.Inputs[0] + ":" + s.Inputs[1] + " = " + result.First());
            }

            System.Console.ReadLine();

        }
    }
}
