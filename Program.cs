using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prokore.Analysis.Rent;

namespace Analyze
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //OldSampleTests.MarketRent();
            //SampleTests.CompositeMarketRent();
            //SampleTests.RentRoll();
            //SampleTests.LeaseExample1();
            //SampleTests.NRCollections1();
            //SampleTests.LeaseExample2();
            Prokore.Analysis.PropertyFinancials.SampleTest3.Run();
            /*
            Prokore.Analysis.Rent.NRBranchCollectionGenerator.generateCollection(
                new DateTime(2018, 11, 1),
                new DateTime(2068, 11, 1),
                10,
                6,
                3,
                3,
                3.5M,
                2.5M);
                */
        }

        static void Test1()
        {
            var mr = new MarketRent();
            mr.StartDt = new DateTime(2010, 01, 01);
            mr.EndDt = new DateTime(2015, 12, 31);
            mr.SquareFeet = 25000;
            mr.InitialRate = 26;
            mr.RentSculpt = new List<MarketRatePeriod>();
            MarketRatePeriod mrp = new MarketRatePeriod();
            mrp.StartDt = new DateTime(2010, 01, 01);
            mrp.EndDt = new DateTime(2015, 12, 31);
            mrp.GrowthRate = 7.0M; // 7% a year.
            mr.RentSculpt.Add(mrp);
            var op = mr.Analyze();
            foreach (var pt in op)
            {
                Console.WriteLine(string.Format("{0} - {1}", pt.Date, pt.Amount));
            }
        }

    }
}
