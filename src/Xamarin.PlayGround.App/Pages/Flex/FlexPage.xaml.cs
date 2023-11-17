using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.PlayGround.App.Pages.Flex
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlexPage : ContentPage
    {
        public FlexPage()
        {
            InitializeComponent();
        }

        async void OnFlex1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Flex1Page());
        }

        async void OnFlex2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Flex2Page());
        }

        async void OnFlex3Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Flex3Page());
        }
    }
}