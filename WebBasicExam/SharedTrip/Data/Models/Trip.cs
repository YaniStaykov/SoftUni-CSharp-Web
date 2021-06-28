using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static SharedTrip.Data.DataConstants;

namespace SharedTrip.Data.Models
{
    public class Trip
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        public string StartPoint { get; init; }

        [Required]
        public string EndPoint { get; init; }

        [Required]
        public DateTime DepartureTime { get; init; }

        [Required]
        [MaxLength(TripMaxSeats)]
        public int Seats { get; init; }

        [Required]
        [MaxLength(TripMaxDescription)]
        public string Description { get; init; }
        
        public string ImagePath { get; init; }

        public ICollection<UserTrip> UserTrips { get; set; }
    }
}
