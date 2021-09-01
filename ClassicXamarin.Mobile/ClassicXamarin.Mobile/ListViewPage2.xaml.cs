using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClassicXamarin.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage2 : ContentPage
    {
        ObservableCollection<Book> _booksProvider;
        ObservableCollection<object> _selectedItems;
        Person _person;

        public ListViewPage2()
        {
            InitializeComponent();
            
            SelectedItems = new ObservableCollection<object>();
            
            BooksProvider = new ObservableCollection<Book>
            {
                new Book { Title = "Lord of the Rings" },
                new Book { Title = "Harry Potter" },
                new Book { Title = "The Train and the Car" },
                new Book { Title = "The Stone" },
            };
            
            Person = new Person
            {
                Name = "John Doe"
            };
            Person.Books.Add(BooksProvider[1]);

            foreach (var personBook in Person.Books)
            {
                SelectedItems.Add(personBook);
            }
        }

        public Person Person
        {
            get => _person;
            set
            {
                _person = value;
                OnPropertyChanged(nameof(Person));
            }
        }

        public ObservableCollection<Book> BooksProvider
        {
            get => _booksProvider;
            set
            {
                _booksProvider = value;
                OnPropertyChanged(nameof(BooksProvider));
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

    public class Person
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
    
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}