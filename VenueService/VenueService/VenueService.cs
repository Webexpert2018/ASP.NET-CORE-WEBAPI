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
    /// <seealso cref="VenueService.IVenueService" />
    public class VenueService : IVenueService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenueService"/> class.
        /// </summary>
        /// <param name="venueRepository">The venue repository.</param>
        public VenueService(IVenueRepository venueRepository)
        {
            VenueRepository = venueRepository;
        }

        /// <summary>
        /// Gets the venue repository.
        /// </summary>
        /// <value>
        /// The venue repository.
        /// </value>
        private IVenueRepository VenueRepository { get; }

        /// <summary>
        /// Gets the venues.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Venues>> GetVenues()
        {
            return await VenueRepository.GetVenues();
        }
    }
}
