using EventsHub.Application.Core;
using EventsHub.Application.Events.Commands;
using EventsHub.Domain;
using EventsHub.Persistence;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace EventsHub.UnitTests.Events.Commands;

[TestFixture]
public class EditEventHandlerTests
{
    [Test]
    public async Task Handle_WhenEventExists_MapsOntoTrackedEntityAndPersistsChanges()
    {
        await using var connection = new SqliteConnection("Data Source=:memory:");
        await connection.OpenAsync();

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlite(connection)
            .Options;

        await using var context = new AppDbContext(options);
        await context.Database.EnsureCreatedAsync();

        var existing = CreateEvent("event-1", "Before", new DateTime(2026, 1, 1), "Before description",
            "Before category", false, "Before city", "Before venue", "1", "2");
        context.Events.Add(existing);
        await context.SaveChangesAsync();

        var submitted = CreateEvent("event-1", "After", new DateTime(2026, 2, 2), "After description",
            "After category", true, "After city", "After venue", "3", "4");
        var mapper = new CustomMapper([new EventMappingProfile()]);
        var handler = new EditEvent.Handler(context, mapper);

        await handler.Handle(new EditEvent.Command { Event = submitted }, CancellationToken.None);

        Assert.That(context.Events.Local.Single(item => item.Id == existing.Id), Is.SameAs(existing));

        context.ChangeTracker.Clear();
        var saved = await context.Events.SingleAsync(item => item.Id == submitted.Id);

        Assert.Multiple(() =>
        {
            Assert.That(saved.Id, Is.EqualTo(submitted.Id));
            Assert.That(saved.Title, Is.EqualTo(submitted.Title));
            Assert.That(saved.Date, Is.EqualTo(submitted.Date));
            Assert.That(saved.Description, Is.EqualTo(submitted.Description));
            Assert.That(saved.Category, Is.EqualTo(submitted.Category));
            Assert.That(saved.isCancelled, Is.EqualTo(submitted.isCancelled));
            Assert.That(saved.City, Is.EqualTo(submitted.City));
            Assert.That(saved.Venue, Is.EqualTo(submitted.Venue));
            Assert.That(saved.Latitude, Is.EqualTo(submitted.Latitude));
            Assert.That(saved.Longitude, Is.EqualTo(submitted.Longitude));
        });
    }

    private static Event CreateEvent(string id, string title, DateTime date, string description,
        string category, bool isCancelled, string city, string venue, string latitude, string longitude) => new()
    {
        Id = id,
        Title = title,
        Date = date,
        Description = description,
        Category = category,
        isCancelled = isCancelled,
        City = city,
        Venue = venue,
        Latitude = latitude,
        Longitude = longitude
    };
}
