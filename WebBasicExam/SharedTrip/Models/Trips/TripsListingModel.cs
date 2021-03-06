using System;

namespace SharedTrip.Models.Trips
{
    public class TripsListingModel
    {
        public string Id { get; init; }

        public string StartPoint { get; init; }

        public string EndPoint { get; init; }

        public DateTime DepartureTime { get; init; }

        public int Seats { get; init; }

        public string Description { get; init; }
    }
}
