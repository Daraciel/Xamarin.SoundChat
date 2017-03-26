using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.SoundChat.ViewModels
{
    public class ChatListViewModel : BindableObject
    {
        #region FIELDS

        private string _username;

        #endregion

        #region PROPERTIES

        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged("Username");
                }
            }
        }

        #endregion

        #region CONSTRUCTORS

        public ChatListViewModel(string username)
        {
            Username = username;
        }

        #endregion

        #region COMMANDS

        #endregion
    }
}
