using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;

namespace Vladoyak.AllInOneApp.DomainObjects
{
    /// <summary>
    /// Signed point of a trail.
    /// </summary>
    public class TrailPoint
    {
        /// <summary>
        /// Human name of trail point.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Stat name of trail point.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Trails codes for this point.
        /// </summary>
        public ICollection<string> TrailsCodes { get; set; }

        /// <summary>
        /// Trails for this point.
        /// </summary>
        [JsonIgnore]
        public ICollection<Trail> Trails { get; set; }

        /// <summary>
        /// Tables with information about place and directions.
        /// </summary>
        public Signpost Signpost { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Code}";
        }
    }
}
