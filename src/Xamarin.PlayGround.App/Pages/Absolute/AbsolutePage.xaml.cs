using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.PlayGround.App.Pages.Absolute
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();
        }

        async void OnAbsolute1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Absolute1Page());
        }

        async void OnAbsolute2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Absolute2Page());
        }
    }
}