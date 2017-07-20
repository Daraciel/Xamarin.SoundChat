﻿

using Xamarin.Forms;

namespace Xamarin.SoundChat.ViewModels.Base
{
    public class ViewModelBase : BindableObject
    {
        public virtual void OnAppearing(object navigationContext)
        {
        }

        public virtual void OnDisappearing()
        {
        }
    }
}
