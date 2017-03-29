using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.SoundChat.ViewModels
{
    public class ChatListViewModel : BindableObject
    {
        #region FIELDS

        private string _username;
        private ObservableCollection<ChatViewModel> _chats;

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

        public ObservableCollection<ChatViewModel> Chats
        {
            get { return _chats; }
            set
            {
                if(_chats != value)
                {
                    _chats = value;
                    OnPropertyChanged("Chats");
                }
            }
        }

        #endregion

        #region CONSTRUCTORS

        public ChatListViewModel(string username)
        {
            Username = username;
#if DEBUG
            PopulateDummyChatListView();
#else
            PopulateChatListView();
#endif
        }

        #endregion

        #region test

        private void PopulateDummyChatListView()
        {
            ObservableCollection<ChatViewModel> chats = null;
            chats = new ObservableCollection<ChatViewModel>();

            chats.Add(CreateDummyChat1());
            chats.Add(CreateDummyChat2());

            _chats = chats;
        }

        private ChatViewModel CreateDummyChat2()
        {
            ChatViewModel result = null;

            result = new ChatViewModel("DummyChat002");

            return result;
        }

        private ChatViewModel CreateDummyChat1()
        {
            ChatViewModel result = null;

            result = new ChatViewModel("DummyChat001");

            return result;
        }

        #endregion

        #region PRIVATE METHODS

        private void PopulateChatListView()
        {
            ObservableCollection<ChatViewModel> chats = new ObservableCollection<ChatViewModel>();
            ChatViewModel auxChat = null;


            _chats = chats;
        }

#endregion

#region COMMANDS

#endregion
    }
}
