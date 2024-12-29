using System;
using System.Windows;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.Stars
{
    public partial class UpdateStarView : Window
    {
        private readonly StarRepository _starRepository;
        private readonly Star _starToEdit;

        public UpdateStarView(Star starToEdit)
        {
            InitializeComponent();
            _starRepository = new StarRepository();
            _starToEdit = starToEdit;

            StarNameTextBox.Text = starToEdit.StarName;
            SpectralClassTextBox.Text = starToEdit.SpectralClass;
            MassTextBox.Text = starToEdit.Mass?.ToString();
            RadiusTextBox.Text = starToEdit.Radius?.ToString();
            TemperatureTextBox.Text = starToEdit.Temperature?.ToString();
            LuminosityTextBox.Text = starToEdit.Luminosity?.ToString();
            AgeTextBox.Text = starToEdit.Age?.ToString();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StarNameTextBox.Text))
            {
                MessageBox.Show("Star Name is required.");
                return;
            }

            _starToEdit.StarName = StarNameTextBox.Text;
            _starToEdit.SpectralClass = SpectralClassTextBox.Text;
            _starToEdit.Mass = double.TryParse(MassTextBox.Text, out var mass) ? mass : null;
            _starToEdit.Radius = double.TryParse(RadiusTextBox.Text, out var radius) ? radius : null;
            _starToEdit.Temperature = int.TryParse(TemperatureTextBox.Text, out var temperature) ? temperature : null;
            _starToEdit.Luminosity = double.TryParse(LuminosityTextBox.Text, out var luminosity) ? luminosity : null;
            _starToEdit.Age = double.TryParse(AgeTextBox.Text, out var age) ? age : null;

            _starRepository.UpdateStarAsync(_starToEdit);
            MessageBox.Show("Star updated successfully.");
            Close();
        }
    }
}