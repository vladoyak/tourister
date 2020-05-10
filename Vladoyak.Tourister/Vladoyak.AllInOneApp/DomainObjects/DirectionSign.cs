using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.AllInOneApp.DomainObjects
{
    /// <summary>
    /// Sign with information about routes from current point.
    /// </summary>
    public class DirectionSign: TouristSign
    {
        /// <summary>
        /// Sign colour.
        /// </summary>
        public TrailColour TrailColour { get; set; }

        /// <summary>
        /// List of possible directions from trail point.
        /// </summary>
        public List<Direction> Directions { get; set; }
    }
}
