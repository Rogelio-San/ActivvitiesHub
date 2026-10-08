namespace EventsHub.Application.Core;

public abstract class MappingProfile
{
    private readonly List<MappingDefinition> _mappings = [];

    internal IReadOnlyCollection<MappingDefinition> Mappings => _mappings;

    protected void CreateMap<TSource, TDestination>(Action<TSource, TDestination> map)
        where TDestination : class
    {
        ArgumentNullException.ThrowIfNull(map);

        _mappings.Add(new MappingDefinition(
            new MappingKey(typeof(TSource), typeof(TDestination)),
            (source, destination) => map((TSource)source, (TDestination)destination)));
    }
}

internal readonly record struct MappingKey(Type SourceType, Type DestinationType);

internal sealed record MappingDefinition(MappingKey Key, Action<object, object> Apply);
