using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace VenueService.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [EnableCors("AllowCors")]
    public class VenueController : ControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenueController"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public VenueController(IVenueService service)
        {
            Service = service;
        }

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <value>
        /// The service.
        /// </value>
        private IVenueService Service { get; }

        /// <summary>
        /// Gets the venues.
        /// </summary>
        /// <returns></returns>
        [HttpGet("/venues")]
        public async Task<IActionResult> GetVenues()
        {
            try
            {
                var venues = await Service.GetVenues();
                if(venues == null)
                {
                    return NotFound();
                }
                return Ok(venues);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
