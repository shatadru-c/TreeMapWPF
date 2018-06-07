using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatMap
{
    public interface IDataPoint
    {
        string LocalValue { get; }
        int HeatMap { get;  }
    }
}
