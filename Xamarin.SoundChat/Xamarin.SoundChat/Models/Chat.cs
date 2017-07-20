
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.ObjectModel;

namespace Xamarin.SoundChat.Models
{
    public class Chat
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public ObservableCollection<Contact> Participants { get; set; }
        public ObservableCollection<Message> Messages { get; set; }
        public string ParticipantsList
        { get
            {
                string aux = string.Empty;
                for(int i=0; i<Participants.Count; i++)
                {
                    if(i != 0)
                    {
                        aux += ", ";
                    }
                    aux += Participants[i].NickName;
                }
                return aux;
            }
        }


        [Version]
        public string AzureVersion { get; set; }
    }
}
