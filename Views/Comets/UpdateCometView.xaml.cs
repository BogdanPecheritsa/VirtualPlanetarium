using System;
using System.Windows;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.Comets
{
    public partial class UpdateCometView : Window
    {
        private readonly CometRepository _cometRepository;
        private readonly Comet _cometToEdit;

        public UpdateCometView(Comet cometToEdit)
        {
            InitializeComponent();
            _cometRepository = new CometRepository();
            _cometToEdit = cometToEdit;

            CometNameTextBox.Text = cometToEdit.CometName;
            PerihelionDistanceTextBox.Text = cometToEdit.PerihelionDistance?.ToString();
            AphelionDistanceTextBox.Text = cometToEdit.AphelionDistance?.ToString();
            OrbitalPeriodTextBox.Text = cometToEdit.OrbitalPeriod?.ToString();
            InclinationTextBox.Text = cometToEdit.Inclination?.ToString();
            NucleusDiameterTextBox.Text = cometToEdit.NucleusDiameter?.ToString();
            CompositionTextBox.Text = cometToEdit.Composition;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CometNameTextBox.Text))
            {
                MessageBox.Show("Comet Name is required.");
                return;
            }

            _cometToEdit.CometName = CometNameTextBox.Text;
            _cometToEdit.PerihelionDistance = double.TryParse(PerihelionDistanceTextBox.Text, out var perihelion) ? perihelion : null;
            _cometToEdit.AphelionDistance = double.TryParse(AphelionDistanceTextBox.Text, out var aphelion) ? aphelion : null;
            _cometToEdit.OrbitalPeriod = double.TryParse(OrbitalPeriodTextBox.Text, out var period) ? period : null;
            _cometToEdit.Inclination = double.TryParse(InclinationTextBox.Text, out var inclination) ? inclination : null;
            _cometToEdit.NucleusDiameter = double.TryParse(NucleusDiameterTextBox.Text, out var diameter) ? diameter : null;
            _cometToEdit.Composition = CompositionTextBox.Text;

            _cometRepository.UpdateCometAsync(_cometToEdit);
            MessageBox.Show("Comet updated successfully.");
            Close();
        }
    }
}