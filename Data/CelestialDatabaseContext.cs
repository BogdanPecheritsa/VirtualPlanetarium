﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VirtualPlanetarium.Models;

namespace VirtualPlanetarium.Models;

public partial class CelestialDatabaseContext : DbContext
{
    public CelestialDatabaseContext()
    {
    }

    public CelestialDatabaseContext(DbContextOptions<CelestialDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CelestialObject> CelestialObjects { get; set; }

    public virtual DbSet<Comet> Comets { get; set; }

    public virtual DbSet<Galaxy> Galaxies { get; set; }

    public virtual DbSet<Nebulae> Nebulaes { get; set; }

    public virtual DbSet<Planet> Planets { get; set; }

    public virtual DbSet<Star> Stars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CelestialDatabase;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CelestialObject>(entity =>
        {
            entity.HasKey(e => e.ObjectId).HasName("PK__Celestia__9A6192B18111D5D6");

            entity.Property(e => e.ObjectId)
                .ValueGeneratedNever()
                .HasColumnName("ObjectID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ObjectType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Comet>(entity =>
        {
            entity.HasKey(e => e.CometId).HasName("PK__Comets__6D2DFA460122FA05");

            entity.HasIndex(e => e.ObjectId, "IX_Comets_ObjectID");

            entity.Property(e => e.CometId).HasColumnName("CometID");
            entity.Property(e => e.Composition).HasColumnType("text");
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

            entity.HasOne(d => d.Object).WithMany(p => p.Comets)
                .HasForeignKey(d => d.ObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comets__ObjectID__412EB0B6");
        });

        modelBuilder.Entity<Galaxy>(entity =>
        {
            entity.HasKey(e => e.GalaxyId).HasName("PK__Galaxies__D77289FF4364299B");

            entity.HasIndex(e => e.ObjectId, "IX_Galaxies_ObjectID");

            entity.Property(e => e.GalaxyId).HasColumnName("GalaxyID");
            entity.Property(e => e.GalaxyType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

            entity.HasOne(d => d.Object).WithMany(p => p.Galaxies)
                .HasForeignKey(d => d.ObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Galaxies__Object__3E52440B");
        });

        modelBuilder.Entity<Nebulae>(entity =>
        {
            entity.HasKey(e => e.NebulaeId).HasName("PK__Nebulae__5FEAEDEB32215280");

            entity.ToTable("Nebulae");

            entity.HasIndex(e => e.ObjectId, "IX_Nebulae_ObjectID");

            entity.Property(e => e.NebulaeId).HasColumnName("NebulaID");
            entity.Property(e => e.Composition).HasColumnType("text");
            entity.Property(e => e.NebulaeType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

            entity.HasOne(d => d.Object).WithMany(p => p.Nebulaes)
                .HasForeignKey(d => d.ObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Nebulae__ObjectI__440B1D61");
        });

        modelBuilder.Entity<Planet>(entity =>
        {
            entity.HasKey(e => e.PlanetId).HasName("PK__Planets__1B0638C51DA90671");

            entity.HasIndex(e => e.ObjectId, "IX_Planets_ObjectID");

            entity.Property(e => e.PlanetId).HasColumnName("PlanetID");
            entity.Property(e => e.AtmosphericComposition).HasColumnType("text");
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.SurfaceFeatures).HasColumnType("text");

            entity.HasOne(d => d.Object).WithMany(p => p.Planets)
                .HasForeignKey(d => d.ObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Planets__ObjectI__3B75D760");
        });

        modelBuilder.Entity<Star>(entity =>
        {
            entity.HasKey(e => e.StarId).HasName("PK__Stars__06ABC6475484F84A");

            entity.HasIndex(e => e.ObjectId, "IX_Stars_ObjectID");

            entity.Property(e => e.StarId).HasColumnName("StarID");
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.SpectralClass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Object).WithMany(p => p.Stars)
                .HasForeignKey(d => d.ObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Stars__ObjectID__38996AB5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}