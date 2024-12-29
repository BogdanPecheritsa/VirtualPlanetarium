using System;
using System.Collections.Generic;

namespace VirtualPlanetarium.Models;

public partial class Nebulae
{
    public Guid NebulaeId { get; set; }

    public Guid ObjectId { get; set; }

    public string? NebulaeName { get; set; }

    public string? NebulaeType { get; set; }

    public double? Size { get; set; }

    public string? Composition { get; set; }

    public double? Brightness { get; set; }

    public virtual CelestialObject Object { get; set; } = null!;
}