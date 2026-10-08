namespace EventsHub.Application.Core;

public sealed class CustomMapper : IObjectMapper
{
    private readonly IReadOnlyDictionary<MappingKey, Action<object, object>> _mappings;

    public CustomMapper(IEnumerable<MappingProfile> profiles)
    {
        ArgumentNullException.ThrowIfNull(profiles);

        var mappings = new Dictionary<MappingKey, Action<object, object>>();
        foreach (var profile in profiles)
        {
            foreach (var mapping in profile.Mappings)
            {
                if (!mappings.TryAdd(mapping.Key, mapping.Apply))
                {
                    throw new InvalidOperationException(
                        $"More than one mapping is configured from '{mapping.Key.SourceType.FullName}' " +
                        $"to '{mapping.Key.DestinationType.FullName}'.");
                }
            }
        }

        _mappings = mappings;
    }

    public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        where TDestination : class
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(destination);

        var key = new MappingKey(typeof(TSource), typeof(TDestination));
        if (!_mappings.TryGetValue(key, out var apply))
        {
            throw new InvalidOperationException(
                $"No mapping is configured from '{key.SourceType.FullName}' to '{key.DestinationType.FullName}'.");
        }

        apply(source, destination);
        return destination;
    }
}
