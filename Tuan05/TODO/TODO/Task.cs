using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    public class Task : INotifyPropertyChanged,ICloneable
    {
        public int STT { set; get; }
        public string TaskName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{STT} {TaskName}";
        }
    }
}
