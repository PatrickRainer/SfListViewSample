using Prism.Commands;
using Prism.Navigation;
using PrismApp.Mobile.Commands;
using PrismApp.Mobile.Views;

namespace PrismApp.Mobile.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public DelegateCommand<object> DelegateButtonCommand
        {
            get;
            private set;
        }

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";
            DelegateButtonCommand = new DelegateCommand<object>(Submit, CanSubmit);
        }

        bool CanSubmit(object arg)
        {
            return true;
        }

        void Submit(object obj)
        {
            Title = "Button pressed";
        }
    }
}