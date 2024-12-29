using System;
using System.Windows;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.Planets
{
    public partial class CreatePlanetView : Window
    {
        private readonly PlanetRepository _planetRepository = new();

        public CreatePlanetView()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PlanetNameTextBox.Text))
            {
                MessageBox.Show("Planet Name is required.");
                return;
            }

            var planet = new Planet
            {
                PlanetName = PlanetNameTextBox.Text,
                OrbitSemiMajorAxis = double.TryParse(OrbitSemiMajorAxisTextBox.Text, out var semiMajorAxis) ? semiMajorAxis : null,
                Eccentricity = double.TryParse(EccentricityTextBox.Text, out var eccentricity) ? eccentricity : null,
                Mass = double.TryParse(MassTextBox.Text, out var mass) ? mass : null,
                Radius = double.TryParse(RadiusTextBox.Text, out var radius) ? radius : null,
                AtmosphericComposition = AtmosphericCompositionTextBox.Text,
                SurfaceFeatures = SurfaceFeaturesTextBox.Text
            };

            _planetRepository.AddPlanetAsync(planet);
            MessageBox.Show("Planet created successfully.");
            Close();
        }
    }
}