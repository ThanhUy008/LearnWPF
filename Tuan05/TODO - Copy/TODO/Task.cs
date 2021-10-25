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
        private int _STT;
        public int STT
        {
            get => _STT;
            set
            {
                _STT = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("STT"));
                }
            }
        }
        
        private string _TaskName;
        public string TaskName
        {
            get => _TaskName;
            set
            {
                _TaskName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("TaskName"));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
