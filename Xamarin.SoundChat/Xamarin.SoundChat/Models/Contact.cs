using Microsoft.WindowsAzure.MobileServices;

namespace Xamarin.SoundChat.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

        [Version]
        public string AzureVersion { get; set; }
    }
}
