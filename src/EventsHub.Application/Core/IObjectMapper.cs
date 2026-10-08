namespace EventsHub.Application.Core;

public interface IObjectMapper
{
    TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        where TDestination : class;
}
