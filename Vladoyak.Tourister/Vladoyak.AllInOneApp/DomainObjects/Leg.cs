using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.AllInOneApp.DomainObjects
{
    /// <summary>
    /// Part of trip from one trailpoint to another.
    /// </summary>
    public class Leg
    {
        /// <summary>
        /// Start trail point visit.
        /// </summary>
        public TrailPointVisit StartTrailPointVisit { get; set; }    

        /// <summary>
        /// End trail point visit.
        /// </summary>
        public TrailPointVisit EndTrailPointVisit { get; set; }       

        public override string ToString()
        {
            return $"{StartTrailPointVisit.TrailPointCode} - {StartTrailPointVisit.VisitDateTime} -> {EndTrailPointVisit.TrailPointCode} - {EndTrailPointVisit.VisitDateTime}";
        }
    }
}
