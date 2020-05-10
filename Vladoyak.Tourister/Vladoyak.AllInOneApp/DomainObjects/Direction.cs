using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Vladoyak.AllInOneApp.DomainObjects
{   
    /// <summary>
    /// Possible way from trail point.
    /// </summary>
    public class Direction
    {
        /// <summary>
        /// Where this direction ends - code.
        /// </summary>
        public string DirectionPointCode { get; set; }

        /// <summary>
        /// Where this direction ends.
        /// </summary>
        [JsonIgnore]
        public TrailPoint DirectionPoint { get; set; }

        /// <summary>
        /// Length of trail section.
        /// </summary>
        public decimal Length { get; set; }

        public override string ToString()
        {
            return $"{DirectionPointCode} - {Length} km";
        }
    }
}
