using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book : INotifyPropertyChanged,ICloneable
    {
        private string _bookName;
        public string bookName 
        {
            get
            {
                return _bookName;
            }
            set
            {
                _bookName = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("bookName"));
                }
            }
        }
        private string _coverImg;
        public string coverImg {
            get
            {
                return _coverImg;
            }
            set
            {
                _coverImg = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("coverImg"));
                }
            }
        }

        private string _author;
        public string author {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("author"));
                }
            }
        }

        private string _publicYear;
        public string publicYear
        {
            get
            {
                return _publicYear;
            }
            set
            {
                _publicYear = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("publicYear"));
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
