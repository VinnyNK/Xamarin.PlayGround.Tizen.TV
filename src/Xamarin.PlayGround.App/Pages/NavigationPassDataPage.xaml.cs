using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.PlayGround.App.ViewModels;

namespace Xamarin.PlayGround.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPassDataPage : ContentPage
    {
        private readonly NavigationViewModel _viewModel;
        public NavigationPassDataPage()
        {
            InitializeComponent();
            _viewModel = new NavigationViewModel();
            BindingContext = _viewModel;
        }
        
        async void OnNextButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DataPassedPage(_viewModel.Data));
        }
        
        async void OnPreviousPageButtonClicked (object sender, EventArgs e)
        {
            await Navigation.PopAsync ();
        }
    }
}