using CommunityToolkit.Mvvm.ComponentModel;

namespace AppMVVM.ViewModels
{
    public partial class BaseViewModelas : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotLoading))]
        bool isLoading;

        public bool IsNotLoading => !isLoading;
    }

}
