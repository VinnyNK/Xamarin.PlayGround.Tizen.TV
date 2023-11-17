using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Xamarin.PlayGround.App.ViewModels
{
    public sealed class NavigationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string data;
        public string Data
        {
            get => data;
            set
            {
                  if (data == value) return;
                    data = value;
                    OnPropertyChanged("Data");
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}