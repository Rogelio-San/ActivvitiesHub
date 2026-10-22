using EventsHub.Api.Controllers;
using EventsHub.Application.Events.Queries;
using EventsHub.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EventsHub.UnitTests.Controllers;

[TestFixture]
public class EventsControllerTests
{
    private EventsController _eventsController;
    private ServiceProvider _serviceProvider;

    [SetUp]
    public void Setup()
    {
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddSingleton(GlobalTestSetup.AppDbContext);
        services.AddMediatR(options =>
            options.RegisterServicesFromAssemblyContaining<GetEventList.Handler>());
        _serviceProvider = services.BuildServiceProvider();

        _eventsController = new EventsController
        {
            ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { RequestServices = _serviceProvider }
            }
        };
    }

    [TearDown]
    public void TearDown()
    {
        _serviceProvider.Dispose();
    }

    [Test]
    public async Task GetEventsAsync_WhenEventsExists_ReturnsAllEvents()
    {
        // Arrange
        var expectedCount = await GlobalTestSetup.AppDbContext.Events.CountAsync();
        // Act
        var result = await _eventsController.GetEventsAsync(CancellationToken.None);
        // Assert
        Assert.That(result.Value, Is.Not.Null);
        Assert.That(result.Value, Has.Count.EqualTo(expectedCount));
    }

   [Test]
    public async Task GetEventDetailAsync_WhenEventExists_ReturnsMatchingEvent()
    {
        // Arrange
        var existing = await GlobalTestSetup.AppDbContext.Events.FirstAsync();
        // Act
        var result = await _eventsController.GetEventDetailAsync(existing.Id);
        // Assert
        Assert.That(result.Value, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(result.Value.Id, Is.EqualTo(existing.Id));
            Assert.That(result.Value.Title, Is.EqualTo(existing.Title));
        });
    }

    [Test]
    public void GetEventDetailAsync_WhenEventDoesntExist_ThrowsNotFoundException()
    {
        var nonExistentId = Guid.NewGuid().ToString();

        var exception = Assert.ThrowsAsync<Exception>(async () =>
            await _eventsController.GetEventDetailAsync(nonExistentId));

        Assert.That(exception!.Message, Is.EqualTo("Activity not found"));
    }
}
 
