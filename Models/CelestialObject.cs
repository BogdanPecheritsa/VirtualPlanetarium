using System;
using System.Collections.Generic;

namespace VirtualPlanetarium.Models;

public partial class CelestialObject
{
    public Guid ObjectId { get; set; } = Guid.NewGuid();

    public string? Name { get; set; } = null!;

    public string? ObjectType { get; set; } = null!;

    public double? Mass { get; set; } = null!;

    public double? Radius { get; set; } = null!;

    public double? Distance { get; set; } = null!;

    public string? Color { get; set; } = null!;

    public double? Temperature { get; set; } = null!;

    public virtual ICollection<Comet> Comets { get; set; } = new List<Comet>();

    public virtual ICollection<Galaxy> Galaxies { get; set; } = new List<Galaxy>();

    public virtual ICollection<Nebulae> Nebulaes { get; set; } = new List<Nebulae>();

    public virtual ICollection<Planet> Planets { get; set; } = new List<Planet>();

    public virtual ICollection<Star> Stars { get; set; } = new List<Star>();
}
