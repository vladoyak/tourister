using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Vladoyak.AllInOneApp.Data;
using Vladoyak.AllInOneApp.DomainObjects;

namespace Vladoyak.AllInOneApp
{
    public class TouristerApp
    {
        private DataSource _dataSource;    

        public void Init()
        {
            _dataSource = new DataSource();
            _dataSource.Init();
        }

        /// <summary>
        /// Get <see cref="Trail"></see> by code.
        /// </summary>
        /// <param name="code">Code of the trail.</param>
        /// <returns></returns>
        public Trail GetTrailByCode(string code)
        {
            if (!_dataSource.Trails.ContainsKey(code))
                return null;

            return _dataSource.Trails[code];
        }

        /// <summary>
        /// Get all saved trails.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Trail> GetTrails()
        {
            return _dataSource.Trails.Values;
        }

        /// <summary>
        /// Get <see cref="Trip"></see> by code.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Trip GetTripByCode(string code)
        {
            if (!_dataSource.Trips.ContainsKey(code))
                return null;

            return _dataSource.Trips[code];
        }

        /// <summary>
        /// Get all saved trips.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Trip> GetTrips()
        {
            return _dataSource.Trips.Values;
        }


    
    }
}
