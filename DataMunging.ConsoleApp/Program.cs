using DataMunging.Common.Utilities;
using System;

namespace DataMunging.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var fileFormatter = new FormatFileStreamData();
            Console.WriteLine(fileFormatter.RetrieveSmallestSpread(@"..\netcoreapp3.1\Data\football.dat", 6, 8));
        }
    }
}
