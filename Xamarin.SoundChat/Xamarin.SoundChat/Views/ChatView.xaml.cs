using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.SoundChat.ViewModels;

namespace Xamarin.SoundChat.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatView : ContentPage
    {

        public object Parameter { get; set; }

        public ChatView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = new ChatViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var viewModel = BindingContext as ChatViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }
    }
}
