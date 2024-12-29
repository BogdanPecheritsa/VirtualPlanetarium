using System;
using System.Windows;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;

namespace VirtualPlanetarium.Views.Nebulaes
{
    public partial class UpdateNebulaeView : Window
    {
        private readonly NebulaeRepository _nebulaeRepository;
        private readonly Nebulae _nebulaeToEdit;

        public UpdateNebulaeView(Nebulae nebulaeToEdit)
        {
            InitializeComponent();
            _nebulaeRepository = new NebulaeRepository();
            _nebulaeToEdit = nebulaeToEdit;

            NebulaeNameTextBox.Text = nebulaeToEdit.NebulaeName;
            NebulaeTypeTextBox.Text = nebulaeToEdit.NebulaeType;
            SizeTextBox.Text = nebulaeToEdit.Size?.ToString();
            CompositionTextBox.Text = nebulaeToEdit.Composition;
            BrightnessTextBox.Text = nebulaeToEdit.Brightness?.ToString();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NebulaeNameTextBox.Text))
            {
                MessageBox.Show("Nebulae Name is required.");
                return;
            }

            _nebulaeToEdit.NebulaeName = NebulaeNameTextBox.Text;
            _nebulaeToEdit.NebulaeType = NebulaeTypeTextBox.Text;
            _nebulaeToEdit.Size = double.TryParse(SizeTextBox.Text, out var size) ? size : null;
            _nebulaeToEdit.Composition = CompositionTextBox.Text;
            _nebulaeToEdit.Brightness = double.TryParse(BrightnessTextBox.Text, out var brightness) ? brightness : null;

            _nebulaeRepository.UpdateNebulaeAsync(_nebulaeToEdit);
            MessageBox.Show("Nebulae updated successfully.");
            Close();
        }
    }
}