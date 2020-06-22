using System;
using System.Collections.Generic;
using System.Text;
using Vladoyak.AllInOneApp;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    class TripHandler : IHandler
    {
        private readonly ITouristerApp _app;

        public TripHandler(ITouristerApp app)
        {
            _app = app;
        }

        public void Handle()
        {
            // write all trips
            Console.WriteLine("TRIPS:");
            foreach (var trip in _app.GetTrips())
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
