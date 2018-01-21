using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Controls;

namespace Sample
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        private TimeSpan _selectedTime;

        public MainPage()
        {
            InitializeComponent();
        }

        public TimeSpan SelectedTime
        {
            get => _selectedTime;
            set
            {
                if (_selectedTime == value)
                    return;
                _selectedTime = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}