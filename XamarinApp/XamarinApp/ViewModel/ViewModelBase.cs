using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamarinApp.ViewModel
{
    public class ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T Storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(Storage, value))
                return false;

            Storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void onPropertyChanged([CallerMemberName] string propertiesName = "")
        {
            var handler = PropertyChanged;
            if (handler == null)
                return;
            handler(this, new PropertyChangedEventArgs(propertiesName));
        }
    }
}
