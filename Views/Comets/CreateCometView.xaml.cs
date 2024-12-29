using System;
using System.Windows;
using VirtualPlanetarium.Interfaces;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.Comets
{
    public partial class CreateCometView : Window
    {
        private readonly ICometRepository _cometRepository;

        public CreateCometView()
        {
            InitializeComponent();
            _cometRepository = new CometRepository();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(CometNameTextBox.Text))
            {
                MessageBox.Show("Please fill in the Comet Name.");
                return;
            }

            var comet = new Comet
            {
                CometName = CometNameTextBox.Text,
                PerihelionDistance = double.TryParse(PerihelionDistanceTextBox.Text, out var peri) ? peri : null,
                AphelionDistance = double.TryParse(AphelionDistanceTextBox.Text, out var aph) ? aph : null,
                OrbitalPeriod = double.TryParse(OrbitalPeriodTextBox.Text, out var period) ? period : null,
                Inclination = double.TryParse(InclinationTextBox.Text, out var incl) ? incl : null,
                NucleusDiameter = double.TryParse(NucleusDiameterTextBox.Text, out var diameter) ? diameter : null,
                Composition = CompositionTextBox.Text
            };

            _cometRepository.AddCometAsync(comet);
            MessageBox.Show("Comet created successfully.");
            Close();
        }
    }
}