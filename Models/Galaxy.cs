using System;
using System.Collections.Generic;

namespace VirtualPlanetarium.Models;

public partial class Galaxy
{
    public Guid GalaxyId { get; set; } = Guid.NewGuid();
    public string? GalaxyName { get; set; }

    public string? GalaxyType { get; set; }

    public double? Diameter { get; set; }

    public double? Redshift { get; set; }

    public virtual CelestialObject Object { get; set; } = null!;
}
