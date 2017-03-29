

using System;
using Xamarin.Forms;

namespace Xamarin.SoundChat.ViewModels.Base
{
    public abstract class IMessageViewModel : BindableObject
    {
        #region FIELDS

        private ContactViewModel _source;
        private DateTime _timestamp;
        private string _text;
        
        #endregion

        #region PROPERTIES

        public ContactViewModel Source
        {
            get
            {
                return _source;
            }
            set
            {
                if(_source != value)
                {
                    _source = value;
                    OnPropertyChanged("Source");
                }
            }
        }

        public DateTime Timestamp
        {
            get
            {
                return _timestamp;
            }

            set
            {
                if(_timestamp != value)
                {
                    _timestamp = value;
                    OnPropertyChanged("Timestamp");
                }
            }

        }

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if(_text != value)
                {
                    _text = value;
                    OnPropertyChanged("Text");
                }
            }
        }

        #endregion

        #region CONSTRUCTORS

        #endregion

        #region PUBLIC FUNCTIONS

        #endregion
    }
}
