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
            foreach (var trail in app.Trails.Values)
            {
                Console.WriteLine($"  {trail}");
                foreach (var point in trail.TrailPoints)
                {
                    Console.WriteLine($"    {point}");
                }
            }

            // write all signposts
            Console.WriteLine("SIGNPOSTS:");
            foreach (var signpost in app.Signposts.Values)
            {
                Console.WriteLine($"  {signpost}");
                foreach (var directionSign in signpost.DirectionSigns)
                {
                    foreach (var direction in directionSign.Directions)
                    {
                        Console.WriteLine($"    {direction}");
                    }
                }
            }

            // write all trips
            Console.WriteLine("TRIPS:");
            foreach (var trip in app.Trips.Values)
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
