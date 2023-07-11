// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sum;
class Program
{
    public static void Main(string[] args)
    {


        Console.WriteLine("Please, enter the whole number from 100 to 2^32");
        string numberForSum = Console.ReadLine();
        //Array.Empty<int>();
        int[] line = new int[numberForSum.Length];//todo
       
        int result = 0;
        for (int i = 0; i < numberForSum.Length; i++)
        {
           char resultForCalculation = numberForSum[i];
           int resultForSum = Convert.ToInt32(resultForCalculation) - 48;
           result += resultForSum;
           line[i] = numberForSum[i];
        }
        Console.WriteLine(result);
        Console.WriteLine(line);
        
    }

}
