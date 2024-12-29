using System;
using System.Windows;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.Galaxies
{
    public partial class CreateGalaxyView : Window
    {
        private readonly GalaxyRepository _galaxyRepository = new();

        public CreateGalaxyView()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GalaxyNameTextBox.Text))
            {
                MessageBox.Show("Galaxy Name is required.");
                return;
            }

            var galaxy = new Galaxy
            {
                GalaxyName = GalaxyNameTextBox.Text,
                GalaxyType = GalaxyTypeTextBox.Text,
                Diameter = double.TryParse(DiameterTextBox.Text, out var diameter) ? diameter : null,
                Redshift = double.TryParse(RedshiftTextBox.Text, out var redshift) ? redshift : null
            };

            _galaxyRepository.AddGalaxyAsync(galaxy);
            MessageBox.Show("Galaxy created successfully.");
            Close();
        }
    }
}