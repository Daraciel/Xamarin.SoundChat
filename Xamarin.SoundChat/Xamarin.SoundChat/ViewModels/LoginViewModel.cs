
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.SoundChat.Views;

namespace Xamarin.SoundChat.ViewModels
{
    public class LoginViewModel : BindableObject
    {
        #region FIELDS
        private string _username;
        private string _password;
        private string _loginResult;

        private INavigation _navigation;
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

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public string LoginResult
        {
            get { return _loginResult; }
            set
            {
                if (_loginResult != value)
                {
                    _loginResult = value;
                    OnPropertyChanged("LoginResult");
                }
            }
        }
        #endregion

        #region COMMANDS

        public ICommand LoginCommand
        {
            get
            {
                return new Command(TryLogin);
            }
        }

        #endregion

        #region CONSTRUCTORS

        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        #endregion

        private void TryLogin()
        {
            bool result = false;

            if(!string.IsNullOrEmpty(Username) &&
                !string.IsNullOrEmpty(Password))
            {
                result = true;
            }

            if(result)
            {
                var mainView = new ChatListView(Username);
                _navigation.InsertPageBefore(mainView, _navigation.NavigationStack[0]);
                _navigation.PopAsync().ConfigureAwait(false);
            }
            else
            {
                LoginResult = "El login falló";
            }

        }
    }
}
