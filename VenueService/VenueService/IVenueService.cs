using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VenueService.Abstractions.Model;

namespace VenueService
{
    /// <summary>
    /// 
    /// </summary>
    public interface IVenueService
    {
        /// <summary>
        /// Gets the venues.
        /// </summary>
        /// <returns></returns>
        Task<List<Venues>> GetVenues();
    }
}
