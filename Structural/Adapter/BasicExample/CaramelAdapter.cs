using Adapter.BasicExample.ThirdFilters;

namespace Adapter.BasicExample;

/// <summary>
/// Adapter class that allows the Caramel filter to be used as an <see cref="IFilter"/>.
/// </summary>
public class CaramelAdapter : IFilter
{
    private readonly Caramel _caramel;

    /// <summary>
    /// Initializes a new instance of the <see cref="CaramelAdapter"/> class with the specified Caramel filter.
    /// </summary>
    /// <param name="caramel">The Caramel filter to adapt.</param>
    public CaramelAdapter(Caramel caramel)
    {
        _caramel = caramel;
    }

    /// <inheritdoc />
    public void Apply(Image image)
    {
        _caramel.Init();
        _caramel.Render(image);
    }
}