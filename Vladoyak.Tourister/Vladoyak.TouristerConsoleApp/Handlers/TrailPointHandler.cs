using System;
using Vladoyak.AllInOneApp;
using Vladoyak.TouristerConsoleApp.Handlers;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    internal class TrailPointHandler : IHandler
    {
        private TouristerApp _app;

        public TrailPointHandler(TouristerApp app)
        {
            _app = app;
        }

        public void Handle()
        {
            // write all trail points
            Console.WriteLine("TRAILPOINTS:");
            foreach (var trailPoint in _app.GetTrailPoints())
            {
                Console.WriteLine($"  {trailPoint}");               
            }
        }
    }
}