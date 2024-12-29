using System;
using System.Windows;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.Nebulaes
{
    public partial class CreateNebulaeView : Window
    {
        private readonly NebulaeRepository _nebulaeRepository = new();

        public CreateNebulaeView()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NebulaeNameTextBox.Text))
            {
                MessageBox.Show("Nebulae Name is required.");
                return;
            }

            var nebulae = new Nebulae
            {
                NebulaeName = NebulaeNameTextBox.Text,
                NebulaeType = NebulaeTypeTextBox.Text,
                Size = double.TryParse(SizeTextBox.Text, out var size) ? size : null,
                Composition = CompositionTextBox.Text,
                Brightness = double.TryParse(BrightnessTextBox.Text, out var brightness) ? brightness : null
            };

            _nebulaeRepository.AddNebulaeAsync(nebulae);
            MessageBox.Show("Nebulae created successfully.");
            Close();
        }
    }
}