using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.PlayGround.App.Pages.Relative
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativePage : ContentPage
    {
        public RelativePage()
        {
            InitializeComponent();
        }

        async void OnRelative1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Relative1Page());
        }

        async void OnRelative2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Relative2Page());
        }
    }
}