using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.AllInOneApp.DomainObjects
{
    /// <summary>
    /// Construction with information about place and directions.
    /// </summary>
    public class Signpost
    {
        /// <summary>
        /// Sign with name of place and other interesting information.
        /// </summary>
        public NameSign NameSign { get; set; }

        /// <summary>
        /// Signs with direction information.
        /// </summary>
        public IEnumerable<DirectionSign> DirectionSigns { get; set; }       
    }
}
