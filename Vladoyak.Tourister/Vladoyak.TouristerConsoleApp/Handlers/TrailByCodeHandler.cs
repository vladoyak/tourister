using System;
using System.Collections.Generic;
using System.Text;
using Vladoyak.AllInOneApp;

namespace Vladoyak.TouristerConsoleApp.Handlers
{
    public class TrailByCodeHandler : IHandler
    {
        private readonly ITouristerApp _app;
        private readonly string _trailCode;
      
        public TrailByCodeHandler(ITouristerApp app, string trailCode)
        {
            _app = app;
            _trailCode = trailCode;
        }

        public void Handle()
        {
            // one specific trail
            var trail6006 = _app.GetTrailByCode(_trailCode);
            Console.WriteLine(trail6006);
        }
    }
}
