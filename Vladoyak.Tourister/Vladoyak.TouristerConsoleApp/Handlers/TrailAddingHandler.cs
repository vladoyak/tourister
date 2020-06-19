using System;
using Vladoyak.AllInOneApp;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    internal class TrailPointAddingHandler : IHandler
    {
        private TouristerApp _app;
        private string _code;
        private string _name;

        public TrailPointAddingHandler(TouristerApp app, string code, string name)
        {
            _app = app;
            _code = code;
            _name = name;
        }

        public void Handle()
        {
            _app.AddTrailPoint(_code, _name);
            Console.WriteLine($"New trail point code:{_code} added");
        }
    }
}