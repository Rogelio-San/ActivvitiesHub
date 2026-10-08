using EventsHub.Application.Core;
using EventsHub.Domain;

namespace EventsHub.UnitTests.Core;

[TestFixture]
public class CustomMapperTests
{
    [Test]
    public void Map_WhenProfileRegistersPair_AppliesMappingAndReturnsSameDestination()
    {
        var mapper = new CustomMapper([new TestMappingProfile()]);
        var destination = new TestDestination { Value = "before" };

        var result = mapper.Map(new TestSource { Value = "after" }, destination);

        Assert.That(result, Is.SameAs(destination));
        Assert.That(destination.Value, Is.EqualTo("after"));
    }

    [Test]
    public void Map_WhenPairIsNotConfigured_ThrowsWithBothTypeNames()
    {
        var mapper = new CustomMapper([]);

        var exception = Assert.Throws<InvalidOperationException>(() =>
            mapper.Map(new TestSource { Value = "value" }, new TestDestination { Value = "value" }));

        Assert.That(exception!.Message, Does.Contain(nameof(TestSource)));
        Assert.That(exception.Message, Does.Contain(nameof(TestDestination)));
    }

    [Test]
    public void Constructor_WhenPairIsRegisteredMoreThanOnce_ThrowsWithBothTypeNames()
    {
        var exception = Assert.Throws<InvalidOperationException>(() =>
            new CustomMapper([new TestMappingProfile(), new DuplicateTestMappingProfile()]));

        Assert.That(exception!.Message, Does.Contain(nameof(TestSource)));
        Assert.That(exception.Message, Does.Contain(nameof(TestDestination)));
    }

    [Test]
    public void Map_WhenEventProfileIsRegistered_MapsEveryEventPropertyOntoExistingDestination()
    {
        var mapper = new CustomMapper([new EventMappingProfile()]);
        var source = CreateEvent("source-id", "Source title", new DateTime(2026, 4, 3), "Source description",
            "Source category", true, "Source city", "Source venue", "1.25", "2.50");
        var destination = CreateEvent("destination-id", "Old title", DateTime.MinValue, "Old description",
            "Old category", false, "Old city", "Old venue", "0", "0");

        var result = mapper.Map(source, destination);

        Assert.That(result, Is.SameAs(destination));
        Assert.Multiple(() =>
        {
            Assert.That(destination.Id, Is.EqualTo(source.Id));
            Assert.That(destination.Title, Is.EqualTo(source.Title));
            Assert.That(destination.Date, Is.EqualTo(source.Date));
            Assert.That(destination.Description, Is.EqualTo(source.Description));
            Assert.That(destination.Category, Is.EqualTo(source.Category));
            Assert.That(destination.isCancelled, Is.EqualTo(source.isCancelled));
            Assert.That(destination.City, Is.EqualTo(source.City));
            Assert.That(destination.Venue, Is.EqualTo(source.Venue));
            Assert.That(destination.Latitude, Is.EqualTo(source.Latitude));
            Assert.That(destination.Longitude, Is.EqualTo(source.Longitude));
        });
    }

    [Test]
    public void Map_WhenAnotherProfileIsRegistered_UsesItWithoutChangingMapper()
    {
        var mapper = new CustomMapper([new FutureMappingProfile()]);
        var destination = new FutureDestination { Label = "old" };

        mapper.Map(new FutureSource { Name = "future" }, destination);

        Assert.That(destination.Label, Is.EqualTo("future"));
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

    private sealed class TestMappingProfile : MappingProfile
    {
        public TestMappingProfile()
        {
            CreateMap<TestSource, TestDestination>((source, destination) => destination.Value = source.Value);
        }
    }

    private sealed class DuplicateTestMappingProfile : MappingProfile
    {
        public DuplicateTestMappingProfile()
        {
            CreateMap<TestSource, TestDestination>((source, destination) => destination.Value = source.Value);
        }
    }

    private sealed class FutureMappingProfile : MappingProfile
    {
        public FutureMappingProfile()
        {
            CreateMap<FutureSource, FutureDestination>((source, destination) => destination.Label = source.Name);
        }
    }

    private sealed class FutureSource
    {
        public required string Name { get; init; }
    }

    private sealed class FutureDestination
    {
        public required string Label { get; set; }
    }

    private sealed class TestSource
    {
        public required string Value { get; init; }
    }

    private sealed class TestDestination
    {
        public required string Value { get; set; }
    }
}
