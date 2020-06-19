using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Vladoyak.AllInOneApp.DomainObjects;

namespace Vladoyak.AllInOneApp.Data
{
    class DataSource
    {
        public Dictionary<string, TrailPoint> TrailPoints { get; set; } = new Dictionary<string, TrailPoint>();
        public Dictionary<string, Trail> Trails { get; set; } = new Dictionary<string, Trail>();
        public Dictionary<string, Trip> Trips { get; set; } = new Dictionary<string, Trip>();

        public void Init()
        {
            // trails
            LoadTrailPoints();
            LoadTrails();
            BuildTrails();
            BuildTrailPoints();

            // trips
            LoadTrips();
        }

        public void AddTrailPoint(TrailPoint trailPoint)
        {
            TrailPoints.Add(trailPoint.Code, trailPoint);            
        }

        public void RemoveTrailPoint(string code)
        {
            TrailPoints.Remove(code);
        }

        private void LoadTrailPoints()
        {
            // read from JSON   
            string fileName = "trailpoints.json";

            var serialized = File.ReadAllText(fileName);
            TrailPoints = JsonSerializer.Deserialize<IEnumerable<TrailPoint>>(serialized).ToDictionary(tp => tp.Code, tp => tp);

            //TrailPoints.Add("AB061", new TrailPoint
            //{
            //    Name = "Hlubočepy (tram)",
            //    Code = "AB061",
            //    TrailsCodes = new HashSet<string> { "6006" },
            //    Trails = new HashSet<Trail>(),
            //    Signpost = new Signpost
            //    {                  
            //        NameSign = new NameSign
            //        {
            //            Code = "AB061m",
            //            Name = "HLUBOČEPY tram",
            //            PublicTransportType = PublicTransportType.Tram,
            //            Altitude = 195,
            //            Header = "KLUB ČESKýCH TURISTŮ",
            //            Year = 2019
            //        },
            //        DirectionSigns = new List<DirectionSign>
            //        {
            //            new DirectionSign
            //            {
            //                Code = "AB061b",
            //                Header = "NS BARRANDOVSKÉ SKÁLY",
            //                Footer = "PĚŠÍ TRASA KČT",
            //                Year = 2014,
            //                TrailColour = TrailColour.Yellow,
            //                Directions = new List<Direction>{
            //                    new Direction{
            //                        DirectionPointCode = "AB063",
            //                        Length = 2
            //                    },
            //                    new Direction{
            //                        DirectionPointCode = "AB072",
            //                        Length = 4
            //                    },
            //                    new Direction{
            //                        DirectionPointCode = "AB056",
            //                        Length = 5.5m
            //                    },
            //                }
            //            }
            //        },
            //    }
            //});
            //TrailPoints.Add("AB063", new TrailPoint
            //{
            //    Name = "Malá Chuchle (bus)",
            //    Code = "AB063",
            //    TrailsCodes = new HashSet<string> { "6006" },
            //    Trails = new HashSet<Trail>(),
            //    Signpost = new Signpost()
            //});
            //TrailPoints.Add("AB062", new TrailPoint
            //{
            //    Name = "Malá zoologická",
            //    Code = "AB062",
            //    TrailsCodes = new HashSet<string> { "6006" },
            //    Trails = new HashSet<Trail>(),
            //    Signpost = new Signpost()
            //});
            //TrailPoints.Add("AB072", new TrailPoint
            //{
            //    Name = "sv. Jan Nepomucký (odb)",
            //    Code = "AB072",
            //    TrailsCodes = new HashSet<string> { "6006" },
            //    Trails = new HashSet<Trail>(),
            //    Signpost = new Signpost()
            //});
            //TrailPoints.Add("AB056", new TrailPoint
            //{
            //    Name = "Velká Chuchle (bus)",
            //    Code = "AB056",
            //    TrailsCodes = new HashSet<string> { "6006" },
            //    Trails = new HashSet<Trail>(),
            //    Signpost = new Signpost()
            //});

            //var serialized = JsonSerializer.Serialize(TrailPoints.Values, typeof(IEnumerable<TrailPoint>));
            //File.WriteAllText(fileName, serialized);
        }

        private void LoadTrails()
        {
            // read from JSON          
            string fileName = "trails.json";

            var serialized = File.ReadAllText(fileName);
            Trails = JsonSerializer.Deserialize<IEnumerable<Trail>>(serialized).ToDictionary(t => t.Code, t => t);

            //Trails.Add("6006", new Trail
            //{
            //    Code = "6006",
            //    Colour = TrailColour.Yellow,
            //    Length = 5.5m,
            //    StartPointName = "Hlubočepy (tram)",
            //    StartPoint = TrailPoints["AB061"],
            //    TrailPointsCodes = new List<string> { "AB061", "AB063", "AB062", "AB072", "AB056" },
            //    TrailPoints = new List<TrailPoint>()
            //});
        }

        private void BuildTrails()
        {
            foreach (var trail in Trails.Values)
            {
                trail.TrailPoints = new List<TrailPoint>();
                foreach (var code in trail.TrailPointsCodes)
                {
                    var trailPoint = TrailPoints[code];                   
                    trail.TrailPoints.Add(trailPoint);
                }
            }
        }

        private void BuildTrailPoints()
        {
            foreach (var trailPoint in TrailPoints.Values)
            {
                trailPoint.Trails = new HashSet<Trail>();
                foreach (var trailCode in trailPoint.TrailsCodes)
                {
                    var trail = Trails[trailCode];                   
                    trailPoint.Trails.Add(trail);
                }
            }
        }

        private void LoadTrips()
        {
            // read from JSON   
            string fileName = "trips.json";

            var serialized = File.ReadAllText(fileName);
            Trips = JsonSerializer.Deserialize<IEnumerable<Trip>>(serialized).ToDictionary(t => t.Code, t => t);

            //Trips.Add("20200509", new Trip
            //{
            //    Code = "20200509",
            //    TripDate = new DateTime(2020, 5, 9).Date,
            //    TrailPointVisits = new List<TrailPointVisit>
            //    {
            //        new TrailPointVisit
            //        {
            //            TrailPointCode = "AB061",
            //            VisitDateTime = new DateTime(2020,5,9,12,8,59),
            //        },
            //        new TrailPointVisit
            //        {
            //            TrailPointCode = "AB063",
            //            VisitDateTime = new DateTime(2020,5,9,12,54,26)
            //        },
            //        new TrailPointVisit
            //        {
            //            TrailPointCode = "AB072",
            //            VisitDateTime = new DateTime(2020,5,9,14,14,19)
            //        },
            //        new TrailPointVisit
            //        {
            //            TrailPointCode = "AB072",
            //            VisitDateTime = new DateTime(2020,5,9,14,14,19)
            //        },
            //           new TrailPointVisit
            //        {
            //            TrailPointCode = "AB056",
            //            VisitDateTime = new DateTime(2020,5,9,14,38,30)
            //        }
            //    }
            //});

            //var serialized = JsonSerializer.Serialize(Trips.Values, typeof(IEnumerable<Trip>));
            //File.WriteAllText(fileName, serialized);
        }
    }
}
