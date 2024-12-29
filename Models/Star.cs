using System;
using System.Collections.Generic;

namespace VirtualPlanetarium.Models;

public partial class Star
{
    public Guid StarId { get; set; } = Guid.NewGuid();
    public string? StarName { get; set; }

    public string? SpectralClass { get; set; }

    public double? Mass { get; set; }

    public double? Radius { get; set; }

    public int? Temperature { get; set; }

    public double? Luminosity { get; set; }

    public double? Age { get; set; }

    public virtual CelestialObject Object { get; set; } = null!;
}
