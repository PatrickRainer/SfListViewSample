using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using PrismApp.Mobile.Commands;
using PrismApp.Mobile.Services;
using PrismApp.Mobile.Views;
using Unity;

namespace PrismApp.Mobile.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly IPageDialogService _pageDialogService;
        string _title;
        string _userName;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        public DelegateCommand<object> DelegateButtonCommand
        {
            get;
            private set;
        }

        public DelegateCommand<object> PageDialogCommand { get; private set; }
        public DelegateCommand<object> NewPageCommand { get; private set; }
        public DelegateCommand<object> SfListViewPageCommand { get; private set; }
        

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IUser user) : base(navigationService)
        {
            _pageDialogService = pageDialogService;
            Title = "Main Page";
            DelegateButtonCommand = new DelegateCommand<object>(Submit, CanSubmit);
            PageDialogCommand = new DelegateCommand<object>(PageDialogCommandExecute);
            NewPageCommand = new DelegateCommand<object>(NewPageCommandExecute);
            SfListViewPageCommand = new DelegateCommand<object>(OnSfListViewPageCommand);
            UserName = user.Name;
        }

        void OnSfListViewPageCommand(object obj)
        {
            NavigationService.NavigateAsync(nameof(SfListViewPage));
        }

        void NewPageCommandExecute(object obj)
        {
            NavigationService.NavigateAsync("SecondPage");
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