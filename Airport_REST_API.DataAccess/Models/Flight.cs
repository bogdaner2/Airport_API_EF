using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Airport_REST_API.DataAccess.Models
{
    public class Flight
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Number { get; set; }

        [Required]
        [MinLength(3)]
        public string PointOfDeparture { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        [MinLength(3)]
        public string Destination { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        public List<Ticket> Ticket { get; set; }
    }
}
