
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.SoundChat.Models;
using Xamarin.SoundChat.ViewModels.Base;

namespace Xamarin.SoundChat.ViewModels
{
    public class ChatViewModel : ViewModelBase
    {
        #region FIELDS

        private Chat _chat;

        #endregion

        #region PROPERTIES

        public Chat Chat
        {
            get
            {
                return _chat;
            }
            set
            {
                if (_chat != value)
                {
                    _chat = value;
                    OnPropertyChanged("Chat");
                }
            }
        }
        
        #endregion

        #region CONSTRUCTORS

        public ChatViewModel()
        {

        }

        public ChatViewModel(string Id)
        {
            
#if DEBUG
            PopulateDummyChatView(Id);
#else
            PopulateChatView();
#endif
        }

        #endregion

        #region test
        
        private void PopulateDummyChatView(string Id)
        {
            switch(Id)
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
            Chat aux = new Chat();

            aux.Id = "DummyChat001";
            aux.Name = "The dummy single chat";
            aux.Participants = new ObservableCollection<Contact>();
            aux.Messages = new ObservableCollection<Message>();

            this._chat = aux;
        }

        private void FillWithDummyGroupChat()
        {
            Chat aux = new Chat();

            aux.Id = "DummyChat002";
            aux.Name = "The dummy group chat";
            aux.Participants = CreateDummyParticipants();
            aux.Messages = CreateDummyMessages();

            this._chat = aux;
        }

        private ObservableCollection<Contact> CreateDummyParticipants()
        {
            ObservableCollection<Contact> result = null;
            Contact aux = null;
            result = new ObservableCollection<Contact>();

            aux = new Contact();
            aux.Id = "001";
            aux.NickName = "Daraciel";
            aux.Name = "Jorge";
            aux.PhoneNumber = "+34 615 645 584";
            aux.Email = "daraciel@gmail.com";
            aux.City = "Madrid";

            result.Add(aux);

            aux = new Contact();
            aux.Id = "002";
            aux.NickName = "Celestax";
            aux.Name = "Mariela";
            aux.PhoneNumber = "+34 600 500 400";
            aux.Email = "dummy2@gmail.com";
            aux.City = "Sax";

            result.Add(aux);

            aux = new Contact();
            aux.Id = "003";
            aux.NickName = "Mehka";
            aux.Name = "Mikael";
            aux.PhoneNumber = "+34 521 741 954";
            aux.Email = "dummy3@gmail.com";
            aux.City = "Sax";

            result.Add(aux);
            
            return result;
        }

        private ObservableCollection<Message> CreateDummyMessages()
        {
            ObservableCollection<Message> result = null;
            result = new ObservableCollection<Message>();

            return result;
        }
        #endregion

        #region PUBLIC FUNCTIONS

        #endregion

        #region VIEWMODELBASE

        public override void OnAppearing(object navigationContext)
        {
            base.OnAppearing(navigationContext);

            if (navigationContext is Chat)
            {
                Chat = (Chat)navigationContext;
            }
        }

        #endregion

    }
}
