
using Xamarin.Forms;

namespace Xamarin.SoundChat.ViewModels
{
    public class ContactViewModel : BindableObject
    {
        #region FIELDS

        private string _name;
        private string _phone;
        private Image _avatar;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }

        public Image Avatar
        {
            get
            {
                return _avatar;
            }
            set
            {
                if (_avatar != value)
                {
                    _avatar = value;
                    OnPropertyChanged("Avatar");
                }
            }
        }

        #endregion

        #region CONSTRUCTORS

        public ContactViewModel(string name, string phone, Image img)
        {
            _name = name;
            _phone = phone;
            _avatar = img;
        }

        #endregion

        #region PUBLIC FUNCTIONS

        #endregion
    }
}
