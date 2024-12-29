using System;
using System.Windows;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.Galaxies
{
    public partial class UpdateGalaxyView : Window
    {
        private readonly GalaxyRepository _galaxyRepository;
        private readonly Galaxy _galaxyToEdit;

        public UpdateGalaxyView(Galaxy galaxyToEdit)
        {
            InitializeComponent();
            _galaxyRepository = new GalaxyRepository();
            _galaxyToEdit = galaxyToEdit;

            GalaxyNameTextBox.Text = galaxyToEdit.GalaxyName;
            GalaxyTypeTextBox.Text = galaxyToEdit.GalaxyType;
            DiameterTextBox.Text = galaxyToEdit.Diameter?.ToString();
            RedshiftTextBox.Text = galaxyToEdit.Redshift?.ToString();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GalaxyNameTextBox.Text))
            {
                MessageBox.Show("Galaxy Name is required.");
                return;
            }

            _galaxyToEdit.GalaxyName = GalaxyNameTextBox.Text;
            _galaxyToEdit.GalaxyType = GalaxyTypeTextBox.Text;
            _galaxyToEdit.Diameter = double.TryParse(DiameterTextBox.Text, out var diameter) ? diameter : null;
            _galaxyToEdit.Redshift = double.TryParse(RedshiftTextBox.Text, out var redshift) ? redshift : null;

            _galaxyRepository.UpdateGalaxyAsync(_galaxyToEdit);
            MessageBox.Show("Galaxy updated successfully.");
            Close();
        }
    }
}