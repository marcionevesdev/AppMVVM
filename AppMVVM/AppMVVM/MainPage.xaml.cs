using AppMVVM.ViewModels;

namespace AppMVVM;

public partial class MainPage : ContentPage
{
    public MainPage(CarListViewModel carListViewModel)
    {
        InitializeComponent();
        BindingContext = carListViewModel;
    }
}

