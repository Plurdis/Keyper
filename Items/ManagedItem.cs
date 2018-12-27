using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyper.Items
{
    public class ManagedItem : INotifyPropertyChanged
    {
        private DateTime _lastTime;

        public DateTime LastTime
        {
            get => _lastTime;
            set
            {
                _lastTime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastTime"));
            }
        }

        private string _type;

        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Type"));
            }
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private bool _isRental;

        public bool IsRental
        {
            get => _isRental;
            set
            {
                _isRental = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRental"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
