using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.SoundChat.Models;
using Xamarin.SoundChat.Services;
using Xamarin.SoundChat.ViewModels.Base;

namespace Xamarin.SoundChat.ViewModels
{
    public class ChatListViewModel : ViewModelBase
    {
        #region FIELDS

        private string _username;
        private ObservableCollection<Chat> _chats;
        private Chat _selectedItem;

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

        public ObservableCollection<Chat> Chats
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
            ObservableCollection<Chat> chats = null;
            chats = new ObservableCollection<Chat>();

            chats.Add(CreateDummyChat1());
            //chats.Add(CreateDummyChat2());

            _chats = chats;
        }

        private Chat CreateDummyChat2()
        {
            Chat result = null;

            result = CreateDummySingleChat();

            return result;
        }

        private Chat CreateDummyChat1()
        {
            Chat result = null;

            result = CreateDummyGroupChat();

            return result;
        }

        private Chat CreateDummySingleChat()
        {
            Chat result = new Chat();

            result.Id = "DummyChat001";
            result.Name = "The dummy single chat";
            result.Participants = CreateDummySingleParticipants();
            result.Messages = CreateDummySingleMessages();

            return result;
        }

        private Chat CreateDummyGroupChat()
        {
            Chat result = new Chat();

            result.Id = "DummyChat002";
            result.Name = "The dummy group chat";
            result.Participants = CreateDummyGroupParticipants();
            result.Messages = CreateDummyGroupMessages();

            return result;
        }

        private ObservableCollection<Contact> CreateDummyGroupParticipants()
        {
            ObservableCollection<Contact> result = null;
            Contact aux = null;
            result = new ObservableCollection<Contact>();

            aux = CreateContactJorge();
            result.Add(aux);

            aux = CreateContactMariela();
            result.Add(aux);

            aux = CreateContactMika();
            result.Add(aux);

            return result;
        }

        private ObservableCollection<Message> CreateDummyGroupMessages()
        {
            ObservableCollection<Message> result = null;
            Message aux = null;
            DateTime baseDate = DateTime.Now;

            result = new ObservableCollection<Message>();

            aux = new Message();
            aux.Emitter = CreateContactJorge();
            aux.Image = null;
            aux.TimeStamp = baseDate.AddMinutes(-3);

            result.Add(aux);

            aux = new Message();
            aux.Emitter = CreateContactMariela();
            aux.Image = null;
            aux.TimeStamp = baseDate.AddMinutes(-2);

            result.Add(aux);

            aux = new Message();
            aux.Emitter = CreateContactMika();
            aux.Image = null;
            aux.TimeStamp = baseDate.AddMinutes(-1);

            result.Add(aux);

            return result;
        }

        private ObservableCollection<Contact> CreateDummySingleParticipants()
        {
            ObservableCollection<Contact> result = null;
            Contact aux = null;
            result = new ObservableCollection<Contact>();

            aux = CreateContactJorge();
            result.Add(aux);

            aux = CreateContactMariela();
            result.Add(aux);

            aux = CreateContactMika();
            result.Add(aux);

            return result;
        }

        private ObservableCollection<Message> CreateDummySingleMessages()
        {
            ObservableCollection<Message> result = null;
            result = new ObservableCollection<Message>();

            return result;
        }

        private Contact CreateContactJorge()
        {
            Contact result;
            result = new Contact();
            result.Id = "001";
            result.NickName = "Daraciel";
            result.Name = "Jorge";
            result.PhoneNumber = "+34 615 645 584";
            result.Email = "daraciel@gmail.com";
            result.City = "Madrid";

            return result;
        }

        private Contact CreateContactMariela()
        {
            Contact result;
            result = new Contact();
            result.Id = "002";
            result.NickName = "Celestax";
            result.Name = "Mariela";
            result.PhoneNumber = "+34 600 500 400";
            result.Email = "dummy2@gmail.com";
            result.City = "Sax";
            return result;
        }

        private Contact CreateContactMika()
        {
            Contact result;
            result = new Contact();
            result.Id = "003";
            result.NickName = "Mehka";
            result.Name = "Mikael";
            result.PhoneNumber = "+34 521 741 954";
            result.Email = "dummy3@gmail.com";
            result.City = "Sax";
            return result;
        }

        #endregion

        #region PRIVATE METHODS

        #endregion

        #region COMMANDS

        public Chat SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;

                if (_selectedItem == null)
                    return;

                // Creando un servicio de navegación
                NavigationService.Instance.NavigateTo<ChatViewModel>(_selectedItem);

                SelectedItem = null;
            }
        }

        #endregion
    }
}
