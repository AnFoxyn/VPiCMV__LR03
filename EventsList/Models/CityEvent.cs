using System;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EventsList.Models
{
    public class EventCategory : INotifyPropertyChanged
    {
        private string __CategoryName;

        public EventCategory() { }
        public string IconPath { get; set; }
        public string CategoryName { 
            get => __CategoryName;
            set 
            {
                __CategoryName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(__CategoryName)));
            }             
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}