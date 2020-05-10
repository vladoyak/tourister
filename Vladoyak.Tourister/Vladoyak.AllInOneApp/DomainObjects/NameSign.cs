using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Vladoyak.AllInOneApp.DomainObjects
{
    /// <summary>
    /// Sign with information about place.
    /// </summary>
    public class NameSign: TouristSign
    {
        /// <summary>
        /// Name of the trail point.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Possible public transport, also in sign name.
        /// </summary>
        public PublicTransportType PublicTransportType { get; set; }

        /// <summary>
        /// Altitude in mnm
        /// </summary>
        public int Altitude { get; set; }
    }
}
