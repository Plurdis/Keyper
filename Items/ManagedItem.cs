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
        static Dictionary<string, ManagedItem> ManagedDictionary = new Dictionary<string, ManagedItem>();

        static ManagedItem()
        {
        }

        public static void ImportItem()
        {

        }

        public ManagedItem()
        {
        }

        /// <summary>
        /// 고유 식별자 입니다. 초기 생성시 자동으로 생성됩니다.
        /// </summary>
        public string Identifier { get; }

        private DateTime _lastTime;

        /// <summary>
        /// 가장 최근에 빌린 시각을 나타냅니다.
        /// </summary>
        public DateTime LastTime
        {
            get => _lastTime;
            set
            {
                _lastTime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastTime"));
            }
        }

        private string _classification;

        /// <summary>
        /// 구분을 위한 부분입니다. (예. 교실, 실습실 등)
        /// </summary>
        public string Classification
        {
            get => _classification;
            set
            {
                _classification = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Classification"));
            }
        }

        private string _name;

        /// <summary>
        /// 관리되는 아이템의 이름입니다.
        /// </summary>
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

        /// <summary>
        /// 현재 키의 상태가 빌려져 있는지에 대한 여부입니다.
        /// </summary>
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
