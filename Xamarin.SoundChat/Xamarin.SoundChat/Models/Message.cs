using Microsoft.WindowsAzure.MobileServices;
using System;

namespace Xamarin.SoundChat.Models
{
    public class Message
    {
        public string Id { get; set; }
        public Contact Emitter { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime TimeStamp { get; set; }

        [Version]
        public string AzureVersion { get; set; }
    }
}
