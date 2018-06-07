using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace HeatMap
{
    public class HeatMapViewModel : INotifyPropertyChanged
    {
        private ICommand _startCommand;
        public HeatMapViewModel()
        {
            ValueRange = new ObservableCollection<DataPoint>();
            ValueRange.Add(new DataPoint("Kite", 3));
            ValueRange.Add(new DataPoint("Eagle", 10));
            ValueRange.Add(new DataPoint("Metro", 11));
            _startCommand = new RelayCommand(() => true, () => StartSlowSteady());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand StartCommand => _startCommand;
        public void OnPropertyChanged(string propertyName_)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName_));
        }
        public void StartSlowSteady()
        {
            ValueRange[0].HeatMap += 5;

        }

        public ObservableCollection<DataPoint> ValueRange { get; set; }



    }
}
