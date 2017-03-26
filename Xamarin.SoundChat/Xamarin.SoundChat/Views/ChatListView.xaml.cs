using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.SoundChat.ViewModels;

namespace Xamarin.SoundChat.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatListView : ContentPage
    {
        public ChatListView(string username)
        {
            InitializeComponent();

            BindingContext = new ChatListViewModel(username);
        }
    }
}
