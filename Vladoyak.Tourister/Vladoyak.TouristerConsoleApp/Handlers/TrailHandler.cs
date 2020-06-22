using System;
using Vladoyak.AllInOneApp;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    internal class TrailHandler : IHandler
    {
        private readonly ITouristerApp _app;     

        public TrailHandler(ITouristerApp app)
        {
            _app = app;
        }

        public void Handle()
        {
            // write all trails
            Console.WriteLine("TRAILS:");
            foreach (var trail in _app.GetTrails())
            {
                Console.WriteLine($"  {trail}");
                foreach (var point in trail.TrailPoints)
                {
                    Console.WriteLine($"    {point}");
                }
            }
        }
    }
}