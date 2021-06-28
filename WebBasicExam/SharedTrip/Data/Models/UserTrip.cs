using System;
using System.ComponentModel.DataAnnotations;

using static SharedTrip.Data.DataConstants;

namespace SharedTrip.Data.Models
{
    public class UserTrip
    {
        [Key]
        [Required]
        [MaxLength(IdMaxLength)]
        public string UserId { get; init; } = Guid.NewGuid().ToString();

        public User User { get; init; }

        [Required]
        [MaxLength(IdMaxLength)]
        public string TripId { get; init; } = Guid.NewGuid().ToString();

        public Trip Trip { get; init; } 
    }
}
