using System;
using System.Collections.Generic;

namespace VirtualPlanetarium.Models;

public partial class Planet
{
    public Guid PlanetId { get; set; }

    public Guid ObjectId { get; set; }

    public string? PlanetName { get; set; }

    public double? OrbitSemiMajorAxis { get; set; }

    public double? Eccentricity { get; set; }

    public double? Inclination { get; set; }

    public double? Mass { get; set; }

    public double? Radius { get; set; }

    public string? AtmosphericComposition { get; set; }

    public string? SurfaceFeatures { get; set; }

    public virtual CelestialObject Object { get; set; } = null!;
}