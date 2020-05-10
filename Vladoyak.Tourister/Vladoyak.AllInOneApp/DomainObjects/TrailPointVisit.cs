using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.AllInOneApp.DomainObjects
{
    /// <summary>
    /// Visit of one particular trail point in a time.
    /// </summary>
    public class TrailPointVisit
    {
        /// <summary>
        /// Code of visited trail point.
        /// </summary>
        public string TrailPointCode { get; set; }

        /// <summary>
        /// Visited trail point.
        /// </summary>
        public TrailPoint TrailPoint { get; set; }

        /// <summary>
        /// Moment of the visit.
        /// </summary>
        public DateTime VisitDateTime { get; set; }

        public override string ToString()
        {
            return $"{TrailPointCode} - {VisitDateTime}";
        }        
    }
}
