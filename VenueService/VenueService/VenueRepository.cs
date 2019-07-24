using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueService.Abstractions.Context;
using VenueService.Abstractions.Model;

namespace VenueService
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VenueService.IVenueRepository" />
    public class VenueRepository : IVenueRepository
    {
        /// <summary>
        /// The venue database context
        /// </summary>
        private readonly VenueDbContext VenueDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="VenueRepository"/> class.
        /// </summary>
        /// <param name="venueDbContext">The venue database context.</param>
        public VenueRepository(VenueDbContext venueDbContext)
        {
            VenueDbContext = venueDbContext;
        }

        /// <summary>
        /// Gets the venues.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Venues>> GetVenues()
        {
            try
            {
                var list = VenueDbContext.Venues.ToList();
                return list;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
