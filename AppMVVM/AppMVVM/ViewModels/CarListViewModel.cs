using AppMVVM.Models;
using AppMVVM.Services;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AppMVVM.ViewModels
{
    public partial class CarListViewModel : BaseViewModelas
    {
        private readonly CarService carService;
        public ObservableCollection<Car> Cars { get; private set; } = new ();

        public CarListViewModel(CarService carService)
        {
            Title = "Car List";
            this.carService = carService;
        }

        [ICommand]
        async Task GetCarListAsync()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Cars.Any()) Cars.Clear();

                var cars = carService.GetCars();
                foreach (var car in cars) Cars.Add(car);

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get cars: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Fail do retrive list of cars.", "OK");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
