using System;
using System.Windows;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.Planets
{
    public partial class UpdatePlanetView : Window
    {
        private readonly PlanetRepository _planetRepository;
        private readonly Planet _planetToEdit;

        public UpdatePlanetView(Planet planetToEdit)
        {
            InitializeComponent();
            _planetRepository = new PlanetRepository();
            _planetToEdit = planetToEdit;

            PlanetNameTextBox.Text = planetToEdit.PlanetName;
            OrbitSemiMajorAxisTextBox.Text = planetToEdit.OrbitSemiMajorAxis?.ToString();
            EccentricityTextBox.Text = planetToEdit.Eccentricity?.ToString();
            MassTextBox.Text = planetToEdit.Mass?.ToString();
            RadiusTextBox.Text = planetToEdit.Radius?.ToString();
            AtmosphericCompositionTextBox.Text = planetToEdit.AtmosphericComposition;
            SurfaceFeaturesTextBox.Text = planetToEdit.SurfaceFeatures;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PlanetNameTextBox.Text))
            {
                MessageBox.Show("Planet Name is required.");
                return;
            }

            _planetToEdit.PlanetName = PlanetNameTextBox.Text;
            _planetToEdit.OrbitSemiMajorAxis = double.TryParse(OrbitSemiMajorAxisTextBox.Text, out var semiMajorAxis) ? semiMajorAxis : null;
            _planetToEdit.Eccentricity = double.TryParse(EccentricityTextBox.Text, out var eccentricity) ? eccentricity : null;
            _planetToEdit.Mass = double.TryParse(MassTextBox.Text, out var mass) ? mass : null;
            _planetToEdit.Radius = double.TryParse(RadiusTextBox.Text, out var radius) ? radius : null;
            _planetToEdit.AtmosphericComposition = AtmosphericCompositionTextBox.Text;
            _planetToEdit.SurfaceFeatures = SurfaceFeaturesTextBox.Text;

            _planetRepository.UpdatePlanetAsync(_planetToEdit);
            MessageBox.Show("Planet updated successfully.");
            Close();
        }
    }
}