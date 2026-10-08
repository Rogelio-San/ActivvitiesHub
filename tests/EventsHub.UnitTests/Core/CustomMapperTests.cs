using EventsHub.Application.Core;

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

    private sealed class TestSource
    {
        public required string Value { get; init; }
    }

    private sealed class TestDestination
    {
        public required string Value { get; set; }
    }
}
