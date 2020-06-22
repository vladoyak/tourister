using System;
using Vladoyak.AllInOneApp;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    internal class TripAddingHandler : IHandler
    {
        private readonly ITouristerApp _app;
        private readonly string _code;
        private readonly int _year;
        private readonly int _month;
        private readonly int _day;

        public TripAddingHandler(ITouristerApp app, string code, int year, int month, int day)
        {
            _app = app;
            _code = code;
            _year = year;
            _month = month;
            _day = day;
        }

        public void Handle()
        {
            _app.AddTrip(_code, _year, _month, _day);
            Console.WriteLine($"New trip added.");
        }
    }
}