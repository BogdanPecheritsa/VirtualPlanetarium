using System;
using System.Windows;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.Stars
{
    public partial class CreateStarView : Window
    {
        private readonly StarRepository _starRepository = new();

        public CreateStarView()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StarNameTextBox.Text))
            {
                MessageBox.Show("Star Name is required.");
                return;
            }

            var star = new Star
            {
                StarName = StarNameTextBox.Text,
                SpectralClass = SpectralClassTextBox.Text,
                Mass = double.TryParse(MassTextBox.Text, out var mass) ? mass : null,
                Radius = double.TryParse(RadiusTextBox.Text, out var radius) ? radius : null,
                Temperature = int.TryParse(TemperatureTextBox.Text, out var temperature) ? temperature : null,
                Luminosity = double.TryParse(LuminosityTextBox.Text, out var luminosity) ? luminosity : null,
                Age = double.TryParse(AgeTextBox.Text, out var age) ? age : null
            };

            _starRepository.AddStarAsync(star);
            MessageBox.Show("Star created successfully.");
            Close();
        }
    }
}