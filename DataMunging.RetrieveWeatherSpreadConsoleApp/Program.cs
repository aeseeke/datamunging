using DataMunging.Common.Utilities;
using System;

namespace DataMunging.RetrieveWeatherSpreadConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DataMunging Retrieve Weather Spread Application \n");
            var fileFormatter = new FormatFileStreamData();
            Console.WriteLine(fileFormatter.RetrieveSmallestSpread(@"..\netcoreapp3.1\Data\weather.dat", 1, 2));
        }
    }
}
