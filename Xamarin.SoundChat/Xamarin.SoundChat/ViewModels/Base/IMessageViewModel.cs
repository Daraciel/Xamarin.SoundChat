

using System;
using Xamarin.Forms;
using Xamarin.SoundChat.Models;

namespace Xamarin.SoundChat.ViewModels.Base
{
    public abstract class IMessageViewModel : BindableObject
    {
        #region FIELDS

        private Message _message;
        
        #endregion

        #region PROPERTIES

        public Message Message
        {
            get
            {
                return _message;
            }
            set
            {
                if(_message != value)
                {
                    _message = value;
                    OnPropertyChanged("Message");
                }
            }
        }
        
        #endregion

        #region CONSTRUCTORS

        public IMessageViewModel(string Id)
        {
            this.Message = new Message();
        }

        #endregion

        #region PUBLIC FUNCTIONS

        #endregion
    }
}
