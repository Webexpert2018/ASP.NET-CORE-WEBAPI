using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VenueService.Abstractions.Model;

namespace VenueService.Abstractions.Context
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class VenueDbContext: DbContext
    {
        /// <summary>
        /// Gets or sets the venue.
        /// </summary>
        /// <value>
        /// The venue.
        /// </value>
        public DbSet<Venues> Venues { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VenueDbContext"/> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        public VenueDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
