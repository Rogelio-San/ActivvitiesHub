using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsHub.Domain
{
    public class Event
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string Title { get; set; }
        public DateTime Date { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public bool isCancelled { get; set; }
        public required string City { get; set; }
        public required string Venue { get; set; }
        public required string Latitude { get; set; }
        public required string Longitude { get; set; }

    }
}