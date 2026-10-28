using EventsHub.Domain;

namespace EventsHub.Application.Core;

public sealed class EventMappingProfile : MappingProfile
{
    public EventMappingProfile()
    {
        CreateMap<Event, Event>((source, destination) =>
        {
            destination.Id = source.Id;
            destination.Title = source.Title;
            destination.Date = source.Date;
            destination.Description = source.Description;
            destination.Category = source.Category;
            destination.isCancelled = source.isCancelled;
            destination.City = source.City;
            destination.Venue = source.Venue;
            destination.Latitude = source.Latitude;
            destination.Longitude = source.Longitude;
        });
    }
}
