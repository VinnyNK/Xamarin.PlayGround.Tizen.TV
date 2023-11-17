using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.PlayGround.App.Pages.Grid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();
        }

        async void OnGrid1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid1Page());
        }

        async void OnGrid2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid2Page());
        }

        async void OnGrid3Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync((new Grid3Page()));
        }
    }
}