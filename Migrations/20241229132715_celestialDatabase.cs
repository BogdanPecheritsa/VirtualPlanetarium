using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPlanetarium.Migrations
{
    /// <inheritdoc />
    public partial class celestialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CelestialObjects",
                columns: table => new
                {
                    ObjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ObjectType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Mass = table.Column<double>(type: "float", nullable: false),
                    Radius = table.Column<double>(type: "float", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperature = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Celestia__9A6192B18111D5D6", x => x.ObjectID);
                });

            migrationBuilder.CreateTable(
                name: "Comets",
                columns: table => new
                {
                    CometID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ObjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PerihelionDistance = table.Column<double>(type: "float", nullable: true),
                    AphelionDistance = table.Column<double>(type: "float", nullable: true),
                    OrbitalPeriod = table.Column<double>(type: "float", nullable: true),
                    Inclination = table.Column<double>(type: "float", nullable: true),
                    NucleusDiameter = table.Column<double>(type: "float", nullable: true),
                    Composition = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Comets__6D2DFA460122FA05", x => x.CometID);
                    table.ForeignKey(
                        name: "FK__Comets__ObjectID__412EB0B6",
                        column: x => x.ObjectID,
                        principalTable: "CelestialObjects",
                        principalColumn: "ObjectID");
                });

            migrationBuilder.CreateTable(
                name: "Galaxies",
                columns: table => new
                {
                    GalaxyID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ObjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GalaxyType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Diameter = table.Column<double>(type: "float", nullable: true),
                    Redshift = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Galaxies__D77289FF4364299B", x => x.GalaxyID);
                    table.ForeignKey(
                        name: "FK__Galaxies__Object__3E52440B",
                        column: x => x.ObjectID,
                        principalTable: "CelestialObjects",
                        principalColumn: "ObjectID");
                });

            migrationBuilder.CreateTable(
                name: "Nebulae",
                columns: table => new
                {
                    NebulaID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ObjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NebulaeType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Size = table.Column<double>(type: "float", nullable: true),
                    Composition = table.Column<string>(type: "text", nullable: true),
                    Brightness = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Nebulae__5FEAEDEB32215280", x => x.NebulaID);
                    table.ForeignKey(
                        name: "FK__Nebulae__ObjectI__440B1D61",
                        column: x => x.ObjectID,
                        principalTable: "CelestialObjects",
                        principalColumn: "ObjectID");
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    PlanetID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ObjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrbitSemiMajorAxis = table.Column<double>(type: "float", nullable: true),
                    Eccentricity = table.Column<double>(type: "float", nullable: true),
                    Inclination = table.Column<double>(type: "float", nullable: true),
                    Mass = table.Column<double>(type: "float", nullable: true),
                    Radius = table.Column<double>(type: "float", nullable: true),
                    AtmosphericComposition = table.Column<string>(type: "text", nullable: true),
                    SurfaceFeatures = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Planets__1B0638C51DA90671", x => x.PlanetID);
                    table.ForeignKey(
                        name: "FK__Planets__ObjectI__3B75D760",
                        column: x => x.ObjectID,
                        principalTable: "CelestialObjects",
                        principalColumn: "ObjectID");
                });

            migrationBuilder.CreateTable(
                name: "Stars",
                columns: table => new
                {
                    StarID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ObjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpectralClass = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Mass = table.Column<double>(type: "float", nullable: true),
                    Radius = table.Column<double>(type: "float", nullable: true),
                    Temperature = table.Column<int>(type: "int", nullable: true),
                    Luminosity = table.Column<double>(type: "float", nullable: true),
                    Age = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stars__06ABC6475484F84A", x => x.StarID);
                    table.ForeignKey(
                        name: "FK__Stars__ObjectID__38996AB5",
                        column: x => x.ObjectID,
                        principalTable: "CelestialObjects",
                        principalColumn: "ObjectID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comets_ObjectID",
                table: "Comets",
                column: "ObjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Galaxies_ObjectID",
                table: "Galaxies",
                column: "ObjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Nebulae_ObjectID",
                table: "Nebulae",
                column: "ObjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Planets_ObjectID",
                table: "Planets",
                column: "ObjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Stars_ObjectID",
                table: "Stars",
                column: "ObjectID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comets");

            migrationBuilder.DropTable(
                name: "Galaxies");

            migrationBuilder.DropTable(
                name: "Nebulae");

            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropTable(
                name: "Stars");

            migrationBuilder.DropTable(
                name: "CelestialObjects");
        }
    }
}
