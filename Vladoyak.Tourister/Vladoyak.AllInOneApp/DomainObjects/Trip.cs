using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Vladoyak.AllInOneApp.DomainObjects
{
    /// <summary>
    /// Sequence of trailpoints and trail segments in time.
    /// </summary>
    public class Trip
    {
        /// <summary>
        /// Id of the trip.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Date of the trip.
        /// </summary>
        public DateTime TripDate { get; set; }

        /// <summary>
        /// Visited trail points of our trip.
        /// </summary>
        public IList<TrailPointVisit> TrailPointVisits { get; set; }

        /// <summary>
        /// Start of the trip.
        /// </summary>
        [JsonIgnore]
        public TrailPointVisit StartTrailPointVisit => TrailPointVisits?[0];

        /// <summary>
        /// End of the trip.
        /// </summary>
        [JsonIgnore]
        public TrailPointVisit EndTrailPointVisit => TrailPointVisits?[TrailPointVisits.Count - 1];

        /// <summary>
        /// Duration of the trip.
        /// </summary>
        [JsonIgnore]
        public TimeSpan Duration => (StartTrailPointVisit is null || EndTrailPointVisit is null)
                                    ? TimeSpan.Zero :
                                    EndTrailPointVisit.VisitDateTime - StartTrailPointVisit.VisitDateTime;


        public override string ToString()
        {
            return $"{TripDate:d} - {Duration}";
        }

        public void Calculate()
        {

        }
    }
}
