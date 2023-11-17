using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.PlayGround.App.Pages.Absolute;
using Xamarin.PlayGround.App.Pages.Flex;
using Xamarin.PlayGround.App.Pages.Grid;
using Xamarin.PlayGround.App.Pages.Relative;
using Xamarin.PlayGround.App.Pages.Stack;

namespace Xamarin.PlayGround.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LayoutSystemPage : ContentPage
    {
        public LayoutSystemPage()
        {
            InitializeComponent();
        }

        async void OnGridClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }

        async void OnAbsoluteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsolutePage());
        }

        async void OnFlexClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlexPage());
        }

        async void OnRelativeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativePage());
        }

        async void OnStackClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackPage());
        }
    }
}