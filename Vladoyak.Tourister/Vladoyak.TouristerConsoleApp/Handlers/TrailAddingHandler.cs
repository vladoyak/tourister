using System;
using Vladoyak.AllInOneApp;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    internal class TrailPointAddingHandler : IHandler
    {
        private readonly ITouristerApp _app;
        private readonly string _code;
        private readonly string _name;

        public TrailPointAddingHandler(ITouristerApp app, string code, string name)
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