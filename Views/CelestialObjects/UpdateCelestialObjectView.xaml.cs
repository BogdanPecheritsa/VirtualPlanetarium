using System;
using System.Windows;
using VirtualPlanetarium.Interfaces;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.CelestialObjects
{
    public partial class UpdateCelestialObjectView : Window
    {
        private readonly ICelestialObjectRepository _celestialObjectRepository;
        private readonly CelestialObject _celestialObjectToEdit;

        public UpdateCelestialObjectView(CelestialObject celestialObjectToEdit)
        {
            InitializeComponent();
            _celestialObjectRepository = new CelestialObjectRepository();
            _celestialObjectToEdit = celestialObjectToEdit;

            InitializeFields();
        }

        private void InitializeFields()
        {
            NameTextBox.Text = _celestialObjectToEdit.Name;
            ObjectTypeTextBox.Text = _celestialObjectToEdit.ObjectType;
            MassTextBox.Text = _celestialObjectToEdit.Mass.ToString();
            RadiusTextBox.Text = _celestialObjectToEdit.Radius.ToString();
            DistanceTextBox.Text = _celestialObjectToEdit.Distance.ToString();
            ColorTextBox.Text = _celestialObjectToEdit.Color;
            TemperatureTextBox.Text = _celestialObjectToEdit.Temperature?.ToString();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ObjectTypeTextBox.Text) ||
                string.IsNullOrWhiteSpace(MassTextBox.Text) ||
                string.IsNullOrWhiteSpace(RadiusTextBox.Text) ||
                string.IsNullOrWhiteSpace(DistanceTextBox.Text) ||
                string.IsNullOrWhiteSpace(ColorTextBox.Text))
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

            _celestialObjectToEdit.Name = NameTextBox.Text.Trim();
            _celestialObjectToEdit.ObjectType = ObjectTypeTextBox.Text.Trim();
            _celestialObjectToEdit.Mass = mass;
            _celestialObjectToEdit.Radius = radius;
            _celestialObjectToEdit.Distance = distance;
            _celestialObjectToEdit.Color = ColorTextBox.Text.Trim();
            _celestialObjectToEdit.Temperature = string.IsNullOrEmpty(TemperatureTextBox.Text)
                ? null
                : double.Parse(TemperatureTextBox.Text);

            _celestialObjectRepository.UpdateCelestialObjectAsync(_celestialObjectToEdit);

            MessageBox.Show("Celestial Object updated successfully!");
            this.Close();
        }
    }
}