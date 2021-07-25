using DataMunging.Common.Utilities;
using System;

namespace DataMunging.RetrieveWeatherSpreadConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileFormatter = new FormatFileStreamData();
            Console.WriteLine(fileFormatter.RetrieveSmallestSpread(@"..\netcoreapp3.1\Data\weather.dat", 1, 2));
        }
    }
}
