using System;
using System.Collections.Generic;

namespace VirtualPlanetarium.Models;

public partial class Comet
{
    public Guid CometId { get; set; } = Guid.NewGuid();

    public string? CometName { get; set; }

    public double? PerihelionDistance { get; set; }

    public double? AphelionDistance { get; set; }

    public double? OrbitalPeriod { get; set; }

    public double? Inclination { get; set; }

    public double? NucleusDiameter { get; set; }

    public string? Composition { get; set; }

    public virtual CelestialObject Object { get; set; } = null!;
}
