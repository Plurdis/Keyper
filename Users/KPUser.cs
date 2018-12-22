using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml;

namespace Keyper.Users
{

    [Serializable]
    public class KPUser : INotifyPropertyChanged
    {
        [NonSerialized]
        ImageSource _image;

        byte[] encodedImage;

        public ImageSource Image
        {
            get => _image;
            set
            {
                _image = value;
                ChangedEventCall("Image");
            }
        }
        
        #region [  Serialize Image Conversion  ]

        [OnSerializing]
        void StreamImage(StreamingContext sc)
        {
            if (_image != null && _image is BitmapImage src)
            {
                MemoryStream stream = new MemoryStream();
                BmpBitmapEncoder encoder = new BmpBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(src.UriSource));
                encoder.Save(stream);
                stream.Flush();
                encodedImage = stream.ToArray();
            }
        }

        [OnDeserialized]
        void LoadImage(StreamingContext sc)
        {
            if (encodedImage != null)
            {
                MemoryStream stream = new MemoryStream(encodedImage);
                BmpBitmapDecoder decoder = new BmpBitmapDecoder(stream, BitmapCreateOptions.None, BitmapCacheOption.Default);
                _image = decoder.Frames[0];
            }
        }

        #endregion

        string _userName;
        
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                ChangedEventCall("UserName");
            }
        }


        UserLevel _userLevel;

        public UserLevel UserLevel
        {
            get => _userLevel;
            set
            {
                _userLevel = value;
                ChangedEventCall("UserLevel");
            }
        }

        public void ChangedEventCall(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [field:NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
