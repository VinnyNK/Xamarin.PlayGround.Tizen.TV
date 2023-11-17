using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.PlayGround.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        async void OnButtonLayoutClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LayoutSystemPage());
        }
        
        async void OnButtonNavigationClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPassDataPage());
        }
    }
}