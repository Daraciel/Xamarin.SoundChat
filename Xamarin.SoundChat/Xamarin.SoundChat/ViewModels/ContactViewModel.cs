
using Xamarin.Forms;
using Xamarin.SoundChat.Models;

namespace Xamarin.SoundChat.ViewModels
{
    public class ContactViewModel : BindableObject
    {
        #region FIELDS

        private Contact _contact;

        #endregion

        #region PROPERTIES

        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                if(_contact != value)
                {
                    _contact = value;
                    OnPropertyChanged("Contact");
                }
            }
        }

        #endregion

        #region CONSTRUCTORS

        public ContactViewModel(string Id)
        {
            this.Contact = new Contact();
        }

        #endregion

        #region PUBLIC FUNCTIONS

        #endregion
    }
}
