using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatMap
{
    public class DataPoint : IDataPoint,INotifyPropertyChanged
    {
        private int _heatMap;
        public DataPoint(string localValue_,int heatmap_)
        {
            LocalValue = localValue_;
            _heatMap = heatmap_;
        }
        public string LocalValue { get; private set ; }
        public int HeatMap
        {
            get
            {
                return _heatMap;
            }
            set
            {
                _heatMap = value;
                OnPropertyChanged(nameof(HeatMap));
            }
        }
            

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName_)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName_));
            }
        }
    }
}
