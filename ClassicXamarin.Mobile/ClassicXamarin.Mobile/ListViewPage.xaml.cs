using System.Collections.ObjectModel;
using Xamarin.Forms.Xaml;

namespace ClassicXamarin.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage
    {
        ObservableCollection<string> _users;
        ObservableCollection<object> _selectedItems;

        public ListViewPage()
        {
            InitializeComponent();

            Users = new ObservableCollection<string>
            {
                "Hans",
                "Fritz",
                "Manuel"
            };
        }

        public ObservableCollection<string> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        public ObservableCollection<object> SelectedItems
        {
            get => _selectedItems;
            set
            {
                _selectedItems = value;
                OnPropertyChanged(nameof(SelectedItems));
            }
        }
    }
}