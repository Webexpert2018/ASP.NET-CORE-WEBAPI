using System;
using System.Collections.Generic;
using System.Text;

namespace VenueService.Abstractions.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Venues
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the full name of the country.
        /// </summary>
        /// <value>
        /// The full name of the country.
        /// </value>
        public string CountryFullName { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }
        /// <summary>
        /// Gets or sets the rate per hour.
        /// </summary>
        /// <value>
        /// The rate per hour.
        /// </value>
        public decimal RatePerHour { get; set; }
        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public int Currency { get; set; }
        /// <summary>
        /// Gets or sets the lat.
        /// </summary>
        /// <value>
        /// The lat.
        /// </value>
        public double Lat { get; set; }
        /// <summary>
        /// Gets or sets the lon.
        /// </summary>
        /// <value>
        /// The lon.
        /// </value>
        public double Lon { get; set; }
        /// <summary>
        /// Gets or sets the maximum participants.
        /// </summary>
        /// <value>
        /// The maximum participants.
        /// </value>
        public int MaxParticipants { get; set; }
    }
}
