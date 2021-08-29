using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using PrismApp.Mobile.Commands;
using PrismApp.Mobile.Views;

namespace PrismApp.Mobile.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly IPageDialogService _pageDialogService;
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

        public DelegateCommand<object> PageDialogCommand { get; private set; }
        

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
        {
            _pageDialogService = pageDialogService;
            Title = "Main Page";
            DelegateButtonCommand = new DelegateCommand<object>(Submit, CanSubmit);
            PageDialogCommand = new DelegateCommand<object>(PageDialogCommandExecute);
        }

        void PageDialogCommandExecute(object obj)
        {
            _pageDialogService.DisplayAlertAsync("Dialog", "dialog via service","cancel");
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