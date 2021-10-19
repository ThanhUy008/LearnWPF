using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBindingNotify
{
    class Student : INotifyPropertyChanged
    {
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string avatarPath { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
