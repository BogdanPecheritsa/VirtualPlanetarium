using System;
using System.Windows;
using VirtualPlanetarium.Interfaces;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;


namespace VirtualPlanetarium.Views.CelestialObjects
{
    public partial class CreateCelestialObjectView : Window
    {
        private readonly ICelestialObjectRepository _celestialObjectRepository;

        public CreateCelestialObjectView()
        {
            InitializeComponent();
            _celestialObjectRepository = new CelestialObjectRepository();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) ||
                string.IsNullOrEmpty(ObjectTypeTextBox.Text) ||
                string.IsNullOrEmpty(MassTextBox.Text) ||
                string.IsNullOrEmpty(RadiusTextBox.Text) ||
                string.IsNullOrEmpty(DistanceTextBox.Text) ||
                string.IsNullOrEmpty(ColorTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields (Temperature is optional).");
                return;
            }

            if (!double.TryParse(MassTextBox.Text, out double mass) ||
                !double.TryParse(RadiusTextBox.Text, out double radius) ||
                !double.TryParse(DistanceTextBox.Text, out double distance) ||
                (!string.IsNullOrEmpty(TemperatureTextBox.Text) && !double.TryParse(TemperatureTextBox.Text, out _)))
            {
                MessageBox.Show("Please provide valid numerical values for Mass, Radius, Distance, and Temperature.");
                return;
            }

            var celestialObject = new CelestialObject
            {
                Name = NameTextBox.Text,
                ObjectType = ObjectTypeTextBox.Text,
                Mass = mass,
                Radius = radius,
                Distance = distance,
                Color = ColorTextBox.Text,
                Temperature = string.IsNullOrEmpty(TemperatureTextBox.Text) ? null : double.Parse(TemperatureTextBox.Text)
            };

            _celestialObjectRepository.AddCelestialObjectAsync(celestialObject);

            MessageBox.Show("Celestial Object created successfully!");
            this.Close();
        }
    }
}