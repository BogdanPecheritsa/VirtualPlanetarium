using System;
using System.Collections.Generic;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Models;

public partial class CelestialObject
{
    public Guid ObjectId { get; set; }

    public string Name { get; set; }

    public string? ObjectType { get; set; }

    public double? Mass { get; set; }

    public double? Radius { get; set; }

    public double? Distance { get; set; }

    public string? Color { get; set; }

    public double? Temperature { get; set; }

    public virtual ICollection<Comet> Comets { get; set; } = new List<Comet>();

    public virtual ICollection<Galaxy> Galaxies { get; set; } = new List<Galaxy>();

    public virtual ICollection<Nebulae> Nebulaes { get; set; } = new List<Nebulae>();

    public virtual ICollection<Planet> Planets { get; set; } = new List<Planet>();

    public virtual ICollection<Star> Stars { get; set; } = new List<Star>();
}
