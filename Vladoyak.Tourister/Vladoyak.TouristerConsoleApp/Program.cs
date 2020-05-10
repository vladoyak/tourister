using System;
using Vladoyak.AllInOneApp;

namespace Vladoyak.TouristerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new TouristerApp();
            app.Init();

            // write all trails
            Console.WriteLine("TRAILS:");
            foreach (var trail in app.GetTrails())
            {
                Console.WriteLine($"  {trail}");
                foreach (var point in trail.TrailPoints)
                {
                    Console.WriteLine($"    {point}");
                }
            }

            // one specific trail
            var trail6006 = app.GetTrailByCode("6006");
            Console.WriteLine(trail6006);

           

            // write all trips
            Console.WriteLine("TRIPS:");
            foreach (var trip in app.GetTrips())
            {
                Console.WriteLine($"  {trip}");
                foreach (var trailPointVisit in trip.TrailPointVisits)
                {
                    Console.WriteLine($"    {trailPointVisit}");
                }
            }
        }
    }
}
