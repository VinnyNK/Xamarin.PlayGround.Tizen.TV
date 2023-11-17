using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.PlayGround.App.Pages.Grid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grid3Page : ContentPage
    {
        public Grid3Page()
        {
            InitializeComponent();
        }
        
        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            boxView.Color = new Color(redSlider.Value, greenSlider.Value, blueSlider.Value);
        }
    }
}