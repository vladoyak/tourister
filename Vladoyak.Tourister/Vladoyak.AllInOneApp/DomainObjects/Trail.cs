using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Vladoyak.AllInOneApp.DomainObjects
{
    /// <summary>
    /// Marked trail from start point through several points to end point.
    /// </summary>
    public class Trail
    {
        /// <summary>
        /// Colour of a trail, signs etc.
        /// </summary>
        public TrailColour Colour { get; set; }

        /// <summary>
        /// Code of a trail (from wiki).
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Length of trail in km.
        /// </summary>
        public decimal Length { get; set; }

        [JsonIgnore]
        public string StartPointName { get; set; }

        [JsonIgnore]
        public TrailPoint StartPoint { get; set; }

        [JsonIgnore]
        public string EndPointName { get; set; }

        [JsonIgnore]
        public TrailPoint EndPoint { get; set; }

        /// <summary>
        /// List of all trail points codes from start to end of the trail.
        /// </summary>
        public IList<string> TrailPointsCodes { get; set; }

        /// <summary>
        /// List of all trail points from start to end of the trail.
        /// </summary>
        [JsonIgnore]
        public IList<TrailPoint> TrailPoints { get; set; }

        public override string ToString()
        {
            return $"{Code} - {Colour} - {Length} km";
        }
    }
}
