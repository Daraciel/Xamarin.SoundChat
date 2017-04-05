
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


        [Version]
        public string AzureVersion { get; set; }
    }
}
