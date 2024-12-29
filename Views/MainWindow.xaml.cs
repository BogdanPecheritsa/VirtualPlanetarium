using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VirtualPlanetarium.Models;
using VirtualPlanetarium.Repositories;
using VirtualPlanetarium.Views.CelestialObjects;
using VirtualPlanetarium.Views.Comets;
using VirtualPlanetarium.Views.Galaxies;
using VirtualPlanetarium.Views.Nebulaes;
using VirtualPlanetarium.Views.Planets;
using VirtualPlanetarium.Views.Stars;

namespace VirtualPlanetarium
{
    public partial class MainWindow : Window
    {
        private readonly CelestialObjectRepository _celestialObjectRepository;
        private readonly CometRepository _cometRepository;
        private readonly GalaxyRepository _galaxyRepository;
        private readonly NebulaeRepository _nebulaeRepository;
        private readonly PlanetRepository _planetRepository;
        private readonly StarRepository _starRepository;

        public MainWindow()
        {
            InitializeComponent();

            _celestialObjectRepository = new CelestialObjectRepository();
            _cometRepository = new CometRepository();
            _galaxyRepository = new GalaxyRepository();
            _nebulaeRepository = new NebulaeRepository();
            _planetRepository = new PlanetRepository();
            _starRepository = new StarRepository();

            LoadData();
        }

        private void LoadData()
        {
            LoadCelestialObjects();
            LoadComets();
            LoadGalaxies();
            LoadNebulaes();
            LoadPlanets();
            LoadStars();
        }

        private async void LoadCelestialObjects()
        {
            var celestialObjects = await _celestialObjectRepository.GetAllCelestialObjectsAsync();
            CelestialObjectsDataGrid.ItemsSource = celestialObjects;
        }

        private async void LoadComets()
        {
            var comets = await _cometRepository.GetAllCometsAsync();
            CometsDataGrid.ItemsSource = comets;
        }

        private async void LoadGalaxies()
        {
            var galaxies = await _galaxyRepository.GetAllGalaxiesAsync();
            GalaxiesDataGrid.ItemsSource = galaxies;
        }

        private async void LoadNebulaes()
        {
            var nebulaes = await _nebulaeRepository.GetAllNebulaeAsync();
            NebulaesDataGrid.ItemsSource = nebulaes;
        }

        private async void LoadPlanets()
        {
            var planets = await _planetRepository.GetAllPlanetsAsync();
            PlanetsDataGrid.ItemsSource = planets;
        }

        private async void LoadStars()
        {
            var stars = await _starRepository.GetAllStarsAsync();
            StarsDataGrid.ItemsSource = stars;
        }

        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private async void CelestialObjectsCreateButton_Click(object sender, RoutedEventArgs e)
        {
            var createCelestialObjectView = new CreateCelestialObjectView();
            createCelestialObjectView.ShowDialog();
            LoadCelestialObjects();
        }

        private async void CelestialObjectsUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (CelestialObjectsDataGrid.SelectedItem is CelestialObject selected)
            {
                var updateCelestialObjectView = new UpdateCelestialObjectView(selected);
                updateCelestialObjectView.ShowDialog();
                LoadCelestialObjects();
            }
        }

        private async void CelestialObjectsDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (CelestialObjectsDataGrid.SelectedItem is CelestialObject selected)
            {
                await _celestialObjectRepository.DeleteCelestialObjectAsync(selected.ObjectId);
                LoadCelestialObjects();
            }
        }

        private async void SearchCelestialObjectsButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = CelestialObjectsInput.Text;
            var celestialObjects = await _celestialObjectRepository.GetAllCelestialObjectsAsync();
            var filteredObjects = celestialObjects
                .Where(o => o.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToList();
            CelestialObjectsDataGrid.ItemsSource = filteredObjects;
        }

        private async void CometsCreateButton_Click(object sender, RoutedEventArgs e)
        {
            var createCometView = new CreateCometView();
            createCometView.ShowDialog();
            LoadComets();
        }

        private async void CometsUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (CometsDataGrid.SelectedItem is Comet selected)
            {
                var updateCometView = new UpdateCometView(selected);
                updateCometView.ShowDialog();
                LoadComets();
            }
        }

        private async void CometsDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (CometsDataGrid.SelectedItem is Comet selected)
            {
                await _cometRepository.DeleteCometAsync(selected.CometId);
                LoadComets();
            }
        }

        private async void GalaxiesCreateButton_Click(object sender, RoutedEventArgs e)
        {
            var createGalaxyView = new CreateGalaxyView();
            createGalaxyView.ShowDialog();
            LoadGalaxies();
        }

        private async void GalaxiesUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (GalaxiesDataGrid.SelectedItem is Galaxy selected)
            {
                var updateGalaxyView = new UpdateGalaxyView(selected);
                updateGalaxyView.ShowDialog();
                LoadGalaxies();
            }
        }

        private async void GalaxiesDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (GalaxiesDataGrid.SelectedItem is Galaxy selected)
            {
                await _galaxyRepository.DeleteGalaxyAsync(selected.GalaxyId);
                LoadGalaxies();
            }
        }

        private async void NebulaesCreateButton_Click(object sender, RoutedEventArgs e)
        {
            var createNebulaeView = new CreateNebulaeView();
            createNebulaeView.ShowDialog();
            LoadNebulaes();
        }

        private async void NebulaesUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (NebulaesDataGrid.SelectedItem is Nebulae selected)
            {
                var updateNebulaeView = new UpdateNebulaeView(selected);
                updateNebulaeView.ShowDialog();
                LoadNebulaes();
            }
        }

        private async void NebulaesDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (NebulaesDataGrid.SelectedItem is Nebulae selected)
            {
                await _nebulaeRepository.DeleteNebulaeAsync(selected.NebulaeId);
                LoadNebulaes();
            }
        }
        private async void SearchNebulaesButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = NebulaesSearchInput.Text;
            var nebulaes = await _nebulaeRepository.GetAllNebulaeAsync();
            var filteredNebulaes = nebulaes
                .Where(n => n.NebulaeType.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToList();
            NebulaesDataGrid.ItemsSource = filteredNebulaes;
        }

        private async void PlanetsCreateButton_Click(object sender, RoutedEventArgs e)
        {
            var createPlanetView = new CreatePlanetView();
            createPlanetView.ShowDialog();
            LoadPlanets();
        }

        private async void PlanetsUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlanetsDataGrid.SelectedItem is Planet selected)
            {
                var updatePlanetView = new UpdatePlanetView(selected);
                updatePlanetView.ShowDialog();
                LoadPlanets();
            }
        }

        private async void PlanetsDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlanetsDataGrid.SelectedItem is Planet selected)
            {
                await _planetRepository.DeletePlanetAsync(selected.PlanetId);
                LoadPlanets();
            }
        }
        private async void SearchPlanetsButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = PlanetsSearchInput.Text;
            var planets = await _planetRepository.GetAllPlanetsAsync();
            var filteredPlanets = planets
                .Where(p => p.PlanetName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToList();
            PlanetsDataGrid.ItemsSource = filteredPlanets;
        }

        private async void StarsCreateButton_Click(object sender, RoutedEventArgs e)
        {
            var createStarView = new CreateStarView();
            createStarView.ShowDialog();
            LoadStars();
        }

        private async void StarsUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (StarsDataGrid.SelectedItem is Star selected)
            {
                var updateStarView = new UpdateStarView(selected);
                updateStarView.ShowDialog();
                LoadStars();
            }
        }

        private async void StarsDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (StarsDataGrid.SelectedItem is Star selected)
            {
                await _starRepository.DeleteStarAsync(selected.StarId);
                LoadStars();
            }
        }

        private async void SearchStarsButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = StarsSearchInput.Text;
            var stars = await _starRepository.GetAllStarsAsync();
            var filteredStars = stars.Where(s => s.StarName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            StarsDataGrid.ItemsSource = filteredStars;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}