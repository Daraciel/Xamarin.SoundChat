
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.SoundChat.ViewModels.Base;

namespace Xamarin.SoundChat.ViewModels
{
    public class ChatViewModel : BindableObject
    {
        #region FIELDS

        private string _id;
        private string _name;
        private Image _avatar;
        private ObservableCollection<ContactViewModel> _participants;
        private ObservableCollection<IMessageViewModel> _messages;

        #endregion

        #region PROPERTIES

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("ID");
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
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

        public ObservableCollection<ContactViewModel> Participants
        {
            get
            {
                return _participants;
            }
            set
            {
                if(_participants != value)
                {
                    _participants = value;
                    OnPropertyChanged("Participants");
                }
            }
        }

        public ObservableCollection<IMessageViewModel> Messages
        {
            get
            {
                return _messages;
            }
            set
            {
                if(_messages != value)
                {
                    _messages = value;
                    OnPropertyChanged("Messages");
                }
            }
        }

        #endregion

        #region CONSTRUCTORS

        public ChatViewModel(string id)
        {
            _id = id;
#if DEBUG
            PopulateDummyChatView();
#else
            PopulateChatView();
#endif
        }

        #endregion

        #region test
        
        private void PopulateDummyChatView()
        {
            switch(_id)
            {
                case "DummyChat001":
                    FillWithDummyGroupChat();
                    break;
                case "DummyChat002":
                    FillWithDummySingleChat();
                    break;
            }
        }

        private void FillWithDummySingleChat()
        {
            _name = "Dummy group chat 2";
            _participants = CreateDummyParticipants();
            _messages = CreateDummyMessages();
        }

        private void FillWithDummyGroupChat()
        {
            _name = "Dummy group chat";
            _participants = CreateDummyParticipants();
            _messages = CreateDummyMessages();
        }

        private ObservableCollection<ContactViewModel> CreateDummyParticipants()
        {
            ObservableCollection<ContactViewModel> result = null;
            result = new ObservableCollection<ContactViewModel>();

            result.Add(new ContactViewModel("Jorge", "+34 615478885", null));
            result.Add(new ContactViewModel("Mariela", "+34 684521446", null));
            result.Add(new ContactViewModel("Mikael", "+34 632222551", null));
            
            return result;
        }

        private ObservableCollection<IMessageViewModel> CreateDummyMessages()
        {
            ObservableCollection<IMessageViewModel> result = null;
            result = new ObservableCollection<IMessageViewModel>();

            return result;
        }
        #endregion

        #region PUBLIC FUNCTIONS

        #endregion

    }
}
