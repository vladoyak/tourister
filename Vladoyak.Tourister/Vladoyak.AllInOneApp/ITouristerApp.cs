using System;
using System.Collections.Generic;
using System.Text;
using Vladoyak.AllInOneApp.DomainObjects;

namespace Vladoyak.AllInOneApp
{
    public interface ITouristerApp
    {
        void Init();
        Trail GetTrailByCode(string code);
        IEnumerable<Trail> GetTrails();
        Trip GetTripByCode(string code);
        IEnumerable<Trip> GetTrips();
        IEnumerable<TrailPoint> GetTrailPoints();
        void AddTrailPoint(string code, string name);
        void RemoveTrailPoint(string code);
        void Save();
    }
}
