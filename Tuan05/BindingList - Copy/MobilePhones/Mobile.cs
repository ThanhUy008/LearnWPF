using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhones
{
    public class Mobile : INotifyPropertyChanged,ICloneable
    {
       
            private string _phoneName;
            public string phoneName
            {
                get
                {
                    return _phoneName;
                }
                set
                {
                    _phoneName = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("phoneName"));
                    }
                }
            }
            private string _phoneImg;
            public string phoneImg
            {
                get
                {
                    return _phoneImg;
                }
                set
                {
                    _phoneImg = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("phoneImg"));
                    }
                }
            }

            private string _manufacture;
            public string manufacture
            {
                get
                {
                    return _manufacture;
                }
                set
                {
                    _manufacture = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("manufacture"));
                    }
                }
            }

            private string _price;
            public string price
            {
                get
                {
                    return _price;
                }
                set
                {
                    _price = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("price"));
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            public object Clone()
            {
                return MemberwiseClone();
            }
      

    }
}
