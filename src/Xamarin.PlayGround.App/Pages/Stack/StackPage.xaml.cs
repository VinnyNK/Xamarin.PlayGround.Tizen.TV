using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.PlayGround.App.Pages.Stack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();
        }

        async void OnStack1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stack1Page());
        }

        async void OnStack2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stack2Page());
        }

        async void OnStack3Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stack3Page());
        }

        async void OnStack4Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stack4Page());
        }

        async void OnStack5Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stack5Page());
        }

        async void OnStack6Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stack6Page());
        }
    }
}