using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App3.ViewModel
{
    public class Page1ViewModel : INotifyPropertyChanged
    {
        private bool _isAuthenticated { get; set; }
        //private string _buttonText { get; set; }
        private string _username { get; set; }

        public bool isAuthenticated {
            get { return _isAuthenticated; }
            set {
                _isAuthenticated = value;
                NotifyPropertyChaged("isAuthenticated");
            } }

        public string username
        {
            get { return _username; }
            set
            {
                _username = value;
                NotifyPropertyChaged("username");
            }
        }


        //public string buttonText
        //{
        //    get {
        //        return _buttonText;
        //        //if (isAuthenticated)
        //        //    return "Edit";
        //        //else
        //        //    return "Register";
        //    }

        //    set
        //    {
        //        _buttonText = value;
        //        NotifyPropertyChaged("buttonText");
        //    }

        //}

        public ICommand AuthenticateCommand { get; set; }
        public ICommand DeAuthenticateCommand { get; set; }


        public Page1ViewModel()
        {
            isAuthenticated = false;
            AuthenticateCommand = new Command(Authenticate);
            DeAuthenticateCommand = new Command(DeAuthenticate);
            //setButtonText();
        }

        public void Authenticate()
        {
            isAuthenticated = true;
            username = "rizla";
            //setButtonText();
        }

        public void DeAuthenticate()
        {
            isAuthenticated = false;
            //setButtonText();
        }

        //private void setButtonText()
        //{
        //    if (_isAuthenticated)
        //    {
        //        buttonText = "Edit";
        //    }
        //    else
        //    {
        //        buttonText = "Register";
        //    }

        //}

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChaged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

    }
}
