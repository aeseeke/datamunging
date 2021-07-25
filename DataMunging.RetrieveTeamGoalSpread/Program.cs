using DataMunging.Common.Utilities;
using System;

namespace DataMunging.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DataMunging Retrieve Team Goal Spread Application \n");
            var fileFormatter = new FormatFileStreamData();
            Console.WriteLine(fileFormatter.RetrieveSmallestSpread(@"..\netcoreapp3.1\Data\football.dat", 6, 8));
        }
    }
}
