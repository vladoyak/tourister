using System;
using System.Collections.Generic;
using System.Text;

namespace Vladoyak.AllInOneApp.DomainObjects
{
    /// <summary>
    /// Base class for all point signs.
    /// </summary>
    public abstract class TouristSign
    {
        /// <summary>
        /// Sign id.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Year of building the sign.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Optional header.
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Optional footer.
        /// </summary>
        public string Footer { get; set; }
    }
}
