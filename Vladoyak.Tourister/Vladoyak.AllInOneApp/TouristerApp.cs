using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Vladoyak.AllInOneApp.DomainObjects;

namespace Vladoyak.AllInOneApp
{
    public class TouristerApp
    {
        public Dictionary<string, TrailPoint> TrailPoints { get; set; } = new Dictionary<string, TrailPoint>();
        public Dictionary<string, Trail> Trails { get; set; } = new Dictionary<string, Trail>();
        public Dictionary<string, Signpost> Signposts { get; set; } = new Dictionary<string, Signpost>();

        public Dictionary<string, Trip> Trips { get; set; } = new Dictionary<string, Trip>();

        public void Init()
        {
            // trails
            LoadTrailPoints();
            LoadTrails();
            BuildTrails();
            BuildTrailPoints();

            // signs
            LoadSignposts();

            // trips
            LoadTrips();
        }

        private void LoadTrailPoints()
        {
            TrailPoints.Add("AB061", new TrailPoint
            {
                Name = "Hlubočepy (tram)",
                Code = "AB061",
                TrailsCodes = new HashSet<string> { "6006" },
                Trails = new HashSet<Trail>(),
                Signpost = new Signpost()
            });
            TrailPoints.Add("AB063", new TrailPoint
            {
                Name = "Malá Chuchle (bus)",
                Code = "AB063",
                TrailsCodes = new HashSet<string> { "6006" },
                Trails = new HashSet<Trail>(),
                Signpost = new Signpost()
            });
            TrailPoints.Add("AB062", new TrailPoint
            {
                Name = "Malá zoologická",
                Code = "AB062",
                TrailsCodes = new HashSet<string> { "6006" },
                Trails = new HashSet<Trail>(),
                Signpost = new Signpost()
            });
            TrailPoints.Add("AB072", new TrailPoint
            {
                Name = "sv. Jan Nepomucký (odb)",
                Code = "AB072",
                TrailsCodes = new HashSet<string> { "6006" },
                Trails = new HashSet<Trail>(),
                Signpost = new Signpost()
            });
            TrailPoints.Add("AB056", new TrailPoint
            {
                Name = "Velká Chuchle (bus)",
                Code = "AB056",
                TrailsCodes = new HashSet<string> { "6006" },
                Trails = new HashSet<Trail>(),
                Signpost = new Signpost()
            });

        }

        private void LoadTrails()
        {
            Trails.Add("6006", new Trail
            {
                Code = "6006",
                Colour = TrailColour.Yellow,
                Length = 5.5m,
                StartPointName = "Hlubočepy (tram)",
                StartPoint = TrailPoints["AB061"],
                TrailPointsCodes = new List<string> { "AB061", "AB063", "AB062", "AB072", "AB056" },
                TrailPoints = new List<TrailPoint>()
            });
        }

        private void BuildTrails()
        {
            foreach (var trail in Trails.Values)
            {
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
                foreach (var trailCode in trailPoint.TrailsCodes)
                {
                    var trail = Trails[trailCode];
                    trailPoint.Trails.Add(trail);
                }
            }
        }

        private void LoadSignposts()
        {
            Signposts.Add("AB061", new Signpost
            {
                TrailPointCode = "AB061",
                NameSign = new NameSign
                {
                    Code = "AB061m",
                    Name = "HLUBOČEPY tram",
                    PublicTransportType = PublicTransportType.Tram,
                    Altitude = 195,
                    Header = "KLUB ČESKýCH TURISTŮ",
                    Year = 2019
                },
                DirectionSigns = new List<DirectionSign>
                {
                    new DirectionSign
                    {
                        Code = "AB061b",
                        Header = "NS BARRANDOVSKÉ SKÁLY",
                        Footer = "PĚŠÍ TRASA KČT",
                        Year = 2014,
                        Directions = new List<Direction>{
                            new Direction{
                                DirectionPointCode = "AB063",
                                Length = 2
                            },
                            new Direction{
                                DirectionPointCode = "AB072",
                                Length = 4
                            },
                            new Direction{
                                DirectionPointCode = "AB056",
                                Length = 5.5m
                            },
                        }
                    }
                },
            }); ;
        }

        private void LoadTrips()
        {
            Trips.Add("20200509", new Trip
            {
                Code = "20200509",
                TripDate = new DateTime(2020, 5, 9).Date,
                TrailPointVisits = new List<TrailPointVisit>
                {
                    new TrailPointVisit
                    {
                        TrailPointCode = "AB061",
                        VisitDateTime = new DateTime(2020,5,9,12,8,59),
                    },
                    new TrailPointVisit
                    {
                        TrailPointCode = "AB063",
                        VisitDateTime = new DateTime(2020,5,9,12,54,26)
                    },
                    new TrailPointVisit
                    {
                        TrailPointCode = "AB072",
                        VisitDateTime = new DateTime(2020,5,9,14,14,19)
                    },
                    new TrailPointVisit
                    {
                        TrailPointCode = "AB072",
                        VisitDateTime = new DateTime(2020,5,9,14,14,19)
                    },
                       new TrailPointVisit
                    {
                        TrailPointCode = "AB056",
                        VisitDateTime = new DateTime(2020,5,9,14,38,30)
                    }
                }
            });
        }
    }
}
