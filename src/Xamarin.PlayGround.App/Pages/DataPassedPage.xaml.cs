using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.PlayGround.App.ViewModels;

namespace Xamarin.PlayGround.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPassedPage : ContentPage
    {
        public DataPassedPage(string data)
        {
            InitializeComponent();
            BindingContext = new NavigationViewModel { Data = data };
        }
        
        async void OnPreviousPageButtonClicked (object sender, EventArgs e)
        {
            await Navigation.PopAsync ();
        }
    }
}