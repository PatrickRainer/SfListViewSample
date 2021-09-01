using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClassicXamarin.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewPage());
        }

        void Second_ListViewPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewPage2());
        }
    }
}